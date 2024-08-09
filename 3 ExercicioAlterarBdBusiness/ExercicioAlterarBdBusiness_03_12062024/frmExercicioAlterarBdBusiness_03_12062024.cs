using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
using System.Data.OleDb;

namespace ExercicioAlterarBdBusiness_03_12062024
{
    public partial class frmExercicioAlterarBdBusiness_03_12062024 : Form
    {
        Preferencias objPreferencias;

        string strValorantigo;
        int intValorAntigo;

        OleDbConnection objConexao;
        OleDbCommand objComando;
        OleDbDataAdapter objAdaptador;
        OleDbDataReader objLeitorBd;
        DataTable objTabela;

        bool bolPrefInc;

        public frmExercicioAlterarBdBusiness_03_12062024()
        {
            InitializeComponent();
        }

        private void btnDesvCond_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ESCOLHA UMA OPÇÃO", "OPÇÃO", MessageBoxButtons.OKCancel) ==  DialogResult.OK)
            {
                MessageBox.Show("VOCÊ ESCOLHEU OK!"); 
            }
            else
            {
                MessageBox.Show("VOCÊ ESCOLHEU CANCELAR!");
            }
        }

        private void btnImpTxtWhile_Click(object sender, EventArgs e)
        {
            lstbxPreferencias.Items.Clear();
            objPreferencias = new Preferencias();
            lstbxPreferencias.Items.AddRange(objPreferencias.impTxtWhile().ToArray());
        }

        private void btnImpBdConect_Click(object sender, EventArgs e)
        {
            lstbxPreferencias.Items.Clear();
            objPreferencias = new Preferencias();
            lstbxPreferencias.Items.AddRange(objPreferencias.impbdConect().ToArray());
        }

        private void btnImpBdDescnect_Click(object sender, EventArgs e)
        {
            lstbxPreferencias.Items.Clear();
            objPreferencias = new Preferencias();
            lstbxPreferencias.Items.AddRange(objPreferencias.impbdDesconect().ToArray());
        }

        private void btnLimpaGrid_Click(object sender, EventArgs e)
        {
            lstbxPreferencias.Items.Clear();
        }

        private void btnConsultBd_Click(object sender, EventArgs e)
        {
            consultarBd();
            dtgdvwPreferencias.Columns["ID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgdvwPreferencias.Columns["Descricao"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }

        public void consultarBd(string strDescricao = null)
        {
            try
            {
                objPreferencias = new Preferencias();
                bndSrcPreferencias.DataSource = objPreferencias.consultarBd(strDescricao);
                dtgdvwPreferencias.DataSource = bndSrcPreferencias;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO IMPORTAR O BANCO" + ex.Message);
            }
        }

        private void btnInserirBd_Click(object sender, EventArgs e)
        {
            inserirBd(dtgdvwPreferencias.CurrentCell.EditedFormattedValue.ToString());
            consultarBd();
        }

        public void inserirBd(string strParDescricao)
        {
            try                
            {
                objPreferencias = new Preferencias();

                if (objPreferencias.inserirBd(strParDescricao))
                {
                    MessageBox.Show("INSERIDO COM SUCESSO");
                }
                else
                {
                    MessageBox.Show("ERRO AO INSERIR");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO IMPORTAR O BANCO" + ex.Message);
            }
        }

        private void btnDelBd_Click(object sender, EventArgs e)
        {
            excluirBd(strValorantigo);
            consultarBd();
        }

        public void excluirBd(string strParDelPreferencias)
        {
            try                
            {
                objPreferencias = new Preferencias();

                if (objPreferencias.exluirBd(strParDelPreferencias))
                {
                    MessageBox.Show("DELETADO COM SUCESSO");
                }
                else
                {
                    MessageBox.Show("ERRO AO DELETAR");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO IMPORTAR O BANCO" + ex.Message);
            }
        
        }

        private void btnAltBd_Click(object sender, EventArgs e)
        {
            alteraBd(dtgdvwPreferencias.CurrentRow.Cells["Descricao"].EditedFormattedValue.ToString(), strValorantigo);            
            consultarBd();
        }

        public void alteraBd(string strParValorNovo, string strParValorAntigo)
        {
            try                
            {
                objPreferencias = new Preferencias();

                if (objPreferencias.alterarbd(strParValorNovo, strParValorAntigo))
                {
                    MessageBox.Show("ALTERADO COM SUCESSO");
                }
                else
                {
                    MessageBox.Show("ERRO AO ALTERAR");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO IMPORTAR O BANCO" + ex.Message);
            }
        
        
        }

        private void btnLimpGrid_Click(object sender, EventArgs e)
        {
            dtgdvwPreferencias.DataSource = null;
        }

        private void dtgdvwPreferencias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            strValorantigo = dtgdvwPreferencias.CurrentRow.Cells["Descricao"].EditedFormattedValue.ToString();
            intValorAntigo = Convert.ToInt32(string.IsNullOrEmpty(dtgdvwPreferencias.CurrentRow.Cells["ID"].EditedFormattedValue.ToString()) ? 0 : Convert.ToInt32(dtgdvwPreferencias.CurrentRow.Cells["ID"].EditedFormattedValue.ToString()));
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            bolPrefInc = true;
        }

        private void btnBndNavConfirmar_Click(object sender, EventArgs e)
        {
            if (bolPrefInc)
            {
                if (MessageBox.Show("Confirmar inclusão de preferencias '" + dtgdvwPreferencias.CurrentCell.EditedFormattedValue.ToString() + "' ", "inclusãoBd", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    inserirBd(dtgdvwPreferencias.CurrentCell.EditedFormattedValue.ToString());
                }
                bolPrefInc = false;
            }
            else
            {
                if (MessageBox.Show("Confirmar alteração da preferencia '" + strValorantigo + "' pelo valor " + dtgdvwPreferencias.CurrentCell.EditedFormattedValue.ToString() + " ? ", "alterarBd", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    alteraBd(dtgdvwPreferencias.CurrentCell.EditedFormattedValue.ToString(), strValorantigo);
                }
            }
           
            consultarBd();
        }

        private void btnbndNavPesquisar_Click(object sender, EventArgs e)
        {
            consultarBd(bndNavTxtPersquisar.Text);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirmar a Exclusão da preferencia '" + strValorantigo + "' ", "ExclusãoBd", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                excluirBd(strValorantigo);
            }
            consultarBd();
        }

        private void frmExercicioAlterarBdBusiness_03_12062024_Load(object sender, EventArgs e)
        {
            consultarBd();
            dtgdvwPreferencias.Columns["ID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgdvwPreferencias.Columns["Descricao"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }


    }
}
