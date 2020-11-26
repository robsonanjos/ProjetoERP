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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmPesquisaClientes cliente = new frmPesquisaClientes();
            cliente.Show();

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmSalvarCadastroCliente form1 = new frmSalvarCadastroCliente();
            form1.Show();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPesquisaClientes frmPesquisaClientes = new frmPesquisaClientes();
            frmPesquisaClientes.ShowDialog();
        }

        private void cadastroToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmSalvarCadastroCliente frmSalvarCadastroCliente = new frmSalvarCadastroCliente();
            frmSalvarCadastroCliente.ShowDialog();
        }

        private void generalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroClientes frmCadastroClientes = new frmCadastroClientes();
            frmCadastroClientes.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmCustos frmCustos = new frmCustos();
            frmCustos.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            frmOrçamento frmOrçamento = new frmOrçamento();
            frmOrçamento.ShowDialog();
        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
