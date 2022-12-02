using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Krypton_Toolkit_Demo.View
{
    public partial class FrmPago : KryptonForm
    {
        public FrmPago()
        {
            InitializeComponent();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            FrmCambio cambio = new FrmCambio();
            cambio.ShowDialog();
            this.Visible = false;
            this.Close();
        }

        
        

    }
}
