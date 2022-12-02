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
            MessageBox.Show("TERMINAR PEDIDO", "ASISTENTE - HOT BURGER", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            try
            {
                Thread frmFact = new Thread(Impresion);

                showMessage("Orden de impresión a: EPSON 2FS3-4SA ...", 2500);
                frmFact.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
            this.Visible = false;
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TERMINAR PEDIDO", "ASISTENTE - HOT BURGER", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            try
            {
                Thread frmFact = new Thread(Impresion);

                showMessage("Orden de impresión a: EPSON 2FS3-4SA ...", 2500);
                frmFact.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
            this.Visible = false;
            MessageBox.Show("IMPRESION REALIZADA CON EXITO (COMANDA)", "ASISTENTE - HOT BURGER", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        }

        static void Impresion()
        {
            FrmFactura factura = new FrmFactura();
            factura.ShowDialog();

            DialogResult r2 = MessageBox.Show("IMPRESION REALIZADA CON EXITO!!", "ASISTENTE - HOT BURGER", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (r2 == DialogResult.OK)
            {
                //frmFactura factura = new frmFactura();
                factura.Visible = false;
                factura.Close();
            }
        }

        private void showMessage(string msg, int duration)
        {
            using (Timer t = new Timer())
            {
                Timer time = new Timer();
                time.Interval = duration;
                time.Tick += timeTick;  /* Evento enlazado */

                time.Start();

                /* Muestras el texto en el MB */
                MessageBox.Show(msg);
            }
        }
        private void timeTick(object sender, EventArgs e)
        {
            (sender as Timer).Stop();  /* Detiene el Timer */
            SendKeys.Send("{ESC}"); /* Hace la simulación de la tecla Escape, también puedes usar {ENTER} */
        }

    }
}
