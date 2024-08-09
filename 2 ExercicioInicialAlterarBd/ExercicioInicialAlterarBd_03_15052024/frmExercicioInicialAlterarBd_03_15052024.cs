using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercicioInicialAlterarBd_03_15052024
{
    public partial class frmExercicioInicialAlterarBd_03_15052024 : Form
    {
        OleDbCommand objComando;
        OleDbConnection objConexao;
        OleDbDataReader objLeitorBd;
        OleDbDataAdapter objAdaptador;
        DataTable objTabela;

        StreamReader objLeitor;
        string strLinhadoLeitor;

        string strValorAntigo;
        int intValorAntigo;
        public frmExercicioInicialAlterarBd_03_15052024()
        {
            InitializeComponent();
        }

        private void btnDesvCond_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Escolha uma opção", "AVISO", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                MessageBox.Show("VOCÊ ESCOLHEU OK!", "RESPOSTA");
            }
            else
            {
                MessageBox.Show("VOCÊ ESCOLHEU CANCELAR!", "RESPOSTA");
            }

            DialogResult mensagem =
              MessageBox.Show("Escolha uma opção", "AVISO", MessageBoxButtons.YesNoCancel);
            if (mensagem == DialogResult.Yes)
            {
              MessageBox.Show("VOCÊ ESCOLHEU SIM!", "RESPOSTA");
            }
            else if (mensagem == DialogResult.No)
            {
              MessageBox.Show("VOCÊ ESCOLHEU NÃO!", "RESPOSTA");
            }
            else
            {
              MessageBox.Show("VOCÊ ESCOLHEU CANCELAR!", "RESPOSTA");
            }
        }

        private void btnImpTxtWhile_Click(object sender, EventArgs e)
        {
            lstbxPreferencias.Items.Clear();
            impTxtWhile();
        }

        public void impTxtWhile()
        {
            try
            {
                objLeitor = new StreamReader(@"C:\Curso programar\C#\Preferencias\importar texto.txt");
                strLinhadoLeitor = objLeitor.ReadLine();

                while (strLinhadoLeitor != null)
                {
                    lstbxPreferencias.Items.Add(strLinhadoLeitor);
                    strLinhadoLeitor = objLeitor.ReadLine();
                }
                objLeitor.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO IMPORTAR O ARQUIVO" + ex.Message);
            }
        }

        private void btnImpBdConect_Click(object sender, EventArgs e)
        {
            lstbxPreferencias.Items.Clear();
            impBdConect();
        }

        public void impBdConect()
        {
            try
            {
                objConexao =
                    new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Curso programar\C#\Preferencias\Preferencias_3_09022024.mdb");
                objConexao.Open();

                objComando = new OleDbCommand("SELECT Descricao FROM Preferencias_3", objConexao);

                objLeitorBd = objComando.ExecuteReader();

                while (objLeitorBd.Read())
                {
                    lstbxPreferencias.Items.Add(objLeitorBd["Descricao"].ToString());
                }
                objLeitorBd.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO IMPORTAR O BANCO DE DADOS" + ex.Message);
            }
        }

        private void btnImpBdDescnect_Click(object sender, EventArgs e)
        {
            lstbxPreferencias.Items.Clear();
            impBdDesconect();
        }

        public void impBdDesconect()
        {
            try
            {
                objConexao =
                    new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Curso programar\C#\Preferencias\Preferencias_3_09022024.mdb");
                
                objComando = new OleDbCommand("SELECT Descricao FROM Preferencias_3", objConexao);
                objAdaptador = new OleDbDataAdapter(objComando);
                objTabela = new DataTable();
                objAdaptador.Fill(objTabela);

                foreach (DataRow objLinhaRow in objTabela.Rows)
                {
                    lstbxPreferencias.Items.Add(objLinhaRow["Descricao"].ToString());
                } 
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO IMPORTAR O BANCO DE DADOS" + ex.Message);
            }
        }

        private void btnLimpaTxt_Click(object sender, EventArgs e)
        {
            lstbxPreferencias.Items.Clear();
        }

        private void dtgvwPreferencias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            consultarBd();
            dtgvwPreferencias.Columns["ID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvwPreferencias.Columns["Descricao"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }

        private void btnConsultarBd_Click(object sender, EventArgs e)
        {
            consultarBd();
            dtgvwPreferencias.Columns["ID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvwPreferencias.Columns["Descricao"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }

        public void consultarBd()
        {
            try
            {
                objConexao =
                    new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Curso programar\C#\Preferencias\Preferencias_3_09022024.mdb");

                objComando = new OleDbCommand("SELECT ID, Descricao FROM Preferencias_3", objConexao);
                objAdaptador = new OleDbDataAdapter(objComando);
                objTabela = new DataTable();
                objAdaptador.Fill(objTabela);

                dtgvwPreferencias.DataSource = objTabela;

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO IMPORTAR O BANCO DE DADOS" + ex.Message);
            }
        }

        private void btnInserirBd_Click(object sender, EventArgs e)
        {
            inserirBd();
            consultarBd();
        }

        public void inserirBd()
        {
            try
            {
                objConexao =
                    new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Curso programar\C#\Preferencias\Preferencias_3_09022024.mdb");
                objConexao.Open();
                objComando = new OleDbCommand("INSERT INTO Preferencias_3 (Descricao) VALUES ('" + dtgvwPreferencias.CurrentCell.EditedFormattedValue.ToString() + "')", objConexao);

                if (objComando.ExecuteNonQuery() >0)
	            {
		          MessageBox.Show("Inserido com Sucesso");
	            }
                else
	            {
                  MessageBox.Show("ERRO AO INSERIR");      
	            }
                objConexao.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO IMPORTAR O BANCO DE DADOS" + ex.Message);
            }
        }

        private void btnExcBd_Click(object sender, EventArgs e)
        {
            excluirBd();
            consultarBd();
        }

        public void excluirBd()
        {
            try
            {
                objConexao =
                    new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Curso programar\C#\Preferencias\Preferencias_3_09022024.mdb");
                objConexao.Open();

                objComando = new OleDbCommand("DELETE FROM Preferencias_3 WHERE Descricao = '" + dtgvwPreferencias.CurrentCell.EditedFormattedValue.ToString() + "' ", objConexao);

                if (objComando.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Excluido com Sucesso");
                }
                else
                {
                    MessageBox.Show("ERRO AO EXCLUIR");
                }
                objConexao.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO IMPORTAR O BANCO DE DADOS" + ex.Message);
            }
        }

        private void btnAltBd_Click(object sender, EventArgs e)
        {
            alterarBd();
            consultarBd();
        }

        public void alterarBd()
        {
            try
            {
                objConexao =
                    new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Curso programar\C#\Preferencias\Preferencias_3_09022024.mdb");
                objConexao.Open();

                objComando = new OleDbCommand("UPDATE Preferencias_3 SET Descricao = '" + dtgvwPreferencias.CurrentRow.Cells["Descricao"].EditedFormattedValue.ToString() + "' WHERE ID = " + intValorAntigo, objConexao);

                if (objComando.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Alterado com Sucesso");
                }
                else
                {
                    MessageBox.Show("ERRO AO ALTERAR");
                }
                objConexao.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO IMPORTAR O BANCO DE DADOS " + ex.Message);
            }
        }

        private void btnLimpaGrid_Click(object sender, EventArgs e)
        {
            dtgvwPreferencias.DataSource = null;
        }

        private void dtgvwPreferencias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            strValorAntigo = dtgvwPreferencias.CurrentRow.Cells["Descricao"].EditedFormattedValue.ToString();
            intValorAntigo = Convert.ToInt32(string.IsNullOrEmpty(dtgvwPreferencias.CurrentRow.Cells["ID"].EditedFormattedValue.ToString()) ? 0 : Convert.ToInt32(dtgvwPreferencias.CurrentRow.Cells["ID"].EditedFormattedValue.ToString()));
        }

        private void frmExercicioInicialAlterarBd_03_15052024_Load(object sender, EventArgs e)
        {
            consultarBd();
            dtgvwPreferencias.Columns["ID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvwPreferencias.Columns["Descricao"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }
        
    }
}
