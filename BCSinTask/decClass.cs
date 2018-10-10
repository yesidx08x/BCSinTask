using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Security.Cryptography;
using System.Data;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace BCSinTask
{
    public sealed class decClass
    {
        public const string salt = "86d38f993cb74456a8b8b7b0313c7791";
        /// <summary>
        /// DES加密字符串
        /// </summary>
        /// <param name="sourceString"></param>
        /// <param name="key"></param>
        /// <param name="iv"></param>
        /// <returns></returns>
        public static string Encrypt(string sourceString, string key, string iv)
        {
            try
            {
                byte[] btKey = Encoding.UTF8.GetBytes(key);

                byte[] btIV = Encoding.UTF8.GetBytes(iv);

                DESCryptoServiceProvider des = new DESCryptoServiceProvider();

                using (MemoryStream ms = new MemoryStream())
                {
                    byte[] inData = Encoding.UTF8.GetBytes(sourceString.Trim());
                    try
                    {
                        using (CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(btKey, btIV), CryptoStreamMode.Write))
                        {
                            cs.Write(inData, 0, inData.Length);

                            cs.FlushFinalBlock();
                        }

                        return Convert.ToBase64String(ms.ToArray());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error#2002:加密文件内容失败！\r\n" + ex.ToString(), "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch { }

            return "DES加密出错";
        }

        /// <summary>
        /// DES解密字符串
        /// </summary>
        /// <param name="encryptedString"></param>
        /// <param name="key"></param>
        /// <param name="iv"></param>
        /// <returns></returns>
        public static string Decrypt(string encryptedString, string key, string iv)
        {
            byte[] btKey = Encoding.UTF8.GetBytes(key);

            byte[] btIV = Encoding.UTF8.GetBytes(iv);

            DESCryptoServiceProvider des = new DESCryptoServiceProvider();

            using (MemoryStream ms = new MemoryStream())
            {
                byte[] inData = Convert.FromBase64String(encryptedString);
                try
                {
                    using (CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(btKey, btIV), CryptoStreamMode.Write))
                    {
                        cs.Write(inData, 0, inData.Length);

                        cs.FlushFinalBlock();
                    }

                    return System.Text.Encoding.UTF8.GetString(ms.ToArray());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error#2003:解密文件内容失败！\r\n" + ex.ToString(), "Error",
                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return encryptedString;
                }
            }
        }
    }
}
