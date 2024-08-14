using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_BLL;
using System.Data.OleDb;

namespace ExercicioAlterarBdDAO_03_07082024
{
    public partial class frmExercicioAlterarBdDAO_03_07082024 : Form
    {
        PreferenciasBusiness objPreferenciasBusiness;
        string strValorAntigo;
        int intValorAntigo;

        bool bolPrefInc;

        public frmExercicioAlterarBdDAO_03_07082024()
        {
            InitializeComponent();
        }

        private void btnDesvCond_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ESCOLHA UMA OPÇÃO", "OPÇÕES", MessageBoxButtons.OKCancel) == DialogResult.OK)
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
            impTxtWhile();
        }
        public void impTxtWhile()
        {
            try
            {
                lstbxPreferencias.Items.Clear();
                objPreferenciasBusiness = new PreferenciasBusiness();
                lstbxPreferencias.Items.AddRange(objPreferenciasBusiness.impTxtWhile().ToArray());
            }
            catch (Exception)
            {

                MessageBox.Show("ERRO AO EXECULTAR A CONSULTA!"); 
            }
        }


        private void btnImpBdConect_Click(object sender, EventArgs e)
        {
            lstbxPreferencias.Items.Clear();
            objPreferenciasBusiness = new PreferenciasBusiness();
            lstbxPreferencias.Items.AddRange(objPreferenciasBusiness.impBdConect().ToArray());
        }

        private void btnImpBdDesc_Click(object sender, EventArgs e)
        {
            lstbxPreferencias.Items.Clear();
            objPreferenciasBusiness = new PreferenciasBusiness();
            lstbxPreferencias.Items.AddRange(objPreferenciasBusiness.impBdDescon().ToArray());
        }

        private void btnLimpTxt_Click(object sender, EventArgs e)
        {
            lstbxPreferencias.Items.Clear();
        }

        private void btnConsultarBd_Click(object sender, EventArgs e)
        {
            consultarBd();
            dtgvwPreferencias.Columns["ID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvwPreferencias.Columns["Descricao"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        public void consultarBd(string strDescricao = null)
        {
            try
            {
                objPreferenciasBusiness = new PreferenciasBusiness();
                bndSrcPreferencias.DataSource = objPreferenciasBusiness.consultarBd(strDescricao);
                dtgvwPreferencias.DataSource = bndSrcPreferencias;
            }
            catch (Exception)
            {
                MessageBox.Show("ERRO AO EXECULTAR A CONSULTA!");
            }
        }

        private void btnInserirBd_Click(object sender, EventArgs e)
        {
            inserirBd(dtgvwPreferencias.CurrentCell.EditedFormattedValue.ToString());
            consultarBd();
        }

        public void inserirBd(string strParDescricao)
        {
            try
            {
                objPreferenciasBusiness = new PreferenciasBusiness();

                if (objPreferenciasBusiness.inserirBd(strParDescricao))
                {
                    MessageBox.Show("INSERIDO COM SUCESSO!");
                }
                else
                {
                    MessageBox.Show("ERRO AO TENTAR INSERIR!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ERRO AO CONSULTAR O INSERIR!");
            }
        }

        private void btnExcluirBd_Click(object sender, EventArgs e)
        {
            excluirBd(strValorAntigo);
            consultarBd();
        }

        public void excluirBd(string strParDelDescricao)
        {
            try
            {
                objPreferenciasBusiness = new PreferenciasBusiness();

                if (objPreferenciasBusiness.excluirBd(strParDelDescricao))
                {
                    MessageBox.Show("EXCLUIDO COM SUCESSO!");
                }
                else
                {
                    MessageBox.Show("ERRO AO TENTAR EXCLUIR!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ERRO AO CONSULTAR A EXCLUSÃO!");
            }
        }

        private void btnAlterarBd_Click(object sender, EventArgs e)
        {
            alterarBd(dtgvwPreferencias.CurrentRow.Cells["Descricao"].EditedFormattedValue.ToString(), intValorAntigo);
            consultarBd();
        }

        public void alterarBd(string strParValorNovo, int intId)
        {
            try
            {
                objPreferenciasBusiness = new PreferenciasBusiness();

                if (objPreferenciasBusiness.alterarBd(strParValorNovo, intId))
                {
                    MessageBox.Show("Alteração realizada com sucesso!");
                }
                else
                {
                    MessageBox.Show("Erro ao alterar.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao consultar O BANCO DE DADOS.");
            }
        }

        private void btnLimpBd_Click(object sender, EventArgs e)
        {
            dtgvwPreferencias.DataSource = null;
        }

        private void dtgvwPreferencias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            strValorAntigo = dtgvwPreferencias.CurrentRow.Cells["Descricao"].EditedFormattedValue.ToString();
            intValorAntigo = Convert.ToInt32(string.IsNullOrEmpty(dtgvwPreferencias.CurrentRow.Cells["ID"].EditedFormattedValue.ToString()) ? 0 : Convert.ToInt32(dtgvwPreferencias.CurrentRow.Cells["ID"].EditedFormattedValue.ToString()));
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            bolPrefInc = true;
        }

        private void bndNavBtnConfirmar_Click(object sender, EventArgs e)
        {

            if (bolPrefInc)
            {
                if (MessageBox.Show("Confirmar inclusão de preferencias '" + dtgvwPreferencias.CurrentCell.EditedFormattedValue.ToString() + "' ", "inclusãoBd", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    inserirBd(dtgvwPreferencias.CurrentCell.EditedFormattedValue.ToString());
                }
                bolPrefInc = false;
            }
            else
            {
                if (MessageBox.Show("Confirmar alteração de preferencias '" + strValorAntigo + "' para '" + dtgvwPreferencias.CurrentCell.EditedFormattedValue.ToString() + "' ", "alteraçãoBd", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    alterarBd(dtgvwPreferencias.CurrentCell.EditedFormattedValue.ToString(), intValorAntigo);
                }
            }
            consultarBd();
        }

        private void bndNavTxt_Click(object sender, EventArgs e)
        {
            
        }

        private void bndNavPesquisar_Click(object sender, EventArgs e)
        {
            consultarBd(bndNavTxt.Text);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirmar exclusão de preferencias '" + strValorAntigo + "' ", "ExclusãoBd", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                excluirBd(strValorAntigo);
            }
            consultarBd();
        }

        private void frmExercicioAlterarBdDAO_03_07082024_Load(object sender, EventArgs e)
        {
            consultarBd();
            impTxtWhile();
            dtgvwPreferencias.Columns["ID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvwPreferencias.Columns["Descricao"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
