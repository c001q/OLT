using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Collections;



namespace TcpIP.Telnet
{



    /// <summary>
    /// 终端类型
    /// </summary>
    enum TerminalType
    {
        vt100,
        vt102,
        vt220,
        vt320,
        ansi,
        scoansi,
        V2EX
    }

    public class Telnet
    {
        private int intReceiveTimeOut = 3000;
        private TcpClient client;
        private NetworkStream stream;
        private bool bolConnected = false;

        #region Protocol Option
        const byte IAC = 255;
        const byte WILL = 251;
        const byte WONT = 252;
        const byte DO = 253;
        const byte DONT = 254;
        const byte SB = 250;
        const byte SE = 240;
        /// <summary>
        /// Binary Transmission [RFC856]
        /// </summary>
        const byte BT = 0;
        /// <summary>
        /// Echo [RFC857]
        /// </summary>
        const byte ECHO = 1;
        /// <summary>
        /// Reconnection [DDN Protocol Handbook, "Telnet Reconnection Option", "Telnet Output Line Width Option", "Telnet Output Page Size Option", NIC 50005, December 1985.]
        /// </summary>
        const byte REC = 2;
        /// <summary>
        /// Suppress Go Ahead	[RFC858]
        /// </summary> 
        const byte SGA = 3;
        /// <summary>
        /// Approx Message Size Negotiation	["The Ethernet, A Local Area Network: Data Link Layer and Physical Layer Specification", AA-K759B-TK, Digital Equipment Corporation, Maynard, MA. Also as: "The Ethernet - A Local Area Network", Version 1.0, Digital Equipment Corporation, Intel Corporation, Xerox Corporation, September 1980. And: "The Ethernet, A Local Area Network: Data Link Layer and Physical Layer Specifications", Digital, Intel and Xerox, November 1982. And: XEROX, "The Ethernet, A Local Area Network: Data Link Layer and Physical Layer Specification", X3T51/80-50, Xerox Corporation, Stamford, CT., October 1980.]
        /// </summary>
        const byte AMSN = 4;
        /// <summary>
        /// Status	[RFC859]
        /// </summary>
        const byte STA = 5;
        //6	    Timing Mark	[RFC860]
        //7	    Remote Controlled Trans and Echo	[RFC726]
        //8	    Output Line Width	[DDN Protocol Handbook, "Telnet Reconnection Option", "Telnet Output Line Width Option", "Telnet Output Page Size Option", NIC 50005, December 1985.]
        //9	    Output Page Size	[DDN Protocol Handbook, "Telnet Reconnection Option", "Telnet Output Line Width Option", "Telnet Output Page Size Option", NIC 50005, December 1985.]
        //10	Output Carriage-Return Disposition	[RFC652]
        //11	Output Horizontal Tab Stops	[RFC653]
        //12	Output Horizontal Tab Disposition	[RFC654]
        //13	Output Formfeed Disposition	[RFC655]
        //14	Output Vertical Tabstops	[RFC656]
        //15	Output Vertical Tab Disposition	[RFC657]
        //16	Output Linefeed Disposition	[RFC658]
        //17	Extended ASCII	[RFC698]
        //18	Logout	[RFC727]
        //19	Byte Macro	[RFC735]
        //20	Data Entry Terminal	[RFC1043][RFC732]
        //21	SUPDUP	[RFC736][RFC734]
        //22	SUPDUP Output	[RFC749]
        //23	Send Location	[RFC779]        
        /// <summary>
        /// Terminal Type	[RFC1091]
        /// </summary>
        const byte TT = 24;
        //25	End of Record	[RFC885]
        //26	TACACS User Identification	[RFC927]
        //27	Output Marking	[RFC933]
        //28	Terminal Location Number	[RFC946]
        //29	Telnet 3270 Regime	[RFC1041]
        //30	X.3 PAD	[RFC1053]
        /// <summary>
        /// Negotiate About Window Size	[RFC1073]
        /// </summary>
        const byte NAWS = 31;
        //32	Terminal Speed	[RFC1079]
        //33	Remote Flow Control	[RFC1372]
        //34	Linemode	[RFC1184]
        //35	X Display Location	[RFC1096]
        //36	Environment Option	[RFC1408]
        /// <summary>
        /// 37	Authentication Option	[RFC2941]
        /// </summary>
        const byte AO = 37;
        //38	Encryption Option	[RFC2946]        
        /// <summary>
        /// New Environment Option	[RFC1572]
        /// </summary>
        const byte NEO = 39;
        //40	TN3270E	[RFC2355]
        //41	XAUTH	[Rob_Earhart]
        //42	CHARSET	[RFC2066]
        //43	Telnet Remote Serial Port (RSP)	[Robert_Barnes]
        //44	Com Port Control Option	[RFC2217]
        //45	Telnet Suppress Local Echo	[Wirt_Atmar]
        //46	Telnet Start TLS	[Michael_Boe]
        //47	KERMIT	[RFC2840]
        //48	SEND-URL	[David_Croft]
        //49	FORWARD_X	[Jeffrey_Altman]
        //50-137	Unassigned	[IANA]
        //138	TELOPT PRAGMA LOGON	[Steve_McGregory]
        //139	TELOPT SSPI LOGON	[Steve_McGregory]
        //140	TELOPT PRAGMA HEARTBEAT	[
        #endregion

        public Telnet()
        {
            client = new TcpClient();
        }

        public void Connect(string Address, int Port)
        {
            try
            {
                client.Connect(Address, Port);
                if (client.Connected)
                {
                    stream = client.GetStream();
                    bolConnected = true;
                }
                else
                {
                    bolConnected = false;
                }
                
            }
            catch (ArgumentNullException)
            {
                throw new Exception("主机名不能为空。");
            }
            catch (ArgumentOutOfRangeException)
            {
                throw new Exception("port 参数不在 MinPort 和 MaxPort 之间。");
            }
            catch (ObjectDisposedException)
            {
                throw new Exception("TcpClient 被关闭。");
            }
            catch (SocketException e)
            {
                throw new Exception(e.Message);
            }





        }

        public bool Connected
        {
            get
            {
                return bolConnected;
            }
        }

        public string WaitFor(string WaitText)
        {

            byte[] byeRead;
            ArrayList al = new ArrayList();
            string strReturnText;
            Encoding e1 = Encoding.GetEncoding(936);




            // byte[] byeSent = new byte[]{};
            // List<byte> listSent = new List<byte>(byeSent);   

            try
            {
                while (WaitData() > 0)
                {
                    // 提取Tcp缓冲区的数据
                    byeRead = new byte[client.Available];
                    stream.Read(byeRead, 0, byeRead.Length);


                    if (IsContainIAC(byeRead))
                    {
                        // 如果数据中包含了IAC字符，就进行Telnet协商后，再返回字符串                        
                        al.AddRange(HandleTelnetOption(byeRead));
                    }
                    else
                    {
                        // 如果数据中没有IAC字符，就直接返回字符串                       
                        al.AddRange(byeRead);

                    }

                    byte[] byeText = (byte[])al.ToArray(typeof(byte));

                    strReturnText = new string(e1.GetChars(byeText));
                    ;

                    // 如果包含了指定字符，就可以退出等待
                    if (strReturnText.Contains(WaitText))
                        return strReturnText;
                }

                return "";
            }
            catch (Exception e)
            {
                throw new Exception("服务器无法返回你所期待的消息。原因是：" + e.Message);
            }



        }

        /// <summary>
        /// 处理Telnet选项
        /// </summary>
        /// <param name="byeRead"></param>
        /// <returns>选项处理完后的正常字符串</returns>
        private ArrayList HandleTelnetOption(byte[] byeRead)
        {
            byte byeVerb;
            byte byeOption;
            byte[] byeSent;


            ArrayList AL = new ArrayList();
            for (int i = 0; i < byeRead.Length; i++)
            {
                switch (byeRead[i])
                {
                    case IAC:
                        byeVerb = byeRead[++i];
                        byeOption = byeRead[++i];

                        switch (byeVerb)
                        {
                            case DO:
                                switch (byeOption)
                                {
                                    case AO:
                                        byeSent = new byte[] { IAC, WILL, AO };
                                        stream.Write(byeSent, 0, byeSent.Length);
                                        break;
                                    case NEO:
                                        byeSent = new byte[] { IAC, WILL, NEO };
                                        stream.Write(byeSent, 0, byeSent.Length);
                                        break;
                                    case NAWS:
                                        byeSent = new byte[] { IAC, WILL, NAWS };
                                        stream.Write(byeSent, 0, byeSent.Length);
                                        byeSent = new byte[] { IAC, SB, NAWS, 0x00, 0x50, 0x00, 0x19, IAC, SE };
                                        stream.Write(byeSent, 0, byeSent.Length);
                                        break;
                                    case BT:
                                        byeSent = new byte[] { IAC, WILL, BT };
                                        stream.Write(byeSent, 0, byeSent.Length);
                                        break;
                                    case TT:
                                        byeSent = new byte[] { IAC, WILL, TT };
                                        stream.Write(byeSent, 0, byeSent.Length);
                                        break;
                                    default:
                                        break;
                                }
                                break;
                            case DONT:
                                break;
                            case WILL:
                                switch (byeOption)
                                {
                                    case ECHO:
                                        byeSent = new byte[] { IAC, DO, ECHO };
                                        stream.Write(byeSent, 0, byeSent.Length);
                                        break;
                                    case SGA:
                                        byeSent = new byte[] { IAC, DO, SGA };
                                        stream.Write(byeSent, 0, byeSent.Length);
                                        break;
                                    case BT:
                                        byeSent = new byte[] { IAC, DO, BT };
                                        stream.Write(byeSent, 0, byeSent.Length);
                                        break;
                                    default:
                                        break;
                                }
                                break;
                            case WONT:
                                break;
                            case SB:
                                switch (byeOption)
                                {
                                    case AO:
                                        i = GoToSubOptionSB(byeRead, i);
                                        byeSent = new byte[] { IAC, SB, AO, 0x00, 0x00, 0x00, IAC, SE };
                                        stream.Write(byeSent, 0, byeSent.Length);
                                        break;
                                    case NEO:
                                        i = GoToSubOptionSB(byeRead, i);
                                        i++;
                                        i++;
                                        i = GoToSubOptionSB(byeRead, i);
                                        byeSent = new byte[] { IAC, SB, NEO, 0x00, IAC, SE };
                                        stream.Write(byeSent, 0, byeSent.Length);
                                        byeSent = new byte[] { IAC, SB, NEO, 0x00, 0x03, 0x53, 0x46, 0x55, 0x54, 0x4c, 0x4e, 0x54, 0x56, 0x45, 0x52, 0x01, 0x32, 0x03, 0x53, 0x46, 0x55, 0x54, 0x4c, 0x4e, 0x54, 0x4d, 0x4f, 0x44, 0x45, 0x01, 0x43, 0x6f, 0x6e, 0x73, 0x6f, 0x6c, 0x65, IAC, SE };
                                        stream.Write(byeSent, 0, byeSent.Length);
                                        break;
                                    case TT:
                                        i = GoToSubOptionSB(byeRead, i);
                                        byeSent = new byte[] { IAC, SB, TT, 0x00, 0x76, 0x74, 0x32, 0x32, 0x30, IAC, SE };

                                        stream.Write(byeSent, 0, byeSent.Length);
                                        break;
                                    default:
                                        break;
                                }
                                break;
                            default:
                                break;
                        }
                        break;
                    default:
                        AL.Add(byeRead[i]);
                        break;
                }
            }
            return AL;
        }


        /// <summary>
        /// 判断数组中是否包含了IAC
        /// </summary>
        /// <param name="byesRead">要分析的数组</param>
        /// <returns>如果有IAC返回True，否则返回False</returns>
        private bool IsContainIAC(byte[] byesRead)
        {
            foreach (byte b in byesRead)
            {
                if (b == 255) return true;
            }
            return false;
        }

        /// <summary>
        /// 分析数组中子选项IAC,SB的位置
        /// </summary>
        /// <param name="byeReceive">要分析的数组</param>
        /// <param name="intCurrentIndex">当前已经处理到那个字节</param>
        /// <returns>返回 SB 在数组中的位置，没有返回0 </returns>
        private int GoToSubOptionSB(byte[] byeReceive, int intCurrentIndex)
        {
            int i = intCurrentIndex;
            do
            {

            } while (byeReceive[++i] != IAC);

            return byeReceive[++i] == SE ? i : 0;

        }

        /// <summary>
        /// 等候有数据返回为止
        /// </summary>
        private int WaitData()
        {
            DateTime oltDateTime = DateTime.Now;
            DateTime newDateTime = oltDateTime.AddMilliseconds(intReceiveTimeOut);

            // int i = 0;
            while (client.Available == 0)
            {
                // 判断用Telnet服务器获取数据是否超时
                if (DateTime.Now > newDateTime) throw new Exception("Tcp接收缓冲区数据已经接收完成，或没有收到过任何数据。");
                // Console.WriteLine(i++);
            }

            return client.Available;
        }

        /// <summary>
        /// 等待Telnet服务器返回数据
        /// </summary>
        /// <param name="TimeSpan">超时时长</param>
        private void WaitData(int TimeSpan)
        {
            intReceiveTimeOut = TimeSpan;
            DateTime oltDateTime = DateTime.Now;
            DateTime newDateTime = oltDateTime.AddMilliseconds(intReceiveTimeOut);

            // int i = 0;
            while (client.Available == 0)
            {
                // 判断用Telnet服务器获取数据是否超时
                if (DateTime.Now > newDateTime) throw new Exception("Tcp缓冲区无可用数据。");
                // Console.WriteLine(i++);
            }
        }

        public void Close()
        {
            client.Close();
        }

        public int ReadTimeOut
        {
            get
            {
                return intReceiveTimeOut;
            }
            set
            {
                intReceiveTimeOut = value;
            }
        }
        public bool Send(string sendText)
        {
            byte[] byeSendText;
            byeSendText = System.Text.Encoding.ASCII.GetBytes(sendText + "\r\n");
            stream.Write(byeSendText, 0, byeSendText.Length);
            return true;
        }
    }
}
