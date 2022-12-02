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
using System.Web.UI.Design.WebControls.WebParts;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Krypton_Toolkit_Demo.View
{
    public partial class FrmMenuPrincipal : KryptonForm
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
            OpenChildFormPedido(new Presentacion.Caja.FrmPedido());
        }

        private void pcbReturn_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("¿Seguro que quieres Cerrar Sesion?", "ASISTENTE - HOT BURGER",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
                if (r == DialogResult.Yes)
                {
                    frmLogin inicioSesion = new frmLogin();
                    inicioSesion.ShowDialog();
                    this.Visible = false;
                    this.Close();
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("¿Quieres eliminar el pedido?", "ASISTENTE - HOT BURGER", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (r == DialogResult.Yes)
                {
                    //frmLogin inicioSesion = new frmLogin();
                    //inicioSesion.ShowDialog();
                    //this.Visible = false;
                    //this.Close();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        //----------------------------------------------------------------------------------------------------
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

        private Form activeForm = null;
        private Form activeForms = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlMenus.Controls.Add(childForm);
            pnlMenus.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void OpenChildFormPedido(Form childForm)
        {
            if (activeForms != null)
            {
                activeForms.Close();
            }
            activeForms = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlFactura.Controls.Add(childForm);
            pnlFactura.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        /*
         OpenChildForm(new pnlInsumos());
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel2.BorderStyle = BorderStyle.None;
            panel3.BorderStyle = BorderStyle.None;
         */

        private void panel7_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FrmPago pago = new FrmPago();
            pago.ShowDialog();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            MessageBox.Show("COMANDA ENVIADA A COCINA CON EXITO!!", "ASISTENTE - HOT BURGER", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new pnlComidas());
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel3.BorderStyle = BorderStyle.None;
            panel7.BorderStyle = BorderStyle.None;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new pnlBebidas());
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel2.BorderStyle = BorderStyle.None;
            panel7.BorderStyle = BorderStyle.None;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            showMessage("Generando Reportes ...", 1500);
            MainBoletos mainBoletos = new MainBoletos();
            mainBoletos.ShowDialog();
        }
    }
}
