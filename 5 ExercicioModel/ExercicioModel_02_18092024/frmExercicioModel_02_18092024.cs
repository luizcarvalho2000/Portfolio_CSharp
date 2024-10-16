using Model_VO;
using Business_BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercicioModel_02_18092024
{
    public partial class frmExercicioModel_02_18092024 : Form
    {
        PreferenciasVO objPreferenciasVO;
        Preferencias objPreferencias;
        string strValorAntigo;
        int intValorAntigo;
        bool bolPrefInc;
        public frmExercicioModel_02_18092024()
        {
            InitializeComponent();
        }

        private void btnDesvCond_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ESCOLHA UMA OPÇÃO", "OPÇÕES", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                MessageBox.Show("Você escolheu OK");
            }
            else
            {
                MessageBox.Show("Você escolheu Cancelar");
            }
        }

        private void btnImpTxtWhile_Click(object sender, EventArgs e)
        {
            impTxtWhile();
        }

        public void impTxtWhile()
        {
            lstbxPreferencias.Items.Clear();
            objPreferencias = new Preferencias();
            lstbxPreferencias.Items.AddRange(objPreferencias.impTxtWhile().ToArray());
        }

        private void impBdConect_Click(object sender, EventArgs e)
        {
            lstbxPreferencias.Items.Clear();
            objPreferencias = new Preferencias();
            lstbxPreferencias.Items.AddRange(objPreferencias.impBdConect().ToArray());
        }    

        private void impBdDesconect_Click(object sender, EventArgs e)
        {
            lstbxPreferencias.Items.Clear();
            objPreferencias = new Preferencias();
            lstbxPreferencias.Items.AddRange(objPreferencias.ImpBdDesconect().ToArray());
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
                objPreferencias = new Preferencias();
                objPreferenciasVO = new PreferenciasVO();
                if (!string.IsNullOrEmpty(strDescricao))
                {
                    objPreferenciasVO.DESCRICAO = strDescricao;
                }
                bndSrcPreferencias.DataSource = objPreferencias.consultarBd(objPreferenciasVO);
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
                objPreferencias = new Preferencias();
                objPreferenciasVO = new PreferenciasVO();

                if (!string.IsNullOrEmpty(strParDescricao))
                {
                    objPreferenciasVO.DESCRICAO = strParDescricao;
                }

                if (objPreferencias.inserirBd(objPreferenciasVO))
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
            excluirBd(intValorAntigo);
            consultarBd();
        }

        public void excluirBd(int intParID)
        {
            try
            {
                objPreferencias = new Preferencias();

                objPreferenciasVO = new PreferenciasVO();

                if (!string.IsNullOrEmpty(intParID.ToString()))
                {
                    objPreferenciasVO.ID = Convert.ToInt32(intParID);
                }

                if (objPreferencias.excluirBd(objPreferenciasVO))
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
                objPreferencias = new Preferencias();
                objPreferenciasVO = new PreferenciasVO();

                if (!string.IsNullOrEmpty(strParValorNovo))
                {
                    objPreferenciasVO.DESCRICAO = strParValorNovo;
                }

                if (!string.IsNullOrEmpty(intId.ToString()))
                {
                    objPreferenciasVO.ID = Convert.ToInt32(intId);
                }

                if (objPreferencias.alterarBd(objPreferenciasVO))
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


        private void btnLimpGrid_Click(object sender, EventArgs e)
        {
            dtgvwPreferencias.DataSource = null;
        }

        private void dtgvwPreferencias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            strValorAntigo = dtgvwPreferencias.CurrentRow.Cells["Descricao"].EditedFormattedValue.ToString();
            intValorAntigo = Convert.ToInt32(string.IsNullOrEmpty(dtgvwPreferencias.CurrentRow.Cells["ID"].EditedFormattedValue.ToString()) ?
                0 : Convert.ToInt32(dtgvwPreferencias.CurrentRow.Cells["ID"].EditedFormattedValue.ToString()));
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

        private void bndNavBtnPesquisar_Click(object sender, EventArgs e)
        {
            consultarBd(bndNavTxtPesquisar.Text);
            dtgvwPreferencias.Columns["ID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvwPreferencias.Columns["Descricao"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirmar exclusão de preferencias '" + strValorAntigo + "' ", "ExclusãoBd", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                excluirBd(intValorAntigo);
            }
            consultarBd();
        }

        private void frmExercicioModel_02_18092024_Load(object sender, EventArgs e)
        {
            consultarBd();
            impTxtWhile();
            dtgvwPreferencias.Columns["ID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvwPreferencias.Columns["Descricao"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
