using ComponentFactory.Krypton.Toolkit;
using Krypton_Toolkit_Demo.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Krypton_Toolkit_Demo.Presentacion.Caja
{
    public partial class FrmPedido : KryptonForm
    {
        int t,b,c,p = 0;
        int minust, minusb, minusc, minusp = 0;
        
        public FrmPedido()
        {
            InitializeComponent();
            Font fuentet = new Font(lblTradicional.Font.FontFamily, 7);
            lblTradicional.Font = fuentet;
            Font fuenteb = new Font(lblBuffalo.Font.FontFamily, 7);
            lblBuffalo.Font = fuenteb;
            Font fuentec = new Font(lblCoca.Font.FontFamily, 7);
            lblCoca.Font = fuentec;
            Font fuentep = new Font(lblPapas.Font.FontFamily, 7);
            lblPapas.Font = fuentep;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            t = t + 1;
            lblTradicional.Text = "";
            lblTradicional.Text = "Hamb. Trad.           "+ (t) +"             C$ 34.00       C$"+ ((t * 34)-34) +".00";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            minust = t - 1;
            lblTradicional.Text = "";
            lblTradicional.Text = "Hamb. Trad.           " + (minust) + "             C$ 34.00       C$" + ((t * 34) - 68) + ".00";
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            lblTradicional.Text = "";
            //
            minusb = b - 1;
            lblBuffalo.Text = "";
            lblTradicional.Text = "Hamb. Buffalo        " + (minusb) + "             C$ 44.00       C$" + ((b * 44) - 88) + ".00";
            //

            //
            pbAddPapas.Visible = false;
            pbLessPapas.Visible = false;
            pbDeletePapas.Visible = false;
            //
            lblCoca.Text = "";
            lblBuffalo.Text = "Coca-Cola Lata       " + (minusc) + "             C$ 20.00       C$" + ((c * 20) - 40) + ".00";
            //
            lblPapas.Text = "";
            lblCoca.Text = "Extra Papas              " + (minusp) + "         C$ 18.00        C$" + ((p * 18) - 36) + ".00";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FrmPago pago = new FrmPago();
            pago.ShowDialog();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {            
            minusb = b - 1;
            lblBuffalo.Text = "";
            lblBuffalo.Text = "Hamb. Buffalo        " + (minusb) + "             C$ 44.00       C$" + ((b * 44) - 88) + ".00";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            minusc = c - 1;
            lblCoca.Text = "";
            lblCoca.Text = "Coca-Cola Lata       " + (minusc) + "             C$ 20.00       C$" + ((c * 20) - 40) + ".00";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            minusp = p - 1;
            lblPapas.Text = "";
            lblPapas.Text = "Extra Papas              " + (minusp) + "         C$ 18.00        C$" + ((p * 18) - 36) + ".00";
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            lblCoca.Text = "";
            c = c+1;
            lblCoca.Text = "Coca-Cola Lata      " + (c) + "             C$ 20.00       C$" + ((c * 20)-20) + ".00";
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            p = p + 1;
            lblPapas.Text = "";
            lblPapas.Text = "Extra Papas            " + (p) + "           C$ 18.00        C$" + ((p * 18)-18) + ".00";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            b = b + 1;
            lblBuffalo.Text = "";
            lblBuffalo.Text = "Hamb. Buffalo        "+ (b) + "             C$ 44.00       C$" + ((b * 44)-44) + ".00";
        }
    }
}
