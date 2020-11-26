namespace ProjetoERP
{
    partial class frmSalvarCadastroCliente
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
            System.Windows.Forms.Label nomeClienteLabel;
            System.Windows.Forms.Label emailClienteLabel;
            System.Windows.Forms.Label telefoneClienteLabel;
            System.Windows.Forms.Label celularClienteLabel;
            this.eRPOrcamentoDataSet = new ProjetoERP.ERPOrcamentoDataSet();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesTableAdapter = new ProjetoERP.ERPOrcamentoDataSetTableAdapters.ClientesTableAdapter();
            this.tableAdapterManager = new ProjetoERP.ERPOrcamentoDataSetTableAdapters.TableAdapterManager();
            this.nomeClienteTextBox = new System.Windows.Forms.TextBox();
            this.emailClienteTextBox = new System.Windows.Forms.TextBox();
            this.telefoneClienteTextBox = new System.Windows.Forms.TextBox();
            this.celularClienteTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.clientesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nomeClienteLabel = new System.Windows.Forms.Label();
            emailClienteLabel = new System.Windows.Forms.Label();
            telefoneClienteLabel = new System.Windows.Forms.Label();
            celularClienteLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eRPOrcamentoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeClienteLabel
            // 
            nomeClienteLabel.AutoSize = true;
            nomeClienteLabel.Location = new System.Drawing.Point(18, 15);
            nomeClienteLabel.Name = "nomeClienteLabel";
            nomeClienteLabel.Size = new System.Drawing.Size(96, 17);
            nomeClienteLabel.TabIndex = 3;
            nomeClienteLabel.Text = "Nome Cliente:";
            // 
            // emailClienteLabel
            // 
            emailClienteLabel.AutoSize = true;
            emailClienteLabel.Location = new System.Drawing.Point(18, 43);
            emailClienteLabel.Name = "emailClienteLabel";
            emailClienteLabel.Size = new System.Drawing.Size(93, 17);
            emailClienteLabel.TabIndex = 5;
            emailClienteLabel.Text = "Email Cliente:";
            // 
            // telefoneClienteLabel
            // 
            telefoneClienteLabel.AutoSize = true;
            telefoneClienteLabel.Location = new System.Drawing.Point(18, 71);
            telefoneClienteLabel.Name = "telefoneClienteLabel";
            telefoneClienteLabel.Size = new System.Drawing.Size(115, 17);
            telefoneClienteLabel.TabIndex = 7;
            telefoneClienteLabel.Text = "Telefone Cliente:";
            // 
            // celularClienteLabel
            // 
            celularClienteLabel.AutoSize = true;
            celularClienteLabel.Location = new System.Drawing.Point(18, 99);
            celularClienteLabel.Name = "celularClienteLabel";
            celularClienteLabel.Size = new System.Drawing.Size(103, 17);
            celularClienteLabel.TabIndex = 9;
            celularClienteLabel.Text = "Celular Cliente:";
            // 
            // eRPOrcamentoDataSet
            // 
            this.eRPOrcamentoDataSet.DataSetName = "ERPOrcamentoDataSet";
            this.eRPOrcamentoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.eRPOrcamentoDataSet;
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
            // nomeClienteTextBox
            // 
            this.nomeClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "NomeCliente", true));
            this.nomeClienteTextBox.Location = new System.Drawing.Point(139, 12);
            this.nomeClienteTextBox.Name = "nomeClienteTextBox";
            this.nomeClienteTextBox.Size = new System.Drawing.Size(223, 22);
            this.nomeClienteTextBox.TabIndex = 4;
            // 
            // emailClienteTextBox
            // 
            this.emailClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "EmailCliente", true));
            this.emailClienteTextBox.Location = new System.Drawing.Point(139, 40);
            this.emailClienteTextBox.Name = "emailClienteTextBox";
            this.emailClienteTextBox.Size = new System.Drawing.Size(223, 22);
            this.emailClienteTextBox.TabIndex = 6;
            // 
            // telefoneClienteTextBox
            // 
            this.telefoneClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "TelefoneCliente", true));
            this.telefoneClienteTextBox.Location = new System.Drawing.Point(139, 68);
            this.telefoneClienteTextBox.Name = "telefoneClienteTextBox";
            this.telefoneClienteTextBox.Size = new System.Drawing.Size(223, 22);
            this.telefoneClienteTextBox.TabIndex = 8;
            // 
            // celularClienteTextBox
            // 
            this.celularClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "CelularCliente", true));
            this.celularClienteTextBox.Location = new System.Drawing.Point(139, 96);
            this.celularClienteTextBox.Name = "celularClienteTextBox";
            this.celularClienteTextBox.Size = new System.Drawing.Size(223, 22);
            this.celularClienteTextBox.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 27);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.clientesDataGridView.Location = new System.Drawing.Point(27, 232);
            this.clientesDataGridView.Name = "clientesDataGridView";
            this.clientesDataGridView.RowHeadersWidth = 51;
            this.clientesDataGridView.RowTemplate.Height = 24;
            this.clientesDataGridView.Size = new System.Drawing.Size(672, 220);
            this.clientesDataGridView.TabIndex = 11;
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
            // frmSalvarCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 520);
            this.Controls.Add(this.clientesDataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(nomeClienteLabel);
            this.Controls.Add(this.nomeClienteTextBox);
            this.Controls.Add(emailClienteLabel);
            this.Controls.Add(this.emailClienteTextBox);
            this.Controls.Add(telefoneClienteLabel);
            this.Controls.Add(this.telefoneClienteTextBox);
            this.Controls.Add(celularClienteLabel);
            this.Controls.Add(this.celularClienteTextBox);
            this.Name = "frmSalvarCadastroCliente";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eRPOrcamentoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ERPOrcamentoDataSet eRPOrcamentoDataSet;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private ERPOrcamentoDataSetTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private ERPOrcamentoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox nomeClienteTextBox;
        private System.Windows.Forms.TextBox emailClienteTextBox;
        private System.Windows.Forms.TextBox telefoneClienteTextBox;
        private System.Windows.Forms.TextBox celularClienteTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView clientesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}