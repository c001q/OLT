using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace OLT_Control
{
    public partial class frmOLTMain : Form
    {
        public frmOLTMain()
        {
            InitializeComponent();
        }

        private void frmOLTMain_Load(object sender, EventArgs e)
        {   
            // 保存记录行。
            string[] strCellText;
            StreamReader sr = new StreamReader("f:\\Visual Studio 2010\\Projects\\OLT\\OLT_Control\\OltList.txt");

            ArrayList al = new ArrayList();

            while(!sr.EndOfStream)
            {
                al.Add(sr.ReadLine());
            }

            int intRowCellIndex;
            foreach (Object obj in al)
            {
                strCellText =  Convert.ToString(obj).Split(',');  

                intRowCellIndex = dgvOltList.Rows.Add();
                
                for (int i = 0;i <= strCellText.Length-1;i++)
                    dgvOltList.Rows[intRowCellIndex].Cells[i].Value = strCellText[i];
            }

            
        }

        private void butSearch_Click(object sender, EventArgs e)
        {

        }

      
    }
}
