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
    public partial class frmOption : Form
    {
        public frmOption()
        {
            InitializeComponent();
        }

        private void frmOption_Load(object sender, EventArgs e)
        {
            txtOltTxtPath.Text = Properties.Settings.Default.OltList;
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.OltList = txtOltTxtPath.Text;
            Properties.Settings.Default.Save();
            MessageBox.Show("保存成功！");
            this.Close();            
        }

        private void butQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
