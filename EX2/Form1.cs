using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Sair", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lsbLista1.Items.Clear();
            lsbLista2.Items.Clear();
            lsbLista3.Items.Clear();
            lsbLista4.Items.Clear();
            lsbLista5.Items.Clear();
            btnLista1.Focus();
        }

        private void btnLista1_Click(object sender, EventArgs e)
        {
            lsbLista1.Items.Clear();
            for(int i = 0; i <= 1000; i++)
            {
                lsbLista1.Items.Add(i);
            }
        }

        private void btnLista2_Click(object sender, EventArgs e)
        {
            lsbLista2.Items.Clear();

            for (int i = 1001; i <= 2000; i += 2)
            {
                lsbLista2.Items.Add(i);

            }
        }

        private void btnLista3_Click(object sender, EventArgs e)
        {
            lsbLista3.Items.Clear();

            for (int i = 2000; i <= 3000; i += 2)
            {
                lsbLista3.Items.Add(i);
            }
        }

        private void btnLista4_Click(object sender, EventArgs e)
        {


            lsbLista4.Items.Clear();
            for (int i = 3001; i <= 4000; i ++)
                {
                 if (i % 3 == 0)
                    {
                        lsbLista4.Items.Add(i);
                    }

                }                   
        }

        private void btnLista5_Click(object sender, EventArgs e)
        {
            lsbLista5.Items.Clear();
            for(int i = 4001; i <=50000;  i *= 2)
            {
                lsbLista5.Items.Add(i);
            }
        }
    }
}
