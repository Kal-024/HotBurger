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
    public partial class FrmCaja : KryptonForm
    {
        public FrmCaja()
        {
            InitializeComponent();
        }

        public static void AddCheckColumn(DataGridView dgv)
        {
            DataGridViewCheckBoxColumn chkCol = new DataGridViewCheckBoxColumn();
            chkCol.Name = "Estado";
            dgv.Columns.Add(chkCol);
        }

        private void FrmCaja_Load(object sender, EventArgs e)
        {
            AddCheckColumn(dataGridView1);
        }
    }
}
