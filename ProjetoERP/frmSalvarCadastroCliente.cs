﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoERP
{
    public partial class frmSalvarCadastroCliente : Form
    {
        public frmSalvarCadastroCliente()
        {
            InitializeComponent();
        }

        private void clientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.eRPOrcamentoDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'eRPOrcamentoDataSet.Clientes'. Você pode movê-la ou removê-la conforme necessário.
            this.clientesTableAdapter.Fill(this.eRPOrcamentoDataSet.Clientes);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.clientesTableAdapter.InsertQuery(nomeClienteTextBox.Text, emailClienteTextBox.Text, telefoneClienteTextBox.Text, celularClienteTextBox.Text);
            this.clientesTableAdapter.Fill(this.eRPOrcamentoDataSet.Clientes);
        }
    }
}
