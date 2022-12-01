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
    public partial class frmHotDogList : KryptonForm
    {
        public frmHotDogList()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmHotDogInfo hot = new frmHotDogInfo();
            hot.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmHotDogInfo hot = new frmHotDogInfo();
            hot.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmHotDogInfo hot = new frmHotDogInfo();
            hot.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmHotDogInfo hot = new frmHotDogInfo();
            hot.ShowDialog();
        }
    }
}
