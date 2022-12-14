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
    public partial class FrmPedidoAbastecimiento : KryptonForm
    {
        public FrmPedidoAbastecimiento()
        {
            InitializeComponent();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            frmCocaColaList cocaList = new frmCocaColaList();
            cocaList.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmPedidoAbastecimiento_Load(object sender, EventArgs e)
        {
            AddCheckColumn(dataGridView2);
        }

        public static void AddCheckColumn(DataGridView dgv)
        {
            DataGridViewCheckBoxColumn chkCol = new DataGridViewCheckBoxColumn();
            chkCol.Name = "Detalle";
            dgv.Columns.Add(chkCol);
        }
    }
}
