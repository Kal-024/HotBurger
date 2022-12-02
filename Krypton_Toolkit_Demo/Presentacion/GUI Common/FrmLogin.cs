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

namespace Krypton_Toolkit_Demo
{
    public partial class frmLogin : KryptonForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FrmAperturaCaja aperturaCaja = new FrmAperturaCaja();
            this.Hide();
            aperturaCaja.ShowDialog();
            //this.Visible = false;
            this.Close();
        }
    }
}
