using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TcpIP.Telnet;
using System.Text.RegularExpressions;
using OLT_Control.Text;
using System.Collections;

namespace OLT_Control.OltCmd
{
    public class ZTEOlt
    {
        Telnet _telnet;
        string _sUserName;
        string _sPassWord;
        string _sIPAddress;
        string _sLog;
        int _intPort;

        public ZTEOlt(string IPAddress, int Port, string UserName, string PassWord)
        {
                _sIPAddress = IPAddress;
                _sUserName = UserName;
                _sPassWord = PassWord;
                _intPort = Port;
                
                _telnet = new Telnet();

                Login(_sUserName, _sPassWord);
        }

        public ArrayList GetOfflineOnus(string frame, string card, string port)
        {
            string[,] sOlts = new string[,] { { } };
            string[,] sCloseOlts = new string[,] { { } };
            string sReceive = "";
            Regex rgx;
            MatchCollection matches;
            string sMatchValue;
            string[] sMatchs;
            int iRowIndex = 0;
            int iRowsCount = 0;
            int iColCount = 6;

            // 运行 show running-config interface 指令            
            _telnet.Send("show running-config interface epon-olt_" + 
                frame + "/" + 
                card + "/" + 
                port);

            while(sReceive.IndexOf("#") == -1)
            {
                sReceive += _telnet.WaitFor(new string[]{"More","#"});
                _telnet.Send(" ", false);
            }


            // 处理回退符
            OltText oltText = new OltText();
            sReceive = oltText.HandleBackspace(sReceive);

            // 提取LOID列表
            rgx = new Regex(@"onu.*?static",RegexOptions.IgnoreCase);
            matches = rgx.Matches(sReceive);
            iRowsCount= matches.Count;
            sOlts = new string[iRowsCount, iColCount];
            
            foreach (Match match in matches)
            {
                sMatchValue = match.Value;
                sMatchs = sMatchValue.Split(' ');
                sOlts[iRowIndex, 0] = sMatchs[1];
                sOlts[iRowIndex, 1] = sMatchs[3];
                sOlts[iRowIndex, 2] = sMatchs[5];

                iRowIndex++;
            }

            // 把结果加入到日志中,并清空
            _sLog += sReceive;
            sReceive = "";

            // 运行 show onu all-status 指令
            _telnet.Send("show onu all-status epon-olt_" + 
                frame + "/" + 
                card + "/" + 
                port);

            while (sReceive.IndexOf("#") == -1)
            {
                sReceive += _telnet.WaitFor(new string[] { "More", "#" });
                _telnet.Send(" ", false);
            }

            // 处理回退符           
            sReceive = oltText.HandleBackspace(sReceive);
            // 将返回的内容加入到日志属性中
            _sLog += sReceive;

            // 提取LOID列表
            rgx = new Regex(@"epon-onu.*", RegexOptions.IgnoreCase);
            matches = rgx.Matches(sReceive);
            iRowIndex = 0;
            Regex regexSplit = new Regex(@"\s+");
            foreach (Match match in matches)
            {
                sMatchValue = match.Value;
                sMatchs = regexSplit.Split(sMatchValue);
                sOlts[iRowIndex, 3] = sMatchs[0];
                sOlts[iRowIndex, 4] = sMatchs[1];
                sOlts[iRowIndex, 5] = sMatchs[2];                

                iRowIndex++;
            }
                        
            ArrayList arrayList = new ArrayList();
            
            // 提取关闭的端口
            for (int i = 0; i < iRowsCount; i++)
            {
                if (sOlts[i,5] !=  "Online")
                {
                  arrayList.Add(sOlts[i, 0]);
                  arrayList.Add(sOlts[i, 1]);
                  arrayList.Add(sOlts[i, 2]);
                  arrayList.Add(sOlts[i, 3]);
                  arrayList.Add(sOlts[i, 4]);
                  arrayList.Add(sOlts[i, 5]);
                }
            }

            return arrayList;
        }

        public string DeleteOnu()
        {

            return "";
        }
        
        public string Log
        {
            get 
            {
                return _sLog;
            }

            set
            {
                _sLog = value;
            }
        }

        private string Login(string username, string password)
        {

            string sReturn = "";
         
            // 参数检查
            if (username == "") 
                throw new ArgumentNullException("username", "参数不能为空");
            if (password == "")
                throw new ArgumentNullException("password", "参数不能为空");           

            _telnet.Connect(_sIPAddress, _intPort);

            sReturn += _telnet.WaitFor("Username:");
            _telnet.Send(username);

            sReturn += _telnet.WaitFor("Password:");        
            _telnet.Send(password);

            sReturn += _telnet.WaitFor("#");
            _sLog += sReturn;

            return sReturn;
        }

        private string Close()
        {
            string sQuitInfo = "";
            
            
            return sQuitInfo;
        }
       
    }

   

}
