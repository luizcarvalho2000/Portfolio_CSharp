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

namespace ExercicioAlterarDAO_03_10072024
{
    public partial class frmExercicioAlterarDAO_03_10072024 : Form
    {
        PreferenciasBusiness objPreferencias;

        string strValorAntigo;
        int intValorAntigo;

        bool bolPrefInc;

        public frmExercicioAlterarDAO_03_10072024()
        {
            InitializeComponent();
        }

        private void btnDesvCond_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ESCOLHA UMA OPÇÃO", "OPÇÃO", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                MessageBox.Show("OPÇÃO SELECIONADA: OK!");
            }
            else
            {
                MessageBox.Show("OPÇÃO SELECIONADA: CANCELAR!");
            }

        }


        private void btnImpTxtWhile_Click(object sender, EventArgs e)
        {
            lstbxPreferencias.Items.Clear();
            objPreferencias = new PreferenciasBusiness();
            lstbxPreferencias.Items.AddRange(objPreferencias.impTxtWhile().ToArray());
        }

        private void btnImpBdConect_Click(object sender, EventArgs e)
        {
            lstbxPreferencias.Items.Clear();
            objPreferencias = new PreferenciasBusiness();
            lstbxPreferencias.Items.AddRange(objPreferencias.impBdConect().ToArray());
        }

        private void btnImpBdDesconect_Click(object sender, EventArgs e)
        {
            lstbxPreferencias.Items.Clear();
            objPreferencias = new PreferenciasBusiness();
            lstbxPreferencias.Items.AddRange(objPreferencias.impBdDesconect().ToArray());
        }

        private void btnLimpTxt_Click(object sender, EventArgs e)
        {
            lstbxPreferencias.Items.Clear();
        }

        private void btnConsultBd_Click(object sender, EventArgs e)
        {
            consultarBd();
            dtgvwPrferencias.Columns["ID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvwPrferencias.Columns["Descricao"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

        }

        public void consultarBd(string strDescricao = null)
        {
            try
            {
                objPreferencias = new PreferenciasBusiness();
                bndSrcPreferencias.DataSource = objPreferencias.consultarBd(strDescricao);
                dtgvwPrferencias.DataSource = bndSrcPreferencias;
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao consultar O BANCO DE DADOS.");
            }
        }

        private void btnInserirBd_Click(object sender, EventArgs e)
        {
            inserirBd(dtgvwPrferencias.CurrentCell.EditedFormattedValue.ToString());
            consultarBd();
        }

        public void inserirBd(string strParDescricao)
        {
            try
            {
                objPreferencias = new PreferenciasBusiness();

                if (objPreferencias.inserirBd(strParDescricao))
                { 
                    MessageBox.Show("Inserção realizada com sucesso!");
                }
                else
                {
                    MessageBox.Show("Erro ao inserir.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao consultar O BANCO DE DADOS.");
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
                objPreferencias = new PreferenciasBusiness();

                if (objPreferencias.excluirBd(strParDelDescricao))
                {
                    MessageBox.Show("Exclusão realizada com sucesso!");
                }
                else
                {
                    MessageBox.Show("Erro ao excluir.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao consultar O BANCO DE DADOS.");
            }
        }

        private void btnAlterarBd_Click(object sender, EventArgs e)
        {
            alterarBd(dtgvwPrferencias.CurrentRow.Cells["Descricao"].EditedFormattedValue.ToString(), strValorAntigo);
            consultarBd();
        }

        public void alterarBd(string strParValorNovo, string strParValorAntigo)
        {
            try
            {
                objPreferencias = new PreferenciasBusiness();

                if (objPreferencias.alterarBd(strParValorNovo, strParValorAntigo))
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

        private void LimpGrid_Click(object sender, EventArgs e)
        {
            dtgvwPrferencias.DataSource = null;
        }

        private void dtgvwPrferencias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            strValorAntigo = dtgvwPrferencias.CurrentRow.Cells["Descricao"].EditedFormattedValue.ToString();
            intValorAntigo = Convert.ToInt32(string.IsNullOrEmpty(dtgvwPrferencias.CurrentRow.Cells["ID"].EditedFormattedValue.ToString()) ? 0 : Convert.ToInt32(dtgvwPrferencias.CurrentRow.Cells["ID"].EditedFormattedValue.ToString()));
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            bolPrefInc = true;
        }

        private void btnBdnNavConfirmar_Click(object sender, EventArgs e)
        {
            if (bolPrefInc)
            {
                if (MessageBox.Show("Confirmar inclusão de preferencias '" + dtgvwPrferencias.CurrentCell.EditedFormattedValue.ToString() + "' ", "inclusãoBd", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    inserirBd(dtgvwPrferencias.CurrentCell.EditedFormattedValue.ToString());
                }
                bolPrefInc = false;
            }
            else
            {
                if (MessageBox.Show("Confirmar alteração de preferencias '" + strValorAntigo + "' para '" + dtgvwPrferencias.CurrentCell.EditedFormattedValue.ToString() + "' ", "alteraçãoBd", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    alterarBd(dtgvwPrferencias.CurrentCell.EditedFormattedValue.ToString(), strValorAntigo);
                }
            }
            consultarBd();
        }

        private void btnBndNavPesquisarTxt_Click(object sender, EventArgs e)
        {
            consultarBd(bndNavTxtPreferencias.Text);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirmar exclusão de preferencias '" + strValorAntigo + "' ", "ExclusãoBd", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                excluirBd(strValorAntigo);
            }
            consultarBd();
        }

        private void frmExercicioAlterarDAO_03_10072024_Load(object sender, EventArgs e)
        {
            consultarBd();
            dtgvwPrferencias.Columns["ID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvwPrferencias.Columns["Descricao"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }
    }
}
