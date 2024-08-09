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

namespace ExercicioImportarBdDesconect_01_14022024
{
    public partial class Form1 : Form
    {
        StreamReader objLeitor;
        string srtLinhaDoLeitor;

        OleDbCommand objComando;
        OleDbConnection objConexao;
        OleDbDataReader objLeitorBd;
        OleDbDataAdapter objAdaptador;
        DataTable objTabela;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnMensagem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bem vindo ao meu programa em C-Sharp");
        }

        private void btnDesvCond_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ESCOLHA UMA OPÇÃO", "OPÇÕES", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                MessageBox.Show("VOCÊ ESCOLHEU OK!", "RESPOSTA");
            }
            else
            {
                MessageBox.Show("VOCÊ ESCOLHEU CANCELAR!", "RESPOSTA");
            }
        }

        private void btnDesvEncad_Click(object sender, EventArgs e)
        {
            DialogResult mensagem = MessageBox.Show("Escolha Sim, Não ou Cancelar", "AVISO", MessageBoxButtons.YesNoCancel);
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

        private void btnSwitchCase_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Escolha Sim, Não ou Cancelar", "AVISO", MessageBoxButtons.YesNoCancel))
            {
                case DialogResult.Yes:
                    MessageBox.Show("Você escolheu Sim!", "RESPOSTA");
                    break;
                case DialogResult.No:
                    MessageBox.Show("Você escolheu Não!", "RESPOSTA");
                    break;

                case DialogResult.Cancel:
                    MessageBox.Show("Você escolheu Cancelar!", "RESPOSTA");
                    break;
                default:
                    MessageBox.Show("Você escolheu Errado!", "RESPOSTA");
                    break; 

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
                srtLinhaDoLeitor = objLeitor.ReadLine();

                while (srtLinhaDoLeitor != null)
                {
                    lstbxPreferencias.Items.Add(srtLinhaDoLeitor);
                    srtLinhaDoLeitor = objLeitor.ReadLine();
                }
                objLeitor.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO IMPORTAR ARQUIVO" + ex.Message);                
            }
        }

        private void btnImpTxtDoWhile_Click(object sender, EventArgs e)
        {
            lstbxPreferencias.Items.Clear();
            impTxtDoWhile();
        }

        public void impTxtDoWhile()
        {
            try
            {
                objLeitor = new StreamReader(@"C:\Curso programar\C#\Preferencias\importar texto.txt");
                srtLinhaDoLeitor = objLeitor.ReadLine();

                do
                {
                    lstbxPreferencias.Items.Add(srtLinhaDoLeitor);
                    srtLinhaDoLeitor = objLeitor.ReadLine();

                } while (srtLinhaDoLeitor != null);
                
                objLeitor.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO IMPORTAR ARQUIVO" + ex.Message);
            }
        }

        private void btnImpTxtFor_Click(object sender, EventArgs e)
        {
            lstbxPreferencias.Items.Clear();
            impTxtFor();
        }

        public void impTxtFor()
        {
            try
            {
                objLeitor = new StreamReader(@"C:\Curso programar\C#\Preferencias\importar texto.txt");
                srtLinhaDoLeitor = objLeitor.ReadLine();

                for (srtLinhaDoLeitor = objLeitor.ReadLine(); srtLinhaDoLeitor != null; srtLinhaDoLeitor = objLeitor.ReadLine())
                {
                    lstbxPreferencias.Items.Add(srtLinhaDoLeitor);

                }
                objLeitor.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO IMPORTAR ARQUIVO" + ex.Message);
            }
        }

        private void btnImpTxtForEach_Click(object sender, EventArgs e)
        {
            lstbxPreferencias.Items.Clear();
            impTxtForEach();
        }

        public void impTxtForEach()
        {
            try
            {
                //Leitura do arquivo com File.ReadAllLines para matriz de string das linhas do arquivo utilizando um vetor de string, array de string           
                //string[] linhasDoArquivo = File.ReadAllLines(@"C:\Curso programar\C#\ExercicioInicialJanelasGraficas_05_06122023\importar texto.txt");


                // leitura com streamReader
                //objLeitor = new StreamReader(@"C:\Curso programar\C#\ExercicioInicialJanelasGraficas_05_06122023\importar texto.txt");
                //string [] linhasDoArquivo = objLeitor.ReadToEnd().Split('\n');
                //objLeitor.Close();

                // Leitura com alimentação de lista
                objLeitor = new StreamReader(@"C:\Curso programar\C#\Preferencias\importar texto.txt");
                List<string> linhaDoArquivo = objLeitor.ReadToEnd().Split('\n').ToList();
                objLeitor.Close();

                foreach (string linha in linhaDoArquivo)
                {
                    lstbxPreferencias.Items.Add(linha);
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO IMPORTAR ARQUIVO" + ex.Message);
            }
        }

        private void btnImpBdConect_Click(object sender, EventArgs e)
        {
            lstbxPreferencias.Items.Clear();
            impBdConectado();
        }

        public void impBdConectado()
        {
            try
            {
                objConexao =
                    new OleDbConnection(
                        @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Curso programar\C#\Preferencias\Preferencias_3_09022024.mdb");
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
                MessageBox.Show("Erro ao ler o Banco" + ex.Message);
            }
        }

        private void btnImpBdDesconect_Click(object sender, EventArgs e)
        {
            lstbxPreferencias.Items.Clear();
            impBdDesconectado();
        }

        public void impBdDesconectado()
        {
            try
            {
                objConexao =
                    new OleDbConnection(
                       @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Curso programar\C#\Preferencias\Preferencias_3_09022024.mdb");

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
                MessageBox.Show("Erro ao ler o Banco" + ex.Message);
            }
        }

        private void BtnLimpaTxt_Click(object sender, EventArgs e)
        {
            lstbxPreferencias.Items.Clear();
        }

    }
}
