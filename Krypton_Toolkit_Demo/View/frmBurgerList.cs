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
    public partial class frmBurgerList : KryptonForm
    {
        public frmBurgerList()
        {
            InitializeComponent();
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            frmHambuerguesaInfo hambSencilla = new frmHambuerguesaInfo();
            hambSencilla.ShowDialog();
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            frmHambuerguesaInfo hambSencilla = new frmHambuerguesaInfo();
            hambSencilla.ShowDialog();
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            frmHambuerguesaInfo hambSencilla = new frmHambuerguesaInfo();
            hambSencilla.ShowDialog();
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            frmHambuerguesaInfo hambSencilla = new frmHambuerguesaInfo();
            hambSencilla.ShowDialog();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            frmHambuerguesaInfo hambSencilla = new frmHambuerguesaInfo();
            hambSencilla.ShowDialog();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            frmHambuerguesaInfo hambSencilla = new frmHambuerguesaInfo();
            hambSencilla.ShowDialog();
        }
    }
}
