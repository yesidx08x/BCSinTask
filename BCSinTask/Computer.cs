using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Management;

namespace BCSinTask
{
    /// <summary>
    /// 计算机信息类
    /// </summary>
    public  class Computer
    {
        public string CpuID;
        public string[] MacAddress;
        public string[] DiskID;
        public string[] IpAddress;
        public string LoginUserName;
        public string ComputerName;
        public string SystemType;
        public string TotalPhysicalMemory; //单位：MB
        public string[] GpuIDA;
        private static Computer _instance;

        internal static Computer Instance()
        {
            if (_instance == null)
                _instance = new Computer();
            return _instance;
        }

        internal Computer()
        {
            CpuID = GetCpuID();
            GpuIDA = GetGpuID();
            MacAddress = GetMacAddress();
            DiskID = GetDiskID();
            IpAddress = GetIPAddress();
            LoginUserName = GetUserName();
            SystemType = GetSystemType();
            TotalPhysicalMemory = GetTotalPhysicalMemory();
            ComputerName = GetComputerName();
        }
        string GetCpuID()
        {
            try
            {
                //获取CPU序列号代码
                string cpuInfo = "";//cpu序列号 
                ManagementClass mc = new ManagementClass("Win32_Processor");
                ManagementObjectCollection moc = mc.GetInstances();
                foreach (ManagementObject mo in moc)
                {
                    cpuInfo = mo.Properties["Name"].Value.ToString();
                }
                moc = null;
                mc = null;
                return cpuInfo;
            }
            catch
            {
                return "unknow";
            }
            finally
            {
            }

        }
        string[] GetGpuID()
        {
            try
            {
                //获取GPU序列号代码
                List<string> gpuInfoL = new List<string>();
                string gpuInfo = "";//gpu序列号
                ManagementClass mc = new ManagementClass("Win32_VideoController");
                ManagementObjectCollection moc = mc.GetInstances();
                foreach (ManagementObject mo in moc)
                {
                    gpuInfo = mo.Properties["Name"].Value.ToString();
                    gpuInfoL.Add(gpuInfo);
                }
                moc = null;
                mc = null;
                return gpuInfoL.ToArray();
            }
            catch
            {
                return null;
            }
            finally
            {
            }

        }
        string[] GetMacAddress()
        {
            try
            {
                //获取网卡硬件地址
                List<string> macL = new List<string>();
                ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
                ManagementObjectCollection moc = mc.GetInstances();
                foreach (ManagementObject mo in moc)
                {
                    if ((bool)mo["IPEnabled"] == true)
                    {
                        macL.Add(mo["MacAddress"].ToString());
                        //break;
                    }
                }
                moc = null;
                mc = null;
                return macL.ToArray();
            }
            catch
            {
                return new string[] { "unknow" };
            }
            finally
            {
            }

        }
        string[] GetIPAddress()
        {
            try
            {
                //获取IP地址
                List<string> stL = new List<string>();
                ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
                ManagementObjectCollection moc = mc.GetInstances();
                foreach (ManagementObject mo in moc)
                {
                    if ((bool)mo["IPEnabled"] == true)
                    {
                        //st=mo["IpAddress"].ToString();
                        System.Array ar;
                        ar = (System.Array)(mo.Properties["IpAddress"].Value);
                        stL.Add(ar.GetValue(0).ToString());
                        //break;
                    }
                }
                moc = null;
                mc = null;
                return stL.ToArray();
            }
            catch
            {
                return new string[] { "unknow" };
            }
            finally
            {
            }

        }

        string[] GetDiskID()
        {
            try
            {
                //获取硬盘ID
                List<string> HDidL = new List<string>();
                ManagementClass mc = new ManagementClass("Win32_DiskDrive");
                ManagementObjectCollection moc = mc.GetInstances();
                foreach (ManagementObject mo in moc)
                {
                    HDidL.Add((string)mo.Properties["Model"].Value);
                }
                moc = null;
                mc = null;
                return HDidL.ToArray();
            }
            catch
            {
                return new string[] { "unknow" };
            }
            finally
            {
            }

        }

        /// <summary>
        /// 操作系统的登录用户名
        /// </summary>
        /// <returns></returns>
        string GetUserName()
        {
            try
            {
                string st = "";
                ManagementClass mc = new ManagementClass("Win32_ComputerSystem");
                ManagementObjectCollection moc = mc.GetInstances();
                foreach (ManagementObject mo in moc)
                {

                    st = mo["UserName"].ToString();

                }
                moc = null;
                mc = null;
                return st;
            }
            catch
            {
                return "unknow";
            }
            finally
            {
            }

        }

        /// <summary>
        /// PC类型
        /// </summary>
        /// <returns></returns>
        string GetSystemType()
        {
            try
            {
                return osClass.WindowsVersionDetector.GetVersion();
                /*
                //定义系统版本
                Version ver = System.Environment.OSVersion.Version;
                string OSType = "";
                //Major主版本号
                //Minor副版本号
                if (ver.Major == 5 && ver.Minor == 0)
                {
                    OSType = "Windows 2000";
                }
                else if (ver.Major == 5 && ver.Minor == 1)
                {
                    OSType = "Windows XP";
                }
                else if (ver.Major == 5 && ver.Minor == 2)
                {
                    OSType = "Windows 2003";
                }
                else if (ver.Major == 6 && ver.Minor == 0)
                {
                    OSType = "Windows Vista";
                }
                else if (ver.Major == 6 && ver.Minor == 1)
                {
                    OSType = "Windows7";
                }
                else if (ver.Major == 6 && ver.Minor == 2)
                {
                    OSType = "Windows8";
                }
                else if (ver.Major == 6 && ver.Minor == 3)
                {
                    OSType = "Windows10";
                }
                
                return OSType;
                 */
            }
            catch
            {
                return "unknow";
            }
            finally
            {
            }

        }

        /// <summary>
        /// 物理内存
        /// </summary>
        /// <returns></returns>
        string GetTotalPhysicalMemory()
        {
            try
            {

                string st = "";
                ManagementClass mc = new ManagementClass("Win32_ComputerSystem");
                ManagementObjectCollection moc = mc.GetInstances();
                foreach (ManagementObject mo in moc)
                {

                    st = mo["TotalPhysicalMemory"].ToString();

                }
                moc = null;
                mc = null;
                return st;
            }
            catch
            {
                return "unknow";
            }
            finally
            {
            }
        }
        /// <summary>
        ///  获取计算机名称
        /// </summary>
        /// <returns></returns>
        string GetComputerName()
        {
            try
            {
                return System.Environment.GetEnvironmentVariable("ComputerName");
            }
            catch
            {
                return "unknow";
            }
            finally
            {
            }
        }
    }
}
