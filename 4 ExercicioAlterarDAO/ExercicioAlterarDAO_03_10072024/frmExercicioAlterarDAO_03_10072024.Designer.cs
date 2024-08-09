namespace ExercicioAlterarDAO_03_10072024
{
    partial class frmExercicioAlterarDAO_03_10072024
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExercicioAlterarDAO_03_10072024));
            this.btnDesvCond = new System.Windows.Forms.Button();
            this.btnImpTxtWhile = new System.Windows.Forms.Button();
            this.btnImpBdConect = new System.Windows.Forms.Button();
            this.btnImpBdDesconect = new System.Windows.Forms.Button();
            this.btnLimpTxt = new System.Windows.Forms.Button();
            this.btnConsultBd = new System.Windows.Forms.Button();
            this.btnInserirBd = new System.Windows.Forms.Button();
            this.btnExcluirBd = new System.Windows.Forms.Button();
            this.btnAlterarBd = new System.Windows.Forms.Button();
            this.LimpGrid = new System.Windows.Forms.Button();
            this.bndSrcPreferencias = new System.Windows.Forms.BindingSource(this.components);
            this.bndNavPreferencias = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnBdnNavConfirmar = new System.Windows.Forms.ToolStripButton();
            this.bndNavTxtPreferencias = new System.Windows.Forms.ToolStripTextBox();
            this.btnBndNavPesquisarTxt = new System.Windows.Forms.ToolStripButton();
            this.dtgvwPrferencias = new System.Windows.Forms.DataGridView();
            this.lstbxPreferencias = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.bndSrcPreferencias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndNavPreferencias)).BeginInit();
            this.bndNavPreferencias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvwPrferencias)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDesvCond
            // 
            this.btnDesvCond.Location = new System.Drawing.Point(12, 12);
            this.btnDesvCond.Name = "btnDesvCond";
            this.btnDesvCond.Size = new System.Drawing.Size(281, 41);
            this.btnDesvCond.TabIndex = 0;
            this.btnDesvCond.Text = "Desvio Condicional";
            this.btnDesvCond.UseVisualStyleBackColor = true;
            this.btnDesvCond.Click += new System.EventHandler(this.btnDesvCond_Click);
            // 
            // btnImpTxtWhile
            // 
            this.btnImpTxtWhile.Location = new System.Drawing.Point(12, 53);
            this.btnImpTxtWhile.Name = "btnImpTxtWhile";
            this.btnImpTxtWhile.Size = new System.Drawing.Size(281, 41);
            this.btnImpTxtWhile.TabIndex = 1;
            this.btnImpTxtWhile.Text = "Importar Texto While";
            this.btnImpTxtWhile.UseVisualStyleBackColor = true;
            this.btnImpTxtWhile.Click += new System.EventHandler(this.btnImpTxtWhile_Click);
            // 
            // btnImpBdConect
            // 
            this.btnImpBdConect.Location = new System.Drawing.Point(12, 94);
            this.btnImpBdConect.Name = "btnImpBdConect";
            this.btnImpBdConect.Size = new System.Drawing.Size(281, 41);
            this.btnImpBdConect.TabIndex = 2;
            this.btnImpBdConect.Text = "Importar Banco Conectado";
            this.btnImpBdConect.UseVisualStyleBackColor = true;
            this.btnImpBdConect.Click += new System.EventHandler(this.btnImpBdConect_Click);
            // 
            // btnImpBdDesconect
            // 
            this.btnImpBdDesconect.Location = new System.Drawing.Point(12, 135);
            this.btnImpBdDesconect.Name = "btnImpBdDesconect";
            this.btnImpBdDesconect.Size = new System.Drawing.Size(281, 41);
            this.btnImpBdDesconect.TabIndex = 3;
            this.btnImpBdDesconect.Text = "Importar Banco Desconectado";
            this.btnImpBdDesconect.UseVisualStyleBackColor = true;
            this.btnImpBdDesconect.Click += new System.EventHandler(this.btnImpBdDesconect_Click);
            // 
            // btnLimpTxt
            // 
            this.btnLimpTxt.Location = new System.Drawing.Point(12, 176);
            this.btnLimpTxt.Name = "btnLimpTxt";
            this.btnLimpTxt.Size = new System.Drawing.Size(281, 41);
            this.btnLimpTxt.TabIndex = 4;
            this.btnLimpTxt.Text = "Limpar texto";
            this.btnLimpTxt.UseVisualStyleBackColor = true;
            this.btnLimpTxt.Click += new System.EventHandler(this.btnLimpTxt_Click);
            // 
            // btnConsultBd
            // 
            this.btnConsultBd.Location = new System.Drawing.Point(12, 265);
            this.btnConsultBd.Name = "btnConsultBd";
            this.btnConsultBd.Size = new System.Drawing.Size(281, 41);
            this.btnConsultBd.TabIndex = 5;
            this.btnConsultBd.Text = "Consultar Bd";
            this.btnConsultBd.UseVisualStyleBackColor = true;
            this.btnConsultBd.Click += new System.EventHandler(this.btnConsultBd_Click);
            // 
            // btnInserirBd
            // 
            this.btnInserirBd.Location = new System.Drawing.Point(12, 306);
            this.btnInserirBd.Name = "btnInserirBd";
            this.btnInserirBd.Size = new System.Drawing.Size(281, 41);
            this.btnInserirBd.TabIndex = 6;
            this.btnInserirBd.Text = "Inserir Bd";
            this.btnInserirBd.UseVisualStyleBackColor = true;
            this.btnInserirBd.Click += new System.EventHandler(this.btnInserirBd_Click);
            // 
            // btnExcluirBd
            // 
            this.btnExcluirBd.Location = new System.Drawing.Point(12, 347);
            this.btnExcluirBd.Name = "btnExcluirBd";
            this.btnExcluirBd.Size = new System.Drawing.Size(281, 41);
            this.btnExcluirBd.TabIndex = 7;
            this.btnExcluirBd.Text = "Excluir BD";
            this.btnExcluirBd.UseVisualStyleBackColor = true;
            this.btnExcluirBd.Click += new System.EventHandler(this.btnExcluirBd_Click);
            // 
            // btnAlterarBd
            // 
            this.btnAlterarBd.Location = new System.Drawing.Point(12, 388);
            this.btnAlterarBd.Name = "btnAlterarBd";
            this.btnAlterarBd.Size = new System.Drawing.Size(281, 41);
            this.btnAlterarBd.TabIndex = 8;
            this.btnAlterarBd.Text = "Alterar Bd";
            this.btnAlterarBd.UseVisualStyleBackColor = true;
            this.btnAlterarBd.Click += new System.EventHandler(this.btnAlterarBd_Click);
            // 
            // LimpGrid
            // 
            this.LimpGrid.Location = new System.Drawing.Point(12, 429);
            this.LimpGrid.Name = "LimpGrid";
            this.LimpGrid.Size = new System.Drawing.Size(281, 41);
            this.LimpGrid.TabIndex = 9;
            this.LimpGrid.Text = "Limpar Bd";
            this.LimpGrid.UseVisualStyleBackColor = true;
            this.LimpGrid.Click += new System.EventHandler(this.LimpGrid_Click);
            // 
            // bndNavPreferencias
            // 
            this.bndNavPreferencias.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bndNavPreferencias.BindingSource = this.bndSrcPreferencias;
            this.bndNavPreferencias.CountItem = this.bindingNavigatorCountItem;
            this.bndNavPreferencias.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bndNavPreferencias.Dock = System.Windows.Forms.DockStyle.None;
            this.bndNavPreferencias.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bndNavPreferencias.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.btnBdnNavConfirmar,
            this.bndNavTxtPreferencias,
            this.btnBndNavPesquisarTxt});
            this.bndNavPreferencias.Location = new System.Drawing.Point(326, 235);
            this.bndNavPreferencias.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bndNavPreferencias.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bndNavPreferencias.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bndNavPreferencias.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bndNavPreferencias.Name = "bndNavPreferencias";
            this.bndNavPreferencias.PositionItem = this.bindingNavigatorPositionItem;
            this.bndNavPreferencias.Size = new System.Drawing.Size(465, 27);
            this.bndNavPreferencias.TabIndex = 10;
            this.bndNavPreferencias.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // btnBdnNavConfirmar
            // 
            this.btnBdnNavConfirmar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBdnNavConfirmar.Image = ((System.Drawing.Image)(resources.GetObject("btnBdnNavConfirmar.Image")));
            this.btnBdnNavConfirmar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBdnNavConfirmar.Name = "btnBdnNavConfirmar";
            this.btnBdnNavConfirmar.Size = new System.Drawing.Size(29, 24);
            this.btnBdnNavConfirmar.Text = "toolStripButton1";
            this.btnBdnNavConfirmar.Click += new System.EventHandler(this.btnBdnNavConfirmar_Click);
            // 
            // bndNavTxtPreferencias
            // 
            this.bndNavTxtPreferencias.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bndNavTxtPreferencias.Name = "bndNavTxtPreferencias";
            this.bndNavTxtPreferencias.Size = new System.Drawing.Size(100, 27);
            // 
            // btnBndNavPesquisarTxt
            // 
            this.btnBndNavPesquisarTxt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBndNavPesquisarTxt.Image = ((System.Drawing.Image)(resources.GetObject("btnBndNavPesquisarTxt.Image")));
            this.btnBndNavPesquisarTxt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBndNavPesquisarTxt.Name = "btnBndNavPesquisarTxt";
            this.btnBndNavPesquisarTxt.Size = new System.Drawing.Size(29, 24);
            this.btnBndNavPesquisarTxt.Text = "toolStripButton2";
            this.btnBndNavPesquisarTxt.Click += new System.EventHandler(this.btnBndNavPesquisarTxt_Click);
            // 
            // dtgvwPrferencias
            // 
            this.dtgvwPrferencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvwPrferencias.Location = new System.Drawing.Point(326, 265);
            this.dtgvwPrferencias.Name = "dtgvwPrferencias";
            this.dtgvwPrferencias.RowHeadersWidth = 51;
            this.dtgvwPrferencias.RowTemplate.Height = 24;
            this.dtgvwPrferencias.Size = new System.Drawing.Size(563, 205);
            this.dtgvwPrferencias.TabIndex = 11;
            this.dtgvwPrferencias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvwPrferencias_CellClick);
            // 
            // lstbxPreferencias
            // 
            this.lstbxPreferencias.FormattingEnabled = true;
            this.lstbxPreferencias.ItemHeight = 16;
            this.lstbxPreferencias.Location = new System.Drawing.Point(326, 14);
            this.lstbxPreferencias.Name = "lstbxPreferencias";
            this.lstbxPreferencias.Size = new System.Drawing.Size(563, 196);
            this.lstbxPreferencias.TabIndex = 12;
            // 
            // frmExercicioAlterarDAO_03_10072024
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 482);
            this.Controls.Add(this.lstbxPreferencias);
            this.Controls.Add(this.dtgvwPrferencias);
            this.Controls.Add(this.bndNavPreferencias);
            this.Controls.Add(this.LimpGrid);
            this.Controls.Add(this.btnAlterarBd);
            this.Controls.Add(this.btnExcluirBd);
            this.Controls.Add(this.btnInserirBd);
            this.Controls.Add(this.btnConsultBd);
            this.Controls.Add(this.btnLimpTxt);
            this.Controls.Add(this.btnImpBdDesconect);
            this.Controls.Add(this.btnImpBdConect);
            this.Controls.Add(this.btnImpTxtWhile);
            this.Controls.Add(this.btnDesvCond);
            this.Name = "frmExercicioAlterarDAO_03_10072024";
            this.Text = "Janlea Grafica";
            this.Load += new System.EventHandler(this.frmExercicioAlterarDAO_03_10072024_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bndSrcPreferencias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndNavPreferencias)).EndInit();
            this.bndNavPreferencias.ResumeLayout(false);
            this.bndNavPreferencias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvwPrferencias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDesvCond;
        private System.Windows.Forms.Button btnImpTxtWhile;
        private System.Windows.Forms.Button btnImpBdConect;
        private System.Windows.Forms.Button btnImpBdDesconect;
        private System.Windows.Forms.Button btnLimpTxt;
        private System.Windows.Forms.Button btnConsultBd;
        private System.Windows.Forms.Button btnInserirBd;
        private System.Windows.Forms.Button btnExcluirBd;
        private System.Windows.Forms.Button btnAlterarBd;
        private System.Windows.Forms.Button LimpGrid;
        private System.Windows.Forms.BindingSource bndSrcPreferencias;
        private System.Windows.Forms.BindingNavigator bndNavPreferencias;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton btnBdnNavConfirmar;
        private System.Windows.Forms.ToolStripTextBox bndNavTxtPreferencias;
        private System.Windows.Forms.ToolStripButton btnBndNavPesquisarTxt;
        private System.Windows.Forms.DataGridView dtgvwPrferencias;
        private System.Windows.Forms.ListBox lstbxPreferencias;
    }
}

