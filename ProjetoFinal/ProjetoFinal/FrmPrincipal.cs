using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MeuForm.FormCategoria == null)
                MeuForm.FormCategoria = new FrmCategorias();


            MeuForm.FormCategoria.Show();
            MeuForm.FormCategoria.Focus();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MeuForm.FormProduto == null)
                MeuForm.FormProduto = new FrmProduto();


            MeuForm.FormProduto.Show();
            MeuForm.FormProduto.Focus();
        }
    }
}
