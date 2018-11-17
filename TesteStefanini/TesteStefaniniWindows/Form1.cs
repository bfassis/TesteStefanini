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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string arquivo = string.Empty;
            TesteStefaniniBI.PrepararArquivoTxt bi = new TesteStefaniniBI.PrepararArquivoTxt();

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Selecionar Arquivo";
                openFileDialog.InitialDirectory = @"c:\Program Files";
                openFileDialog.Filter = "Txt(*.txt)|";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                openFileDialog.Multiselect = false;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    arquivo = openFileDialog.FileName;
                    var ret = bi.CarregarArquivoCliente(arquivo);

                    if (ret)
                        MessageBox.Show("Arquivo importado com sucesso","Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Ocorreu um Erro ao importar o arquivo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
