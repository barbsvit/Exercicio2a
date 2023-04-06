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
    public partial class frmfor : Form
    {
        public frmfor()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txttab.Clear();
            txtresult.Clear();
            txttab.Focus();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmprincipal fm = new frmprincipal();
            fm.Show();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int i, num, result;

            num = Convert.ToInt32(txttab.Text);

            for (i = 0; i <= 10; i++)
            {
                result = num * i;
                txtresult.Text = String.Concat(txtresult.Text, "\r\n", result.ToString());
            }
        }

        private void btncalcular2_Click(object sender, EventArgs e)
        {
            int i, num, result;

            num = Convert.ToInt32(txttab.Text);
            i = Convert.ToInt32(txttab.Text);

            i = 1;

            while (i < 11)
            {
                result = num * i;
                txtresult.Text = String.Concat(txtresult.Text, "\r\n", result.ToString());
                i++;
            }

        }

        private void btncalcular3_Click(object sender, EventArgs e)
        {
            int num, result, i;

            num = Convert.ToInt32(txttab.Text);

            i = 1;

            do
            {
                result = num * i;

                txtresult.Text = String.Concat(txtresult.Text, "\r\n", result.ToString());
                i++;
            } while (i < 11);

        }
    }
}
