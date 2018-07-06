using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TcpIP.Telnet;

namespace OLT_Control
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        Telnet telnet;

        private void butConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if(telnet == null) 
                    telnet = new Telnet();

                string strIpAddress = txtIPAddress.Text;
                int intPort = Convert.ToInt16(txtPort.Text);

                telnet.Connect(strIpAddress, intPort);

                if (telnet.Connected == true)
                {
                    richtxtLogInfo.AppendText("服务器 " + strIpAddress + ":" + intPort + " 连接成功。\r\n"  );
                    richtxtLogInfo.AppendText(telnet.WaitFor("login:"));
                    telnet.Send("cq");
                    richtxtLogInfo.AppendText(telnet.WaitFor("password:"));
                    telnet.Send("windows001");
                    richtxtLogInfo.AppendText(telnet.WaitFor(">"));
                    telnet.Send("dir");
                    richtxtLogInfo.AppendText(telnet.WaitFor(">"));
                    telnet.Send("cd Favorites");
                    richtxtLogInfo.AppendText(telnet.WaitFor(">"));
                    telnet.Send("dir");
                    richtxtLogInfo.AppendText(telnet.WaitFor(">"));
                }

                telnet.Close();
                telnet = null;
            }
            catch (Exception exc)
            {
                richtxtLogInfo.AppendText(exc.Message);
            }
        }

        private void butClose_Click(object sender, EventArgs e)
        {
            try
            {
                telnet.Close();
                telnet = null;
            }
            catch(NullReferenceException)
            {
                richtxtLogInfo.AppendText("与telnet服务器连接已经关闭，不需要再次关闭!\r\n");
            }
            
        }

        private void butClean_Click(object sender, EventArgs e)
        {
            richtxtLogInfo.Clear();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
