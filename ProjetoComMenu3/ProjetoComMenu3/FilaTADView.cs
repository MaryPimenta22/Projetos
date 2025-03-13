using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoComMenu3
{
    public partial class FilaTADView : Form
    {
        public FilaTADView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtConteudo.Text = "PUC Contagem!!!!";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtConteudo.Text = "";
        }
    }
}
