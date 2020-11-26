using System;
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
    public partial class frmPesquisaClientes : Form
    {
        public frmPesquisaClientes()
        {
            InitializeComponent();
        }

        private void clientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.eRPOrcamentoDataSet);

        }

        private void frmPesquisaClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'eRPOrcamentoDataSet.Clientes'. Você pode movê-la ou removê-la conforme necessário.
            this.clientesTableAdapter.Fill(this.eRPOrcamentoDataSet.Clientes);
            idClienteLabel1.Text = "";
            nomeClienteLabel1.Text = "";
            emailClienteLabel1.Text = "";
            telefoneClienteLabel1.Text = "";
            celularClienteLabel1.Text = "";

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            this.clientesTableAdapter.Fill(this.eRPOrcamentoDataSet.Clientes);

            if (comboBox1.Text == "Id")
            {
                int num = Convert.ToInt32(textBox1.Text);
                this.clientesTableAdapter.FillByIdCliente(this.eRPOrcamentoDataSet.Clientes, num);
            }
            else
                this.clientesTableAdapter.FillByNomeCliente(this.eRPOrcamentoDataSet.Clientes, textBox1.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
