using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OLT_Control.OltCmd;

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

            _zolt = new ZTEOlt(
                txtIPAddress.Text,
                23,
                "yykdzx",
                "yydx@189.cn");

            rtxtLogInfo.Clear();

            _zolt.GetOfflineOnus(txtFrame.Text, txtCard.Text, txtPort.Text);

            rtxtLogInfo.AppendText(_zolt.Log);
        }
    }
}
