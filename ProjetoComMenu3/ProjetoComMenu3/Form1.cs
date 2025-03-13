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
    public partial class Form1 : Form
    {

        private FilaTADView filaTADView;

        public Form1()
        {
            InitializeComponent();
            filaTADView=new FilaTADView();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void filaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (filaTADView == null)
            {
                filaTADView=new FilaTADView();
            }
            filaTADView.ShowDialog();   
        }
    }
}
