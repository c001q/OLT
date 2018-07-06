using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TcpIP.Telnet;
using System.Text.RegularExpressions;

namespace OLT_Control
{
    public class ZTXCmd
    {

        Telnet telnet;

        /// <summary>
        /// ZTXCmd类 构造函数
        /// </summary>
        public ZTXCmd()
        {
            telnet = new Telnet();
        }
        
        /// <summary>
        /// 连接OLT设备
        /// </summary>
        /// <param name="IpAddress"></param>
        /// <param name="Port"></param>
        /// <returns></returns>
        public string Connect(string IpAddress, int Port)
        {
            telnet.Connect(IpAddress, Port);
            //telnet.WaitFor(
            return "";
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="UserName"></param>
        /// <param name="PassWrod"></param>
        /// <returns></returns>
        public string Login(string UserName, string PassWrod)
        {
            return "";
        }


        public string ShowRunning(int fram, int card, int port)
        {
            
            return "";
        }
        
        /// <summary>
        /// 退出操作
        /// </summary>
        public void Quit()
        {

            telnet.Close();
            telnet = null;
        }




    }
}
