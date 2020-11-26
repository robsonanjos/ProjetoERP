namespace ProjetoERP
{
    partial class frmPesquisaClientes
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
            System.Windows.Forms.Label idClienteLabel;
            System.Windows.Forms.Label nomeClienteLabel;
            System.Windows.Forms.Label emailClienteLabel;
            System.Windows.Forms.Label telefoneClienteLabel;
            System.Windows.Forms.Label celularClienteLabel;
            this.idClienteLabel1 = new System.Windows.Forms.Label();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eRPOrcamentoDataSet = new ProjetoERP.ERPOrcamentoDataSet();
            this.nomeClienteLabel1 = new System.Windows.Forms.Label();
            this.emailClienteLabel1 = new System.Windows.Forms.Label();
            this.telefoneClienteLabel1 = new System.Windows.Forms.Label();
            this.celularClienteLabel1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.clientesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clientesTableAdapter = new ProjetoERP.ERPOrcamentoDataSetTableAdapters.ClientesTableAdapter();
            this.tableAdapterManager = new ProjetoERP.ERPOrcamentoDataSetTableAdapters.TableAdapterManager();
            idClienteLabel = new System.Windows.Forms.Label();
            nomeClienteLabel = new System.Windows.Forms.Label();
            emailClienteLabel = new System.Windows.Forms.Label();
            telefoneClienteLabel = new System.Windows.Forms.Label();
            celularClienteLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eRPOrcamentoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // idClienteLabel
            // 
            idClienteLabel.AutoSize = true;
            idClienteLabel.Location = new System.Drawing.Point(22, 102);
            idClienteLabel.Name = "idClienteLabel";
            idClienteLabel.Size = new System.Drawing.Size(70, 17);
            idClienteLabel.TabIndex = 1;
            idClienteLabel.Text = "Id Cliente:";
            // 
            // nomeClienteLabel
            // 
            nomeClienteLabel.AutoSize = true;
            nomeClienteLabel.Location = new System.Drawing.Point(22, 125);
            nomeClienteLabel.Name = "nomeClienteLabel";
            nomeClienteLabel.Size = new System.Drawing.Size(96, 17);
            nomeClienteLabel.TabIndex = 3;
            nomeClienteLabel.Text = "Nome Cliente:";
            // 
            // emailClienteLabel
            // 
            emailClienteLabel.AutoSize = true;
            emailClienteLabel.Location = new System.Drawing.Point(22, 148);
            emailClienteLabel.Name = "emailClienteLabel";
            emailClienteLabel.Size = new System.Drawing.Size(93, 17);
            emailClienteLabel.TabIndex = 5;
            emailClienteLabel.Text = "Email Cliente:";
            // 
            // telefoneClienteLabel
            // 
            telefoneClienteLabel.AutoSize = true;
            telefoneClienteLabel.Location = new System.Drawing.Point(22, 171);
            telefoneClienteLabel.Name = "telefoneClienteLabel";
            telefoneClienteLabel.Size = new System.Drawing.Size(115, 17);
            telefoneClienteLabel.TabIndex = 7;
            telefoneClienteLabel.Text = "Telefone Cliente:";
            // 
            // celularClienteLabel
            // 
            celularClienteLabel.AutoSize = true;
            celularClienteLabel.Location = new System.Drawing.Point(22, 194);
            celularClienteLabel.Name = "celularClienteLabel";
            celularClienteLabel.Size = new System.Drawing.Size(103, 17);
            celularClienteLabel.TabIndex = 9;
            celularClienteLabel.Text = "Celular Cliente:";
            // 
            // idClienteLabel1
            // 
            this.idClienteLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "IdCliente", true));
            this.idClienteLabel1.Location = new System.Drawing.Point(143, 102);
            this.idClienteLabel1.Name = "idClienteLabel1";
            this.idClienteLabel1.Size = new System.Drawing.Size(100, 23);
            this.idClienteLabel1.TabIndex = 2;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.eRPOrcamentoDataSet;
            // 
            // eRPOrcamentoDataSet
            // 
            this.eRPOrcamentoDataSet.DataSetName = "ERPOrcamentoDataSet";
            this.eRPOrcamentoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nomeClienteLabel1
            // 
            this.nomeClienteLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "NomeCliente", true));
            this.nomeClienteLabel1.Location = new System.Drawing.Point(143, 125);
            this.nomeClienteLabel1.Name = "nomeClienteLabel1";
            this.nomeClienteLabel1.Size = new System.Drawing.Size(100, 23);
            this.nomeClienteLabel1.TabIndex = 4;
            // 
            // emailClienteLabel1
            // 
            this.emailClienteLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "EmailCliente", true));
            this.emailClienteLabel1.Location = new System.Drawing.Point(143, 148);
            this.emailClienteLabel1.Name = "emailClienteLabel1";
            this.emailClienteLabel1.Size = new System.Drawing.Size(100, 23);
            this.emailClienteLabel1.TabIndex = 6;
            // 
            // telefoneClienteLabel1
            // 
            this.telefoneClienteLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "TelefoneCliente", true));
            this.telefoneClienteLabel1.Location = new System.Drawing.Point(143, 171);
            this.telefoneClienteLabel1.Name = "telefoneClienteLabel1";
            this.telefoneClienteLabel1.Size = new System.Drawing.Size(100, 23);
            this.telefoneClienteLabel1.TabIndex = 8;
            // 
            // celularClienteLabel1
            // 
            this.celularClienteLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "CelularCliente", true));
            this.celularClienteLabel1.Location = new System.Drawing.Point(143, 194);
            this.celularClienteLabel1.Name = "celularClienteLabel1";
            this.celularClienteLabel1.Size = new System.Drawing.Size(100, 23);
            this.celularClienteLabel1.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(185, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(410, 22);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(601, 36);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(96, 33);
            this.btnPesquisar.TabIndex = 12;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // clientesDataGridView
            // 
            this.clientesDataGridView.AutoGenerateColumns = false;
            this.clientesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.clientesDataGridView.DataSource = this.clientesBindingSource;
            this.clientesDataGridView.Location = new System.Drawing.Point(25, 222);
            this.clientesDataGridView.Name = "clientesDataGridView";
            this.clientesDataGridView.RowHeadersWidth = 51;
            this.clientesDataGridView.RowTemplate.Height = 24;
            this.clientesDataGridView.Size = new System.Drawing.Size(663, 220);
            this.clientesDataGridView.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdCliente";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdCliente";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NomeCliente";
            this.dataGridViewTextBoxColumn2.HeaderText = "NomeCliente";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "EmailCliente";
            this.dataGridViewTextBoxColumn3.HeaderText = "EmailCliente";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TelefoneCliente";
            this.dataGridViewTextBoxColumn4.HeaderText = "TelefoneCliente";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CelularCliente";
            this.dataGridViewTextBoxColumn5.HeaderText = "CelularCliente";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(164, 76);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo da pesquisa:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Nome",
            "Id"});
            this.comboBox1.Location = new System.Drawing.Point(13, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Digite o texto a ser pesquisado:";
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientesTableAdapter = this.clientesTableAdapter;
            this.tableAdapterManager.CustosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjetoERP.ERPOrcamentoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmPesquisaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 535);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.clientesDataGridView);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(idClienteLabel);
            this.Controls.Add(this.idClienteLabel1);
            this.Controls.Add(nomeClienteLabel);
            this.Controls.Add(this.nomeClienteLabel1);
            this.Controls.Add(emailClienteLabel);
            this.Controls.Add(this.emailClienteLabel1);
            this.Controls.Add(telefoneClienteLabel);
            this.Controls.Add(this.telefoneClienteLabel1);
            this.Controls.Add(celularClienteLabel);
            this.Controls.Add(this.celularClienteLabel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPesquisaClientes";
            this.Text = "Pesquisa Clientes";
            this.Load += new System.EventHandler(this.frmPesquisaClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eRPOrcamentoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ERPOrcamentoDataSet eRPOrcamentoDataSet;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private ERPOrcamentoDataSetTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private ERPOrcamentoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label idClienteLabel1;
        private System.Windows.Forms.Label nomeClienteLabel1;
        private System.Windows.Forms.Label emailClienteLabel1;
        private System.Windows.Forms.Label telefoneClienteLabel1;
        private System.Windows.Forms.Label celularClienteLabel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridView clientesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}