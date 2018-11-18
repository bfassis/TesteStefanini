using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteStefaniniWindows
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.dataGridView1.ReadOnly = true;
            TesteStefaniniBI.ClienteBI clienteBI = new TesteStefaniniBI.ClienteBI();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = clienteBI.SelecionarTodos();

            dataGridView1.DataSource = bindingSource;
            this.dataGridView1.Columns["VinculoClienteProduto"].Visible = false;
            dataGridView1.Refresh();
        }
    }
}
