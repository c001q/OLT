using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OLT_Control.Text
{
    class OltText
    {

        /// <summary>
        /// 处理字符串中的 Backspace 字符
        /// </summary>
        /// <param name="text">要处理的字符串</param>
        /// <returns></returns>
        public string HandleBackspace(string text)
        {            
            int intDelIndex;

            while (text.IndexOf("\b") > -1)
            {
                intDelIndex = text.IndexOf("\b");

                text = text.Remove(intDelIndex - 1, 2);
            }
            return text;
        }
    }
}
