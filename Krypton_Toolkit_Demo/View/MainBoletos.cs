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
    public partial class MainBoletos : KryptonForm
    {
        public MainBoletos()
        {
            InitializeComponent();
        }

        private void btnSingUp_Click(object sender, EventArgs e)
        {
            frmBoletoCierre boletoCierre = new frmBoletoCierre();
            boletoCierre.ShowDialog();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            frmBoletoInventario boletoInventario = new frmBoletoInventario();
            boletoInventario.ShowDialog();
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            frmBoletoProductos boletoProductos = new frmBoletoProductos();
            boletoProductos.ShowDialog();
        }

        private void MainBoletos_Load(object sender, EventArgs e)
        {

        }
    }
}
