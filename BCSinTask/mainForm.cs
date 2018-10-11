using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Management;
using System.Diagnostics;
using System.Threading;
using System.Xml;
using System.Runtime.InteropServices;
using System.Timers;

namespace BCSinTask
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }
        Thread cpuThread;
        Thread ramThread;
        Thread gpuThread;
        private int CheckUpDateLock=0;
        // 定义数据检查Timer
        private static object LockObject = new Object();
        private static System.Timers.Timer CheckUpdatetimer = new System.Timers.Timer();
        private string locPath = System.Windows.Forms.Application.StartupPath;
        private string pyFile = System.Windows.Forms.Application.StartupPath + "\\client.py";
        private string configFile = System.Windows.Forms.Application.StartupPath + "\\BCSinTask.config";
        private string cfgFile;
        private const string strconn = "mongodb://192.168.10.9:27017";//以后放配置文件里
        private string prcPath = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\.RedChess";
        private string slaveMachineName = Dns.GetHostName().ToString();
        private string renderer = string.Empty;
        private string TILE = "BCSinTask --- v";
        private string PLUGIN_PATH = string.Empty;
        private string cmdFile = string.Empty;
        private Dictionary<string, string> logDict = new Dictionary<string, string>();
        private infoClass stateInfoClass = new infoClass();
        private Computer myPC;

        public string[] maintxt = new string[5] { "", "", "", "", "" };
        private StringBuilder result = new StringBuilder();
        private string _nvsmiPath = @"C:\Program Files\NVIDIA Corporation\NVSMI\nvidia-smi.exe";

        private List<bool> checkArgL = new List<bool>();
        private Dictionary<string, string> freeDict = new Dictionary<string, string>();
        //decClass.Encrypt(str,"20170214", salt)
        //decClass.Decrypt(str,"20170214", salt)
        public const string salt = "86d38f993cb74456a8b8b7b0313c7791";
        //private string akiStr = decClass.Encrypt("1111111111111111", "20170214", salt);
        //private string aksStr = decClass.Encrypt("000000000000000000000000000000", "20170214", salt);
        private string[] configTxtA = { "access_key_id#"+decClass.Encrypt("1111111111111111", "20170214", salt),
                               "access_key_secret#"+decClass.Encrypt("000000000000000000000000000000", "20170214", salt),
                               "endpoint#CN_BEIJING",
                               "cluster_id#cls-92ek97clnlncseeg8k800c",
                               "group_name#m16sp6rs2076y216E",
                               "max_item#2"};

        private string[] cfgTxtA = { "[time]5",
                               "[timeCHK]"+true.ToString(),
                               "[gpu_dumping]5",
                               "[gpuCHK]"+true.ToString(),
                               "[cpu_dumping]5",
                               "[cpuCHK]"+true.ToString(),
                               "[ram_dumping]5",
                               "[ramCHK]"+true.ToString()};
        /// <summary>
        /// 进程检查，同时只允许运行一个Pawn实例
        /// </summary>
        private void checkSumFrm()
        {
            Process[] processes = System.Diagnostics.Process.GetProcessesByName(Application.ProductName);
            if (processes.Length > 1)
            {
                MessageBox.Show("应用程序已经在运行中!");
                Thread.Sleep(1000);
                System.Environment.Exit(1);
            }

        }
        private void mainForm_Load(object sender, EventArgs e)
        {
            //启动检查设置时间
            timer1.Interval = 15000;
            timer1.Enabled = true;
            timer1.Start();
            timer1.Tick += new System.EventHandler(this.timer1_Tick);

            timer2.Interval = 5000;
            timer2.Enabled = true;
            timer2.Start();

            notifyIcon1.Visible = false;
            timeCBB.Text = timeCBB.Items[0].ToString();
            gpuCBB.Text = gpuCBB.Items[0].ToString();
            cpuCBB.Text = cpuCBB.Items[0].ToString();
            memoryCBB.Text = memoryCBB.Items[0].ToString();
            this.Text = TILE + Application.ProductVersion.ToString();

            string[] pcInfo = hardwareInfo();
            cpuUsage();
            ramUsage();
            try
            {
                gpuUsage();
            }
            catch (Exception ex)
            {
                MessageBox.Show("无法处理你的GPU!\r\n"+ex.ToString());
            }
            cpuvisLBL.Text = pcInfo[0];
            gpuvisLBL.Text = pcInfo[1];
            macidvisLBL.Text = pcInfo[2];
            hdvisLBL.Text = pcInfo[3];
            ipvisLBL.Text = pcInfo[4];
            osvisLBL.Text = pcInfo[5] + "\r\n(" + Environment.OSVersion.ToString() + ")";
            memoryvisLBL.Text = (Math.Ceiling(Convert.ToDouble(pcInfo[6]) / (1024 * 1024))).ToString() + " MB";

            //读取cfgFile
            readCfg();
            readConfig();
        }
        /// <summary>
        /// 加载cfgFile
        /// </summary>
        private void readConfig()
        {
            List<string> newConfigL = new List<string>();
            if (!File.Exists(configFile))
            {
                File.WriteAllLines(configFile, configTxtA);
                newConfigL = configTxtA.ToList();
            }
            else
            {
                string[] configTxtA = File.ReadAllLines(configFile);
                newConfigL = configTxtA.ToList();
            }
            try
            {
                foreach (string line in newConfigL)
                {
                    if (line.Contains("access_key_id#"))
                        akiTB.Text = decClass.Decrypt(line.Split('#')[1].Trim(), "20170214", salt);
                    else if (line.Contains("access_key_secre#"))
                        aksTB.Text = decClass.Decrypt(line.Split('#')[1].Trim(), "20170214", salt);
                    else if (line.Contains("endpoint#"))
                        epTB.Text = line.Split('#')[1];
                    else if (line.Contains("cluster_id#"))
                        ciTB.Text = line.Split('#')[1];
                    else if (line.Contains("group_name#"))
                        gnTB.Text = line.Split('#')[1];
                    else if (line.Contains("max_item#"))
                        miTB.Text = line.Split('#')[1];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:错误的BCSinTask.config配置文件内容！\r\n" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// 加载cfgFile
        /// </summary>
        private void readCfg()
        {
            List<string> newCfgL = new List<string>();
            if (!File.Exists(cfgFile))
            {
                
                File.WriteAllLines(cfgFile, cfgTxtA);
                newCfgL=cfgTxtA.ToList();
                
            }
            else
            {
                string[] cfgTxtA = File.ReadAllLines(cfgFile);
                newCfgL=cfgTxtA.ToList();
            }
            
            try
            {
                freeDict = new Dictionary<string, string>();
                foreach(string line in newCfgL)
                {
                     if (line.Contains("[time]"))
                    {  
                        timeCBB.Text = line.Split(']')[1];
                        freeDict.Add(line.Split(']')[0].TrimStart('['), line.Split(']')[1]);
                    }
                     else if(line.Contains("[timeCHK]"))
                     {
                         timeCB.Checked = Convert.ToBoolean(line.Split(']')[1]);
                         freeDict.Add(line.Split(']')[0].TrimStart('['), line.Split(']')[1]);
                     }
                    else if (line.Contains("[gpu_dumping]"))
                    {
                        gpuCBB.Text = line.Split(']')[1];
                        freeDict.Add(line.Split(']')[0].TrimStart('['), line.Split(']')[1]);
                    }
                     else if (line.Contains("[gpuCHK]"))
                     {
                         gpuCK.Checked = Convert.ToBoolean(line.Split(']')[1]);
                         freeDict.Add(line.Split(']')[0].TrimStart('['), line.Split(']')[1]);
                     }
                    else if (line.Contains("[cpu_dumping]"))
                    {
                        cpuCBB.Text = line.Split(']')[1];
                        freeDict.Add(line.Split(']')[0].TrimStart('['), line.Split(']')[1]);
                    }
                     else if (line.Contains("[cpuCHK]"))
                     {
                         cpuCK.Checked = Convert.ToBoolean(line.Split(']')[1]);
                         freeDict.Add(line.Split(']')[0].TrimStart('['), line.Split(']')[1]);
                     }
                    else if (line.Contains("[ram_dumping]"))
                    {
                        memoryCBB.Text = line.Split(']')[1];
                        freeDict.Add(line.Split(']')[0].TrimStart('['), line.Split(']')[1]);
                    }
                     else if (line.Contains("[ramCHK]"))
                     {
                         memoryCK.Checked = Convert.ToBoolean(line.Split(']')[1]);
                         freeDict.Add(line.Split(']')[0].TrimStart('['), line.Split(']')[1]);
                     }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error:错误的Profix.cfg配置文件内容！\r\n" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// 从Computer类里抓取硬件信息
        /// </summary>
        /// <returns></returns>
        private string[] hardwareInfo()
        {
            List<string> machineInfo = new List<string> { };
            myPC = new Computer();
            machineInfo.Add(myPC.CpuID);
            string gpuID="";
            foreach(string id in myPC.GpuIDA)
            {
                gpuID+=id+",";
            }
            machineInfo.Add(gpuID.TrimEnd(','));
            string allMac = "";
            foreach (string mac in myPC.MacAddress)
            {
                allMac += mac + ",\r\n";
            }
            machineInfo.Add(allMac.TrimEnd(",\r\n".ToCharArray()));
            string allDisk = "";
            foreach (string disk in myPC.DiskID)
            {
                allDisk += disk + ",\r\n";
            }
            machineInfo.Add(allDisk.TrimEnd(",\r\n".ToCharArray()));
            string allIP = "";
            foreach (string ip in myPC.IpAddress)
            {
                allIP += ip + ",\r\n";
            }
            machineInfo.Add(allIP.TrimEnd(",\r\n".ToCharArray()));
            machineInfo.Add(myPC.SystemType);
            machineInfo.Add(myPC.TotalPhysicalMemory);

            //当前cfg文件
            Directory.SetCurrentDirectory(Directory.GetParent(locPath).FullName);
            string profix = charClass.splitName(myPC.ComputerName);
            if (!Directory.Exists(Directory.GetCurrentDirectory() + "\\cfg\\"))
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\cfg\\");
            cfgFile = Directory.GetCurrentDirectory() + "\\cfg\\"+profix+".cfg";

            return machineInfo.ToArray();
        }
        
        /// <summary>
        /// 得到系统CPU和内存占用信息
        /// </summary>
        /// <returns></returns>
        ///
        delegate void SetLabelTextDeleC(float value);
        delegate void SetLabelTextDeleG(float value);
        delegate void SetLabelTextDeleR(float value);
        private void ThreadForCpuView(object obj)
        {
            PerformanceCounter pcCpuLoad = (PerformanceCounter)obj;
            SetLabelTextDeleC setTextDele = new SetLabelTextDeleC(SetLabelTextC);
            while (true)
            {
                Thread.Sleep(1000);
                float cpuLoad = pcCpuLoad.NextValue();
                //label2.Text = cpuLoad + "%";
                cpuL.Invoke(setTextDele, new object[] { cpuLoad });
            }
        }
        private void ThreadForRamView(object obj)
        {
            PerformanceCounter pcRamLoad = (PerformanceCounter)obj;
            SetLabelTextDeleR setTextDele = new SetLabelTextDeleR(SetLabelTextR);
            while (true)
            {
                Thread.Sleep(2000);
                float ramLoad = pcRamLoad.NextValue();
                memoryL.Invoke(setTextDele, new object[] { ramLoad });
            }
        }
        private void ThreadForGpuView(object obj)
        {
            //PerformanceCounter pcRamLoad = (PerformanceCounter)obj;
            SetLabelTextDeleG setTextDele = new SetLabelTextDeleG(SetLabelTextG);
            while (true)
            {
                Thread.Sleep(2000);
                
             string[] xLineA = this.logTB.Text.Split('\n');
            if (xLineA.Length > 8)
            {
                try
                {
                    for(int i=xLineA.Length-2;i>0;i--)
                    {
                        if (xLineA[i] != "")
                        {
                            string[] smL = Regex.Split(xLineA[xLineA.Length - 2], "\\s+", RegexOptions.IgnoreCase);

                            //MessageBox.Show(smL[2]);
                            if (!charClass.isNumber(smL[2]))
                            {
                                float gpuLoad = (float)Convert.ToDouble(smL[2]);
                                gpuL.Invoke(setTextDele, new object[] { gpuLoad });
                            }
                            break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.ToString());
                }
            }
            
                
            }
        }
        private void SetLabelTextG(float value)
        {
            if (value != null)
            {
                gpuL.Text = Convert.ToInt16(value).ToString() + "%";
                gpuPB.Value = Convert.ToInt16(value);
                stateInfoClass.gpuZ = Convert.ToInt16(value);
            }
        }
        private void SetLabelTextC(float value)
        {
            if (value != null)
            {
                cpuL.Text = Convert.ToInt16(value).ToString() + "%";
                cpuPB.Value = Convert.ToInt16(value);
                stateInfoClass.cpuZ = Convert.ToInt16(value);
            }
        }
        private void SetLabelTextR(float value)
        {
            if (value != null)
            {
                memoryL.Text = Convert.ToInt16(value).ToString() + "%";
                memoryPB.Value = Convert.ToInt16(value);
                //得到内存占用
                stateInfoClass.ramZ = Convert.ToInt16(value);
            }
        }
        private void freeProc()
        {
            PerformanceCounter pcCpuLoad = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            pcCpuLoad.NextValue();
            //PerformanceCounter pcRamLoad = new PerformanceCounter("Memory", "% Committed Bytes In Use");
            //pcRamLoad.NextValue();
            ParameterizedThreadStart p = new ParameterizedThreadStart(ThreadForCpuView);
            cpuThread = new Thread(ThreadForCpuView);
            cpuThread.IsBackground = true;
            cpuThread.Start(pcCpuLoad);
        }
        private void gpuUsage()
        {
            cmdFile = "\"" + _nvsmiPath + "\" dmon -d 1 -s u";
            BackgroundWorker bw = new BackgroundWorker();
            bw.WorkerReportsProgress = true; // 设置可以通告进度
            bw.WorkerSupportsCancellation = true; // 设置可以取消

            bw.DoWork += new DoWorkEventHandler(doCmd);
            bw.ProgressChanged += new ProgressChangedEventHandler(bw_UpdateProgress);
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_RunWorkerCompleted);
            bw.RunWorkerAsync(cmdFile); //括号里加传递的参数
            ParameterizedThreadStart p = new ParameterizedThreadStart(ThreadForGpuView);
            gpuThread = new Thread(ThreadForGpuView);
            gpuThread.IsBackground = true;
            gpuThread.Start();
        }
        private void cpuUsage()
        {
            PerformanceCounter pcCpuLoad = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            pcCpuLoad.NextValue();
            //PerformanceCounter pcRamLoad = new PerformanceCounter("Memory", "% Committed Bytes In Use");
            //pcRamLoad.NextValue();
            ParameterizedThreadStart p = new ParameterizedThreadStart(ThreadForCpuView);
            cpuThread = new Thread(ThreadForCpuView);
            cpuThread.IsBackground = true;
            cpuThread.Start(pcCpuLoad);
        }
        private void ramUsage()
        {
            PerformanceCounter pcRamLoad = new PerformanceCounter("Memory", "% Committed Bytes In Use");
            pcRamLoad.NextValue();
            ParameterizedThreadStart a = new ParameterizedThreadStart(ThreadForRamView);
            ramThread = new Thread(ThreadForRamView);
            ramThread.IsBackground = true;
            ramThread.Start(pcRamLoad);
        }

        /// <summary>
        /// 点击最小化时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mainForm_MinimumSizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal && this.Visible == true)
            {

                this.notifyIcon1.Visible = true;//在通知区显示Form的Icon

                this.WindowState = FormWindowState.Minimized;

                this.Hide();

                this.ShowInTaskbar = false;//使Form不在任务栏上显示

            }
        }

        /// <summary>
        /// 点击关闭时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)//当用户点击窗体右上角X按钮或(Alt + F4)时 发生          
            {
                e.Cancel = true;
                this.WindowState = FormWindowState.Minimized;
                this.ShowInTaskbar = false;
                this.Hide();
                this.notifyIcon1.Visible = true;
            }
        }

       

        private void killThread()
        {
            try
            {
                ramThread.Abort();
                cpuThread.Abort();
                //gpuThread.Abort();
            }
            catch (Exception ex)
            {
                Application.Exit();
            }
        }
        
        private void exitBTN_Click(object sender, EventArgs e)
        {
            killThread();
            Application.Exit();
        }
        /// <summary>
        /// 运行命令
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void doCmd(object sender, DoWorkEventArgs e)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.WorkingDirectory = @"c:\windows\system32";
            p.StartInfo.UseShellExecute = false;    //是否使用操作系统shell启动
            p.StartInfo.RedirectStandardInput = true;//接受来自调用程序的输入信息
            p.StartInfo.RedirectStandardOutput = true;//由调用程序获取输出信息
            p.StartInfo.RedirectStandardError = true;//重定向标准错误输出
            p.StartInfo.CreateNoWindow = true;//不显示程序窗口

            //Process p = CreateProcess(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "cmd.exe"), dir);
            //向cmd窗口发送输入信息
            string cmdfile = e.Argument.ToString();
            //p.StandardInput.WriteLine(killcmd + "\r\n");
            //p.StandardInput.WriteLine(cmdfile);
            //p.StartInfo.Arguments = "/c " +cmdfile;
            p.Start();//启动程序
            //p.StandardInput.WriteLine("cd /d %programfiles%\\autodesk\\maya2016\\bin");
            p.StandardInput.WriteLine(cmdfile);
            //p.StandardInput.AutoFlush = true;
            p.OutputDataReceived += new DataReceivedEventHandler(OnDataReceived);
            p.ErrorDataReceived += new DataReceivedEventHandler(OnErrorReceived);
            //p.StandardInput.WriteLine("exit\r\n");
            p.BeginErrorReadLine();
            p.BeginOutputReadLine();
            p.WaitForExit();//等待程序执行完退出进程

            p.Close();

            e.Result = result;

        }
        /// <summary>
        /// 抓取输出的错误
        /// </summary>
        /// <param name="Sender"></param>
        /// <param name="e"></param>
        private void OnErrorReceived(object Sender, DataReceivedEventArgs e)
        {

            if (e.Data != null)
            {
                result.Append(e.Data.ToString() + "\r\n");
            }
            if (logTB.InvokeRequired)
            {


                try
                {
                    // 当一个控件的InvokeRequired属性值为真时，说明有一个创建它以外的线程想访问它
                    //string[] logL = this.logTB.Text.Split('\n');
                    Action<string> actionDelegate = (x) =>
                    {
                        string xStr = "";
                        string[] xStrL = x.ToString().Split('\n');
                        if (xStrL.Length > 300)
                        {

                            string str = "";
                            for (int i = xStrL.Length - 300; i < xStrL.Length; i++)
                            {
                                str = xStrL[i];
                                xStr += str + "\n";
                            }

                        }
                        else
                            xStr = x.ToString();
                        this.logTB.Text = xStr;
                    };
                    // 或者
                    // Action<string> actionDelegate = delegate(string txt) { this.label2.Text = txt; };
                    string[] zStrL = result.ToString().Split('\n');
                    string zStr = "";
                    if (zStrL.Length > 300)
                    {

                        string str = "";
                        for (int i = zStrL.Length-300; i < zStrL.Length; i++)
                        {
                            str = zStrL[i];
                            zStr += str + "\n";
                        }
                    }
                    else
                        zStr = result.ToString();
                    this.logTB.BeginInvoke(actionDelegate, zStr);
                }
                catch (Exception ex)
                {

                }
            }
            else
            {
                // 当一个控件的InvokeRequired属性值为真时，说明有一个创建它以外的线程想访问它
                Action<string> actionDelegate = (x) => { this.logTB.Text = x.ToString(); };
                // 或者
                // Action<string> actionDelegate = delegate(string txt) { this.label2.Text = txt; };
                this.logTB.BeginInvoke(actionDelegate, result.ToString());
            }

        }

        /// <summary>
        /// 抓取输出信息
        /// </summary>
        /// <param name="Sender"></param>
        /// <param name="e"></param>
        private void OnDataReceived(object Sender, DataReceivedEventArgs e)
        {

            if (e.Data != null)
            {
                result.Append(e.Data.ToString() + "\r\n");
            }
            if (logTB.InvokeRequired)
            {
                try
                {
                    // 当一个控件的InvokeRequired属性值为真时，说明有一个创建它以外的线程想访问它
                    Action<string> actionDelegate = (x) =>
                    {
                        string xStr = "";
                        string[] xStrL = x.ToString().Split('\n');
                        if (xStrL.Length > 300)
                        {

                            string str = "";
                            for (int i = xStrL.Length-300; i < xStrL.Length; i++)
                            {
                                str = xStrL[i];
                                xStr += str + "\n";
                            }

                        }
                        else
                            xStr = x.ToString();
                        this.logTB.Text = xStr;
                    };
                    // 或者
                    // Action<string> actionDelegate = delegate(string txt) { this.label2.Text = txt; };
                    string[] zStrL = result.ToString().Split('\n');
                    string zStr = "";

                    if (zStrL.Length > 300)
                    {

                        string str = "";
                        for (int i = zStrL.Length-300; i < zStrL.Length; i++)
                        {
                            str = zStrL[i];
                            zStr += str + "\n";
                        }
                    }
                    else
                        zStr = result.ToString();
                    this.logTB.BeginInvoke(actionDelegate, zStr);
                    
                }
                catch (Exception ex)
                {

                }
                
            }
            else
            {
                this.logTB.Text = result.ToString();
                string[] xLineA = this.logTB.Text.Split('\n');
                MessageBox.Show(xLineA[0]);
            }
        }

        /// <summary>
        /// 升级时，写log
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bw_UpdateProgress(object sender, ProgressChangedEventArgs e)
        {
            string key = string.Empty;
            string value = string.Empty;
            foreach (KeyValuePair<string, string> nPair in logDict)
            {
                key = nPair.Key;
                value = nPair.Value;
            }
            //if (File.Exists(value))
            {
                File.WriteAllText(value, result.ToString());
            }
        }

        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //这时后台线程已经完成，并返回了主线程，所以可以直接使用UI控件了 
            //this.infoTB.Text = e.Result.ToString();
            string key = string.Empty;
            string value = string.Empty;
            foreach (KeyValuePair<string, string> nPair in logDict)
            {
                key = nPair.Key;
                value = nPair.Value;
            }
            if (File.Exists(value))
                File.AppendAllText(value, result.ToString());
            else
                File.WriteAllText(value, result.ToString());
            if (File.Exists(key))
                File.AppendAllText(key, result.ToString());
            else
                File.Copy(value, key);
            if (logTB.InvokeRequired)
            {
                Action<string> actionDelegate = (x) => { this.logTB.Text = x.ToString(); };
                this.logTB.BeginInvoke(actionDelegate, string.Empty);
            }
            else
            {
                this.logTB.Text = string.Empty;
            }
            result = new StringBuilder();


            // 解锁更新检查锁
            lock (LockObject)
            {
                CheckUpDateLock = 0;
            }

        }
        /*
        private void logTB_TextChanged(object sender, EventArgs e)
        {
            string[] xLineA = this.logTB.Text.Split('\n');
            if (xLineA.Length > 8)
            {
                try
                {
                    for(int i=xLineA.Length-2;i>0;i--)
                    {
                        if (xLineA[i] != "")
                        {
                            string[] smL = Regex.Split(xLineA[xLineA.Length - 2], "\\s+", RegexOptions.IgnoreCase);

                            //MessageBox.Show(smL[2]);
                            if (!charClass.isNumber(smL[2]))
                            {
                                SetLabelTextG((float)Convert.ToDouble(smL[2]));
                            }
                            break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.ToString());
                }
            }
            
        }
        */
        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                notifyCMS.Show();
            }
        }
        private void showTSMI_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.notifyIcon1.Visible = false;
        }
        private void aboutTSMI_Click(object sender, EventArgs e)
        {
            AboutBox abt = new AboutBox();
            abt.ShowDialog();
        }
        private void exitTSMI_Click(object sender, EventArgs e)
        {
            killThread();
            Application.Exit();
        }
        /// <summary>
        /// 点击任务栏菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void notifyMenuCMS_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == notifyCMS.Items[0])
            {
                showTSMI_Click(sender, e);
            }
            else if (e.ClickedItem == notifyCMS.Items[1])
            {
                aboutTSMI_Click(sender, e);
            }
            else if (e.ClickedItem == notifyCMS.Items[2])
            {
                exitTSMI_Click(sender, e);
            }

        }

        private void aboutBTN_Click(object sender, EventArgs e)
        {
            aboutTSMI_Click(sender, e);
        }
        /// <summary>
        /// 保存参数到cfg文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void applyBTN_Click(object sender, EventArgs e)
        {
            if (akiTB.Text == "1111111111111111")
            {
                MessageBox.Show("Error:access_key_id填写错误！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (aksTB.Text == "000000000000000000000000000000")
            {
                MessageBox.Show("Error:access_key_secret填写错误！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //configFile
            checkArg();
            string[] configTxtA = { "access_key_id#"+decClass.Encrypt(akiTB.Text, "20170214", salt),
                               "access_key_secret#"+decClass.Encrypt(aksTB.Text, "20170214", salt),
                               "endpoint#"+epTB.Text,
                               "cluster_id#"+ciTB.Text,
                               "group_name#"+gnTB.Text,
                               "max_item#"+miTB.Text};
            File.WriteAllLines(configFile, configTxtA);
            //cfgFile
            List<string> newCfgL = new List<string>();
            if(!timeCB.Checked)
            {
                DialogResult result=MessageBox.Show("是否取消所有当前集群下的实例的延时释放？","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if(result==DialogResult.Yes)
                {
                    cfgTxtA = new string[] { "[time]" + timeCBB.Text, 
                        "[timeCHK]" +timeCB.Checked.ToString(), 
                        "[gpu_dumping]" + gpuCBB.Text,
                        "[gpuCHK]" + gpuCK.Checked.ToString(), 
                        "[cpu_dumping]" + cpuCBB.Text, 
                        "[cpuCHK]" + cpuCK.Checked.ToString(),
                        "[ram_dumping]" + memoryCBB.Text ,
                        "[ramCHK]" + memoryCK.Checked.ToString()};
                    File.WriteAllLines(cfgFile, cfgTxtA);
                    return;
                }
                else
                {
                    return;
                }
            }
            
            foreach(string line in cfgTxtA)
            {
                if (line.Contains("[time]"))
                    newCfgL.Add("[time]" + timeCBB.Text.ToString());
                else if (line.Contains("[timeCHK]"))
                    newCfgL.Add("[timeCHK]" + timeCB.Checked.ToString());
                else if (line.Contains("[gpu_dumping]"))
                    newCfgL.Add("[gpu_dumping]" + gpuCBB.Text.ToString());
                else if (line.Contains("[gpuCHK]"))
                    newCfgL.Add("[gpuCHK]" + gpuCK.Checked.ToString());
                else if (line.Contains("[cpu_dumping]") && cpuCK.Checked)
                    newCfgL.Add("[cpu_dumping]" + cpuCBB.Text.ToString());
                else if (line.Contains("[cpuCHK]"))
                    newCfgL.Add("[cpuCHK]" + cpuCK.Checked.ToString());
                else if (line.Contains("[ram_dumping]") && memoryCK.Checked)
                    newCfgL.Add("[ram_dumping]" + memoryCBB.Text.ToString());
                else if (line.Contains("[ramCHK]"))
                    newCfgL.Add("[ramCHK]" + memoryCK.Checked.ToString());
            }
            try
            {

                File.WriteAllLines(cfgFile, newCfgL);
                MessageBox.Show("Information:设置已经保存！", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                freeDict = new Dictionary<string, string>();
                foreach (string line in newCfgL)
                {
                    freeDict.Add(line.Split(']')[0].TrimStart('['), line.Split(']')[1]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:设置保存失败！\r\n"+ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        /// <summary>
        /// 检查执行的参数
        /// </summary>
        /// <returns></returns>
        private bool checkArg()
        {
            if (!ciTB.Text.Contains("cls-") || ciTB.Text=="")
            {
                MessageBox.Show("Error:Cluster id填写错误！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (charClass.isLegalNumber(gnTB.Text) || gnTB.Text == "")
            {
                MessageBox.Show("Error:Group Name填写错误！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (charClass.isNumber(miTB.Text) || miTB.Text == "")
            {
                MessageBox.Show("Error:Max Items填写错误！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (charClass.isLegalNumber(akiTB.Text) || akiTB.Text == "")
            {
                MessageBox.Show("Error:access_key_id填写错误！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (charClass.isLegalNumber(aksTB.Text) || aksTB.Text == "")
            {
                MessageBox.Show("Error:access_key_secret填写错误！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!epTB.Text.Contains("CN_") || epTB.Text == "")
            {
                MessageBox.Show("Error:End Point填写错误！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        /// <summary>
        /// 点击马上释放当前实例
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void destroyBTN_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("是否立即释放当前实例？", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (!checkArg())
                {
                    return;
                }
                if (akiTB.Text == "1111111111111111" )
                {
                    MessageBox.Show("Error:access_key_id填写错误！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if ( aksTB.Text == "000000000000000000000000000000")
                {
                    MessageBox.Show("Error:access_key_secret填写错误！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                cmdFile = "\"X:\\TD\\new\\production\\studio\\tools\\Python27\\python\" " + pyFile + 
                    " -c="+ciTB.Text + " -g="+gnTB.Text + " -m="+miTB.Text + " -k="+akiTB.Text + " -s="+aksTB.Text + " -e="+epTB.Text;
                //MessageBox.Show(cmdFile);
                BackgroundWorker bw = new BackgroundWorker();
                bw.WorkerReportsProgress = true; // 设置可以通告进度
                bw.WorkerSupportsCancellation = true; // 设置可以取消

                bw.DoWork += new DoWorkEventHandler(doCmd);
                bw.ProgressChanged += new ProgressChangedEventHandler(bw_UpdateProgress);
                bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_RunWorkerCompleted);
                bw.RunWorkerAsync(cmdFile); //括号里加传递的参数
                return;
            }
            else
            {
                return;
            }
        }
        private void timer1_Tick(object sender,EventArgs e)
        {
            readCfg();
        }
        /// <summary>
        /// 检查设置文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer2_Tick(object sender, EventArgs e)
        {
            //logTB_TextChanged(sender, e);
            //1.读取并加载设置
            Dictionary<string,string> oldArgDict =freeDict;
            //readCfg();
            //2.对比原参数
            bool sum=false;
            if (oldArgDict.Count() == freeDict.Count())
            {
                foreach (KeyValuePair<string, string> item in freeDict)
                {
                    if (item.Value == oldArgDict[item.Key])
                    {
                        sum = true;
                    }
                    else
                    {
                        sum = false;
                        break;
                    }
                }
            }
            if(!sum)
            {
                checkArgL = new List<bool>();
            }
            //3.每5秒检查一次，所以一分钟12次
            if (freeDict["timeCHK"]=="True")
            {
                int vTimes = Convert.ToInt32(freeDict["time"]) * 12;
                checkArgL.Add(checkFreeArg());
                if (checkArgL.Count() > vTimes)
                {
                    int count = 0;
                    foreach (bool info in checkArgL)
                    {
                        if (!info)
                            count++;
                    }
                    if (count < 3)
                        disposeIns();

                    checkArgL = new List<bool>();
                }
            }

        }
        private void disposeIns()
        {
            cmdFile = "\"X:\\TD\\new\\production\\studio\\tools\\Python27\\python\" " + pyFile +
                    " -c=" + ciTB.Text + " -g=" + gnTB.Text + " -m=" + miTB.Text + " -k=" + akiTB.Text + " -s=" + aksTB.Text + " -e=" + epTB.Text;
            BackgroundWorker bw = new BackgroundWorker();
            bw.WorkerReportsProgress = true; // 设置可以通告进度
            bw.WorkerSupportsCancellation = true; // 设置可以取消

            bw.DoWork += new DoWorkEventHandler(doCmd);
            bw.ProgressChanged += new ProgressChangedEventHandler(bw_UpdateProgress);
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_RunWorkerCompleted);
            bw.RunWorkerAsync(cmdFile); //括号里加传递的参数
            return;
        }

        private bool checkFreeArg()
        {
            int cpuArg = cpuPB.Value;
            int gpuArg = gpuPB.Value;
            int ramArg = memoryPB.Value;
            foreach(KeyValuePair<string,string> item in freeDict)
            {
                if(item.Key == "cpu_dumping" && freeDict["cpuCHK"]=="True")
                {
                    if(cpuArg > Convert.ToInt32(item.Value))
                        return false;
                }
                if (item.Key == "gpu_dumping" && freeDict["gpuCHK"] == "True")
                {
                    if(gpuArg > Convert.ToInt32(item.Value))
                        return false;
                }
                if (item.Key == "ram_dumping" && freeDict["ramCHK"] == "True")
                {
                    if (ramArg > Convert.ToInt32(item.Value))
                        return false;
                }
            }
            return true;
        }

        private void eyeBTN_MouseDown(object sender, MouseEventArgs e)
        {
            /*三种方法都可以
            this.textBox1.PasswordChar = new char();
            this.textBox1.PasswordChar = '\0';
            this.textBox1.PasswordChar = default(char);
             */
            akiTB.PasswordChar = '\0';
            aksTB.PasswordChar = '\0';
        }

        private void eyeBTN_MouseUp(object sender, MouseEventArgs e)
        {
            akiTB.PasswordChar = '#';
            aksTB.PasswordChar = '*';
        }
    }
}
