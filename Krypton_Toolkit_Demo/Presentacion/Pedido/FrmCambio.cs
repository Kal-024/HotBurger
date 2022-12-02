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
    public partial class FrmCambio : KryptonForm
    {
        public FrmCambio()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            double cambio = 0;
            try
            {
                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    MessageBox.Show("PORFAVOR INGRESE EL EFECTIVO", "ASISTENTE - Hot Burger");
                }
                else
                {
                    cambio = Convert.ToDouble(textBox1.Text) - 175.65;
                    if (cambio < 0)
                    {
                        MessageBox.Show(" EFECTIVO INSUFICIENTE, PORFAVOR INGRESE EL VALOR RESTANTE", "ASISTENTE - Hot Burger");
                        textBox1.Text = "";
                    }
                    lblCambio.Text = "C$    " + cambio + ".00";

                    MessageBox.Show("C$    " + cambio + ".00", "CAMBIO", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
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
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }

            
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
