namespace ProjetoERP
{
    partial class frmCustos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label id_custoLabel;
            System.Windows.Forms.Label nome_custoLabel;
            System.Windows.Forms.Label tipo_custoLabel;
            System.Windows.Forms.Label valor_custoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustos));
            this.eRPOrcamentoDataSet = new ProjetoERP.ERPOrcamentoDataSet();
            this.custosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.custosTableAdapter = new ProjetoERP.ERPOrcamentoDataSetTableAdapters.CustosTableAdapter();
            this.tableAdapterManager = new ProjetoERP.ERPOrcamentoDataSetTableAdapters.TableAdapterManager();
            this.custosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.custosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.custosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_custoLabel1 = new System.Windows.Forms.Label();
            this.nome_custoTextBox = new System.Windows.Forms.TextBox();
            this.tipo_custoComboBox = new System.Windows.Forms.ComboBox();
            this.valor_custoMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPesquisaNome = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnPesquisaTipo = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.eRPOrcamentoDataSet1 = new ProjetoERP.ERPOrcamentoDataSet();
            this.eRPOrcamentoDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            id_custoLabel = new System.Windows.Forms.Label();
            nome_custoLabel = new System.Windows.Forms.Label();
            tipo_custoLabel = new System.Windows.Forms.Label();
            valor_custoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eRPOrcamentoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.custosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.custosBindingNavigator)).BeginInit();
            this.custosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.custosDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eRPOrcamentoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eRPOrcamentoDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // id_custoLabel
            // 
            id_custoLabel.AutoSize = true;
            id_custoLabel.Location = new System.Drawing.Point(16, 24);
            id_custoLabel.Name = "id_custoLabel";
            id_custoLabel.Size = new System.Drawing.Size(61, 17);
            id_custoLabel.TabIndex = 2;
            id_custoLabel.Text = "id custo:";
            // 
            // nome_custoLabel
            // 
            nome_custoLabel.AutoSize = true;
            nome_custoLabel.Location = new System.Drawing.Point(16, 53);
            nome_custoLabel.Name = "nome_custoLabel";
            nome_custoLabel.Size = new System.Drawing.Size(85, 17);
            nome_custoLabel.TabIndex = 4;
            nome_custoLabel.Text = "nome custo:";
            // 
            // tipo_custoLabel
            // 
            tipo_custoLabel.AutoSize = true;
            tipo_custoLabel.Location = new System.Drawing.Point(16, 81);
            tipo_custoLabel.Name = "tipo_custoLabel";
            tipo_custoLabel.Size = new System.Drawing.Size(73, 17);
            tipo_custoLabel.TabIndex = 6;
            tipo_custoLabel.Text = "tipo custo:";
            // 
            // valor_custoLabel
            // 
            valor_custoLabel.AutoSize = true;
            valor_custoLabel.Location = new System.Drawing.Point(16, 112);
            valor_custoLabel.Name = "valor_custoLabel";
            valor_custoLabel.Size = new System.Drawing.Size(81, 17);
            valor_custoLabel.TabIndex = 8;
            valor_custoLabel.Text = "valor custo:";
            // 
            // eRPOrcamentoDataSet
            // 
            this.eRPOrcamentoDataSet.DataSetName = "ERPOrcamentoDataSet";
            this.eRPOrcamentoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // custosBindingSource
            // 
            this.custosBindingSource.DataMember = "Custos";
            this.custosBindingSource.DataSource = this.eRPOrcamentoDataSet;
            // 
            // custosTableAdapter
            // 
            this.custosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.CustosTableAdapter = this.custosTableAdapter;
            this.tableAdapterManager.UpdateOrder = ProjetoERP.ERPOrcamentoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // custosBindingNavigator
            // 
            this.custosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.custosBindingNavigator.BindingSource = this.custosBindingSource;
            this.custosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.custosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.custosBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.custosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.toolStripSeparator1,
            this.bindingNavigatorDeleteItem,
            this.toolStripSeparator2,
            this.custosBindingNavigatorSaveItem});
            this.custosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.custosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.custosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.custosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.custosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.custosBindingNavigator.Name = "custosBindingNavigator";
            this.custosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.custosBindingNavigator.Size = new System.Drawing.Size(748, 31);
            this.custosBindingNavigator.TabIndex = 0;
            this.custosBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(150, 28);
            this.bindingNavigatorAddNewItem.Text = "Adicionar / Editar";
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
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(76, 24);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // custosBindingNavigatorSaveItem
            // 
            this.custosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("custosBindingNavigatorSaveItem.Image")));
            this.custosBindingNavigatorSaveItem.Name = "custosBindingNavigatorSaveItem";
            this.custosBindingNavigatorSaveItem.Size = new System.Drawing.Size(147, 24);
            this.custosBindingNavigatorSaveItem.Text = "Salvar Alterações";
            this.custosBindingNavigatorSaveItem.Click += new System.EventHandler(this.custosBindingNavigatorSaveItem_Click);
            // 
            // custosDataGridView
            // 
            this.custosDataGridView.AutoGenerateColumns = false;
            this.custosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.custosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.custosDataGridView.DataSource = this.custosBindingSource;
            this.custosDataGridView.Location = new System.Drawing.Point(12, 226);
            this.custosDataGridView.MultiSelect = false;
            this.custosDataGridView.Name = "custosDataGridView";
            this.custosDataGridView.ReadOnly = true;
            this.custosDataGridView.RowHeadersWidth = 51;
            this.custosDataGridView.RowTemplate.Height = 24;
            this.custosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.custosDataGridView.Size = new System.Drawing.Size(716, 220);
            this.custosDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_custo";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nome_custo";
            this.dataGridViewTextBoxColumn2.HeaderText = "nome_custo";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "tipo_custo";
            this.dataGridViewTextBoxColumn3.HeaderText = "tipo_custo";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "valor_custo";
            this.dataGridViewTextBoxColumn4.HeaderText = "valor_custo";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // id_custoLabel1
            // 
            this.id_custoLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.custosBindingSource, "id_custo", true));
            this.id_custoLabel1.Location = new System.Drawing.Point(107, 24);
            this.id_custoLabel1.Name = "id_custoLabel1";
            this.id_custoLabel1.Size = new System.Drawing.Size(121, 23);
            this.id_custoLabel1.TabIndex = 3;
            this.id_custoLabel1.Text = "label1";
            // 
            // nome_custoTextBox
            // 
            this.nome_custoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.custosBindingSource, "nome_custo", true));
            this.nome_custoTextBox.Location = new System.Drawing.Point(107, 50);
            this.nome_custoTextBox.Name = "nome_custoTextBox";
            this.nome_custoTextBox.Size = new System.Drawing.Size(263, 22);
            this.nome_custoTextBox.TabIndex = 5;
            // 
            // tipo_custoComboBox
            // 
            this.tipo_custoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.custosBindingSource, "tipo_custo", true));
            this.tipo_custoComboBox.FormattingEnabled = true;
            this.tipo_custoComboBox.Location = new System.Drawing.Point(107, 78);
            this.tipo_custoComboBox.Name = "tipo_custoComboBox";
            this.tipo_custoComboBox.Size = new System.Drawing.Size(176, 24);
            this.tipo_custoComboBox.Sorted = true;
            this.tipo_custoComboBox.TabIndex = 7;
            // 
            // valor_custoMaskedTextBox
            // 
            this.valor_custoMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.custosBindingSource, "valor_custo", true));
            this.valor_custoMaskedTextBox.Location = new System.Drawing.Point(107, 109);
            this.valor_custoMaskedTextBox.Name = "valor_custoMaskedTextBox";
            this.valor_custoMaskedTextBox.Size = new System.Drawing.Size(121, 22);
            this.valor_custoMaskedTextBox.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPesquisaNome);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(22, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(318, 60);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pesquisa por nome";
            // 
            // btnPesquisaNome
            // 
            this.btnPesquisaNome.Location = new System.Drawing.Point(218, 17);
            this.btnPesquisaNome.Name = "btnPesquisaNome";
            this.btnPesquisaNome.Size = new System.Drawing.Size(94, 33);
            this.btnPesquisaNome.TabIndex = 1;
            this.btnPesquisaNome.Text = "Pesquisar";
            this.btnPesquisaNome.UseVisualStyleBackColor = true;
            this.btnPesquisaNome.Click += new System.EventHandler(this.btnPesquisaNome_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(205, 22);
            this.textBox1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.btnPesquisaTipo);
            this.groupBox1.Location = new System.Drawing.Point(22, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 60);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa por tipo";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.custosBindingSource, "tipo_custo", true));
            this.comboBox1.DataSource = this.custosBindingSource;
            this.comboBox1.DisplayMember = "tipo_custo";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(7, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(205, 24);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.ValueMember = "tipo_custo";
            // 
            // btnPesquisaTipo
            // 
            this.btnPesquisaTipo.Location = new System.Drawing.Point(218, 17);
            this.btnPesquisaTipo.Name = "btnPesquisaTipo";
            this.btnPesquisaTipo.Size = new System.Drawing.Size(94, 33);
            this.btnPesquisaTipo.TabIndex = 1;
            this.btnPesquisaTipo.Text = "Pesquisar";
            this.btnPesquisaTipo.UseVisualStyleBackColor = true;
            this.btnPesquisaTipo.Click += new System.EventHandler(this.btnPesquisaTipo_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(id_custoLabel);
            this.groupBox3.Controls.Add(this.id_custoLabel1);
            this.groupBox3.Controls.Add(nome_custoLabel);
            this.groupBox3.Controls.Add(this.nome_custoTextBox);
            this.groupBox3.Controls.Add(tipo_custoLabel);
            this.groupBox3.Controls.Add(this.tipo_custoComboBox);
            this.groupBox3.Controls.Add(valor_custoLabel);
            this.groupBox3.Controls.Add(this.valor_custoMaskedTextBox);
            this.groupBox3.Location = new System.Drawing.Point(362, 40);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(381, 145);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Edição de dados";
            // 
            // eRPOrcamentoDataSet1
            // 
            this.eRPOrcamentoDataSet1.DataSetName = "ERPOrcamentoDataSet";
            this.eRPOrcamentoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eRPOrcamentoDataSet1BindingSource
            // 
            this.eRPOrcamentoDataSet1BindingSource.DataSource = this.eRPOrcamentoDataSet1;
            this.eRPOrcamentoDataSet1BindingSource.Position = 0;
            // 
            // frmCustos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 457);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.custosDataGridView);
            this.Controls.Add(this.custosBindingNavigator);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCustos";
            this.Text = "frmCustos";
            this.Load += new System.EventHandler(this.frmCustos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eRPOrcamentoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.custosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.custosBindingNavigator)).EndInit();
            this.custosBindingNavigator.ResumeLayout(false);
            this.custosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.custosDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eRPOrcamentoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eRPOrcamentoDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ERPOrcamentoDataSet eRPOrcamentoDataSet;
        private System.Windows.Forms.BindingSource custosBindingSource;
        private ERPOrcamentoDataSetTableAdapters.CustosTableAdapter custosTableAdapter;
        private ERPOrcamentoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator custosBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton custosBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView custosDataGridView;
        private System.Windows.Forms.Label id_custoLabel1;
        private System.Windows.Forms.TextBox nome_custoTextBox;
        private System.Windows.Forms.ComboBox tipo_custoComboBox;
        private System.Windows.Forms.MaskedTextBox valor_custoMaskedTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPesquisaNome;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPesquisaTipo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.ComboBox comboBox1;
        private ERPOrcamentoDataSet eRPOrcamentoDataSet1;
        private System.Windows.Forms.BindingSource eRPOrcamentoDataSet1BindingSource;
    }
}