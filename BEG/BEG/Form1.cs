using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BEG
{
    public partial class frmprincipal : Form
    {
        public frmprincipal()
        {
            InitializeComponent();
        }

        private void entrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exercício1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmexercicio1 fm = new frmexercicio1();
            fm.Show();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exercício2aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmfor fm = new frmfor();
            fm.Show();
        }

        private void exercício2bToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
