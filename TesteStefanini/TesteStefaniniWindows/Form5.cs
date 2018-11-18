using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TesteStefaniniBI;

namespace TesteStefaniniWindows
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            this.dataGridView1.ReadOnly = true;
            TesteStefaniniBI.ProdutoBI produtoBI = new TesteStefaniniBI.ProdutoBI();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = produtoBI.SelecionarTodos();

            dataGridView1.DataSource = bindingSource;
            this.dataGridView1.Columns["VinculoClienteProduto"].Visible = false;
            dataGridView1.Refresh();
        }
    }
}
