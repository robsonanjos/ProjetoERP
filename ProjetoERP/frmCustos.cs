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
    public partial class frmCustos : Form
    {
        public frmCustos()
        {
            InitializeComponent();
        }

        private void custosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.custosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.eRPOrcamentoDataSet);

        }

        private void frmCustos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'eRPOrcamentoDataSet.Custos'. Você pode movê-la ou removê-la conforme necessário.
            this.custosTableAdapter.Fill(this.eRPOrcamentoDataSet.Custos);

        }

        private void btnPesquisaTipo_Click(object sender, EventArgs e)
        {
            this.custosTableAdapter.Fill(this.eRPOrcamentoDataSet.Custos);
            this.custosTableAdapter.FillByTipo(this.eRPOrcamentoDataSet.Custos, comboBox1.Text);
        }

        private void btnPesquisaNome_Click(object sender, EventArgs e)
        {
            this.custosTableAdapter.Fill(this.eRPOrcamentoDataSet.Custos);
            this.custosTableAdapter.FillByNome(this.eRPOrcamentoDataSet.Custos, textBox1.Text);
        }
    }
}
