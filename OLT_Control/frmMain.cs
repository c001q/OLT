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
                if (telnet == null)
                    telnet = new Telnet();

                string strIpAddress = txtIPAddress.Text;
                int intPort = Convert.ToInt16(txtPort.Text);
                string strReceiveText;

                telnet.Connect(strIpAddress, intPort);

                if (telnet.Connected == true)
                {
                    richtxtLogInfo.AppendText("\r\n服务器 " + strIpAddress + ":" + intPort + " 连接成功。\r\n");
                    richtxtLogInfo.AppendText(telnet.WaitFor("Username:"));
                    telnet.Send("yykdzx");
                    richtxtLogInfo.AppendText(telnet.WaitFor("Password:"));
                    telnet.Send("yydx@189.cn");
                    richtxtLogInfo.AppendText(telnet.WaitFor("#"));

                    telnet.Send("show running-config interface epon-olt_1/4/2");
                    strReceiveText = telnet.WaitFor(new string[] { "#", "More" });
                    richtxtLogInfo.AppendText(strReceiveText);

                    telnet.Send(" ");
                    strReceiveText = telnet.WaitFor(new string[] { "#", "More" });
                    richtxtLogInfo.AppendText(strReceiveText);

                    telnet.Send(" ");
                    strReceiveText = telnet.WaitFor(new string[] { "#", "More" });
                    richtxtLogInfo.AppendText(strReceiveText);

                    telnet.Send(" ");
                    strReceiveText = telnet.WaitFor(new string[] { "#", "More" });
                    richtxtLogInfo.AppendText(strReceiveText);

                }

            }
            catch (Exception exc)
            {
                richtxtLogInfo.AppendText("\r\n" + exc.Message);
            }
        }

        private void butClose_Click(object sender, EventArgs e)
        {
            try
            {
                telnet.Close();
                telnet = null;
                richtxtLogInfo.AppendText("\r\n============================================");
                richtxtLogInfo.AppendText("\r\nTcp/IP连接关闭！");
                richtxtLogInfo.AppendText("\r\n============================================");
            }
            catch (NullReferenceException)
            {
                richtxtLogInfo.AppendText("\r\n与telnet服务器连接已经关闭，不需要再次关闭!");
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
