using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OLT_Control
{
    public partial class frmTroubleType : Form
    {
        public frmTroubleType()
        {
            InitializeComponent();
        }

        frmZTENoAvailablePort f3;
        frmOption frmOpt;


        private void butNoAvailablePort_Click(object sender, EventArgs e)
        {
            switch (cmboxOltType.Text)
            {
                case "ZTE":
                    if (f3 == null || f3.IsDisposed)
                    {
                        f3 = new frmZTENoAvailablePort();
                        f3.StartPosition = FormStartPosition.CenterScreen;
                        f3.Show();
                    }
                    else
                    {
                        f3.Activate();//之前已打开，则给予焦点，置顶。
                    }        
                    break;
                case "HUAWEI":

                    break;
                default:
                    break;
            }
        }

        private void butOltList_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe", Properties.Settings.Default.OltList);                      
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butOption_Click(object sender, EventArgs e)
        {
            if (frmOpt == null || frmOpt.IsDisposed)
            {
                frmOpt = new frmOption();
                frmOpt.StartPosition = FormStartPosition.CenterScreen;
                frmOpt.Show();
            }
            else
            {
                frmOpt.Activate();//之前已打开，则给予焦点，置顶。
            }     
        }


     
  
    }
}
