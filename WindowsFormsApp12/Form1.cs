using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string klucz = "";
            int dlkl = int.Parse(txtdlkl.Text);
            int lbzn = 0;

            Random lblos = new Random();
            while (lbzn < dlkl)
            {
                int cyfra = lblos.Next(0, 10);
                klucz += cyfra.ToString();
                lbzn++;
                if(lbzn % 5 == 0 && lbzn < dlkl)
                {
                    klucz += "-";
                }
                txtklucz.Text = klucz;
            }
        }
    }
}
