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
    public partial class FrmCategorias : Form
    {
        public FrmCategorias()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void FrmCategorias_Load(object sender, EventArgs e)
        {

        }

        private void FrmCategorias_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeuForm.FormCategoria = null ;
        }
    }
}
