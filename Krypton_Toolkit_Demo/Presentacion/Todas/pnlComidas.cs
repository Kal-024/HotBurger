using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Krypton_Toolkit_Demo.View
{
    public partial class pnlComidas  : KryptonForm
    {
        public pnlComidas()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            frmBurgerList burgerList = new frmBurgerList();
            burgerList.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            frmHotDogList hotList = new frmHotDogList();
            hotList.ShowDialog();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            frmSandwichesList sandList = new frmSandwichesList();
            sandList.ShowDialog();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            frmHotDogList hotList = new frmHotDogList();
            hotList.ShowDialog();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            frmSandwichesList sandList = new frmSandwichesList();
            sandList.ShowDialog();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            frmHotDogList hotList = new frmHotDogList();
            hotList.ShowDialog();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            frmBurgerList burgerList = new frmBurgerList();
            burgerList.ShowDialog();
        }
    }
}
