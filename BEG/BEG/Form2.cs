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
    public partial class frmexercicio1 : Form
    {
        public frmexercicio1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmprincipal fm = new frmprincipal();
            fm.Show();
          


        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtcod.Clear();
            txtlitros.Clear();
            txtdesc.Clear();
            txtcod.Focus();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double qtdl, desc;
            char cod;

            qtdl = Convert.ToDouble(txtlitros.Text);
            cod = Convert.ToChar(txtcod.Text);

            if (cod =='A')
            {
                if (qtdl <= 20)
                {
                    desc = qtdl * (4.30 - (4.30 * 3 / 100));
                    txtdesc.Text = desc.ToString();
                }
                 if(qtdl > 20)
                {
                    desc = qtdl * (4.30 - (4.30 * 5/ 100));
                    txtdesc.Text = desc.ToString();
                }
                 
            }
            else if (cod == 'G')
            {
                if (qtdl <= 20)
                {
                    desc = qtdl * (5.50 - (5.50*4/100));
                    txtdesc.Text = desc.ToString();
                }
                if (qtdl > 20)
                {
                    desc = qtdl * (5.50 - (5.50 * 6 / 100));
                    txtdesc.Text = desc.ToString();
                }
            }
            
            }
        }
    }

