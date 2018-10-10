using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCSinTask
{
    class charClass
    {
        /// <summary>
        /// 判断是否是非法字符
        /// </summary>
        /// <param name="str">判断是字符</param>
        /// <returns></returns>
        public static Boolean isLegalNumber(string str)
        {
            char[] charStr = str.ToLower().ToCharArray();
            for (int i = 0; i < charStr.Length; i++)
            {
                int num = Convert.ToInt32(charStr[i]);
                if ((IsChineseLetter(num) || (num >= 48 && num <= 57) || (num >= 97 && num <= 123) || (num >= 65 && num <= 90) || num == 45))
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// 判断是否是数字字符
        /// </summary>
        /// <param name="str">判断是数字符</param>
        /// <returns></returns>
        public static Boolean isNumber(string str)
        {
            char[] charStr = str.ToLower().ToCharArray();
            for (int i = 0; i < charStr.Length; i++)
            {
                int num = Convert.ToInt32(charStr[i]);
                if (num >= 48 && num <= 57)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// 判断字符的Unicode值是否是汉字
        /// </summary>
        /// <param name="code">字符的Unicode</param>
        /// <returns></returns>
        protected static bool IsChineseLetter(int code)
        {
            int chfrom = Convert.ToInt32("4e00", 16);    //范围（0x4e00～0x9fff）转换成int（chfrom～chend）
            int chend = Convert.ToInt32("9fff", 16);

            if (code >= chfrom && code <= chend)
            {
                return true;     //当code在中文范围内返回true

            }
            else
            {
                return false;    //当code不在中文范围内返回false
            }

            return false;
        }
        /// <summary>
        ///切去尾部的数字，保留前面和中间的
        /// </summary>
        /// <param name="ComputerName"></param>
        /// <returns></returns>
        public static string splitName(string ComputerName)
        {
            char[] charStr = ComputerName.ToLower().ToCharArray();
            string newName = "";
            int index = 0;
            for (int i = charStr.Length - 1; i > -1; i--)
            {
                int num = Convert.ToInt32(charStr[i]);
                if (num >= 48 && num <= 57)
                {
                    index++;
                }
                else
                {
                    break;
                }
            }
            newName = ComputerName.Substring(0, charStr.Length - 1);
            return newName;
        }
    }
}
