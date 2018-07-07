using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TcpIP.Telnet;
using System.Text.RegularExpressions;

namespace OLT_Control
{
    public class ZTEOlt
    {
        Telnet telnet;

        string _sUserName;
        string _sPassWord;        
        string _sLog;

        public ZTEOlt(string UserName, string PassWord)
        {            
            _sUserName = UserName;
            _sPassWord = PassWord;
        }

        public string[] GetOfflineOnus()
        {
            string[] Onus = new string[]{};
            return Onus;
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

       
    }
}
