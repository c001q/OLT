using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OLT_Control.OltCmd;
using System.Collections;

namespace OLT_Control
{
    public partial class frmZTENoAvailablePort : Form
    {
        public frmZTENoAvailablePort()
        {
            InitializeComponent();
        }
        
        private void butSearch_Click(object sender, EventArgs e)
        {
            ZTEOlt _zolt;
            ArrayList arrayList = new ArrayList();
            int intRowCellIndex;

            _zolt = new ZTEOlt(
                txtIPAddress.Text,
                23,
                "yykdzx",
                "yydx@189.cn");

            rtxtLogInfo.Clear();
            dgvOnuList.Rows.Clear();

            arrayList = _zolt.GetOfflineOnus(txtFrame.Text, txtCard.Text, txtPort.Text);

            int c = 0;

            for (int o = 0; o <= arrayList.Count / 6 -1; o++)
            {
                intRowCellIndex = dgvOnuList.Rows.Add();

                for (int i = 0; i <= 5; i++)
                    dgvOnuList.Rows[intRowCellIndex].Cells[i].Value = arrayList[c++];
            }
            
            rtxtLogInfo.AppendText(_zolt.Log);
        }

        private void itemDeleOlt_Click(object sender, EventArgs e)
        {

        }

        private void dgvOnuList_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            dgvOnuList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            if (e.Button == MouseButtons.Right)
            {

                if (dgvOnuList.Rows[e.RowIndex].Selected == false)
                {
                    dgvOnuList.ClearSelection();
                    dgvOnuList.Rows[e.RowIndex].Selected = true;
                }
                if (dgvOnuList.SelectedRows.Count == 1)
                {
                    dgvOnuList.CurrentCell = dgvOnuList.Rows[e.RowIndex].Cells[e.ColumnIndex];
                }
                cmsManagerOlt.Show(MousePosition.X, MousePosition.Y);
            }

            if (e.Button == MouseButtons.Left)
            {
                
                    dgvOnuList.ClearSelection();
                    dgvOnuList.Rows[e.RowIndex].Selected = true;                    
                
            }
        }

      
    }
}
