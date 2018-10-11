namespace BCSinTask
{
    partial class mainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.optTLP = new System.Windows.Forms.TableLayoutPanel();
            this.timeCB = new System.Windows.Forms.CheckBox();
            this.timeCBB = new System.Windows.Forms.ComboBox();
            this.mintuesLBL = new System.Windows.Forms.Label();
            this.memoryCK = new System.Windows.Forms.CheckBox();
            this.memoryCBB = new System.Windows.Forms.ComboBox();
            this.memoryLBL = new System.Windows.Forms.Label();
            this.cpuCBB = new System.Windows.Forms.ComboBox();
            this.cpuCK = new System.Windows.Forms.CheckBox();
            this.cpuLBL = new System.Windows.Forms.Label();
            this.gpuCK = new System.Windows.Forms.CheckBox();
            this.gpuCBB = new System.Windows.Forms.ComboBox();
            this.gpuLBL = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.destroyBTN = new System.Windows.Forms.Button();
            this.exitBTN = new System.Windows.Forms.Button();
            this.applyBTN = new System.Windows.Forms.Button();
            this.logTB = new System.Windows.Forms.TextBox();
            this.informationLBL = new System.Windows.Forms.Label();
            this.aboutBTN = new System.Windows.Forms.Button();
            this.akiLBL = new System.Windows.Forms.Label();
            this.aksLBL = new System.Windows.Forms.Label();
            this.epLBL = new System.Windows.Forms.Label();
            this.ciLBL = new System.Windows.Forms.Label();
            this.gnLBL = new System.Windows.Forms.Label();
            this.miLBL = new System.Windows.Forms.Label();
            this.akiTB = new System.Windows.Forms.TextBox();
            this.aksTB = new System.Windows.Forms.TextBox();
            this.epTB = new System.Windows.Forms.TextBox();
            this.ciTB = new System.Windows.Forms.TextBox();
            this.gnTB = new System.Windows.Forms.TextBox();
            this.miTB = new System.Windows.Forms.TextBox();
            this.eyeBTN = new System.Windows.Forms.Button();
            this.mainTC = new System.Windows.Forms.TabControl();
            this.nodeTP = new System.Windows.Forms.TabPage();
            this.slaveTLP = new System.Windows.Forms.TableLayoutPanel();
            this.gpuL = new System.Windows.Forms.Label();
            this.gpuPB = new System.Windows.Forms.ProgressBar();
            this.memoryPB = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.hdLBL = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ipLBL = new System.Windows.Forms.Label();
            this.macLBL = new System.Windows.Forms.Label();
            this.osLBL = new System.Windows.Forms.Label();
            this.rendererLBL = new System.Windows.Forms.Label();
            this.cpuusageLBL = new System.Windows.Forms.Label();
            this.memoryusageLBL = new System.Windows.Forms.Label();
            this.cpuvisLBL = new System.Windows.Forms.Label();
            this.gpuvisLBL = new System.Windows.Forms.Label();
            this.memoryvisLBL = new System.Windows.Forms.Label();
            this.ipvisLBL = new System.Windows.Forms.Label();
            this.macidvisLBL = new System.Windows.Forms.Label();
            this.osvisLBL = new System.Windows.Forms.Label();
            this.hdvisLBL = new System.Windows.Forms.Label();
            this.cpuL = new System.Windows.Forms.Label();
            this.memoryL = new System.Windows.Forms.Label();
            this.renderervisTB = new System.Windows.Forms.TextBox();
            this.cpuPB = new System.Windows.Forms.ProgressBar();
            this.gpuusageLBL = new System.Windows.Forms.Label();
            this.optionTP = new System.Windows.Forms.TabPage();
            this.mainTLP = new System.Windows.Forms.TableLayoutPanel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyCMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.exitTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.optTLP.SuspendLayout();
            this.mainTC.SuspendLayout();
            this.nodeTP.SuspendLayout();
            this.slaveTLP.SuspendLayout();
            this.optionTP.SuspendLayout();
            this.mainTLP.SuspendLayout();
            this.notifyCMS.SuspendLayout();
            this.SuspendLayout();
            // 
            // optTLP
            // 
            this.optTLP.BackColor = System.Drawing.SystemColors.ControlLight;
            this.optTLP.ColumnCount = 8;
            this.optTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.optTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.optTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.optTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.optTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.optTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.optTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.optTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.optTLP.Controls.Add(this.timeCB, 1, 7);
            this.optTLP.Controls.Add(this.timeCBB, 2, 7);
            this.optTLP.Controls.Add(this.mintuesLBL, 3, 7);
            this.optTLP.Controls.Add(this.memoryCK, 1, 11);
            this.optTLP.Controls.Add(this.memoryCBB, 2, 11);
            this.optTLP.Controls.Add(this.memoryLBL, 3, 11);
            this.optTLP.Controls.Add(this.cpuCBB, 2, 10);
            this.optTLP.Controls.Add(this.cpuCK, 1, 10);
            this.optTLP.Controls.Add(this.cpuLBL, 3, 10);
            this.optTLP.Controls.Add(this.gpuCK, 1, 9);
            this.optTLP.Controls.Add(this.gpuCBB, 2, 9);
            this.optTLP.Controls.Add(this.gpuLBL, 3, 9);
            this.optTLP.Controls.Add(this.label2, 1, 8);
            this.optTLP.Controls.Add(this.label1, 1, 6);
            this.optTLP.Controls.Add(this.destroyBTN, 1, 14);
            this.optTLP.Controls.Add(this.exitBTN, 6, 14);
            this.optTLP.Controls.Add(this.applyBTN, 5, 14);
            this.optTLP.Controls.Add(this.logTB, 1, 13);
            this.optTLP.Controls.Add(this.informationLBL, 1, 12);
            this.optTLP.Controls.Add(this.aboutBTN, 6, 12);
            this.optTLP.Controls.Add(this.akiLBL, 1, 1);
            this.optTLP.Controls.Add(this.aksLBL, 1, 2);
            this.optTLP.Controls.Add(this.epLBL, 1, 3);
            this.optTLP.Controls.Add(this.ciLBL, 1, 4);
            this.optTLP.Controls.Add(this.gnLBL, 1, 5);
            this.optTLP.Controls.Add(this.miLBL, 5, 3);
            this.optTLP.Controls.Add(this.akiTB, 2, 1);
            this.optTLP.Controls.Add(this.aksTB, 2, 2);
            this.optTLP.Controls.Add(this.epTB, 2, 3);
            this.optTLP.Controls.Add(this.ciTB, 2, 4);
            this.optTLP.Controls.Add(this.gnTB, 2, 5);
            this.optTLP.Controls.Add(this.miTB, 6, 3);
            this.optTLP.Controls.Add(this.eyeBTN, 6, 1);
            this.optTLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optTLP.Location = new System.Drawing.Point(3, 3);
            this.optTLP.Name = "optTLP";
            this.optTLP.RowCount = 16;
            this.optTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.optTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.optTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.optTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.optTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.optTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.optTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.optTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.optTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.optTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.optTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.optTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.optTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.optTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.optTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.optTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.optTLP.Size = new System.Drawing.Size(408, 567);
            this.optTLP.TabIndex = 0;
            // 
            // timeCB
            // 
            this.timeCB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.timeCB.AutoSize = true;
            this.timeCB.Checked = true;
            this.timeCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.timeCB.Location = new System.Drawing.Point(15, 192);
            this.timeCB.Name = "timeCB";
            this.timeCB.Size = new System.Drawing.Size(108, 16);
            this.timeCB.TabIndex = 1;
            this.timeCB.Text = "Disposed After";
            this.timeCB.UseVisualStyleBackColor = true;
            // 
            // timeCBB
            // 
            this.timeCBB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.timeCBB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.timeCBB.FormattingEnabled = true;
            this.timeCBB.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "40",
            "45",
            "50",
            "55",
            "59"});
            this.timeCBB.Location = new System.Drawing.Point(131, 190);
            this.timeCBB.Name = "timeCBB";
            this.timeCBB.Size = new System.Drawing.Size(51, 20);
            this.timeCBB.TabIndex = 2;
            // 
            // mintuesLBL
            // 
            this.mintuesLBL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mintuesLBL.AutoSize = true;
            this.mintuesLBL.Location = new System.Drawing.Point(196, 194);
            this.mintuesLBL.Name = "mintuesLBL";
            this.mintuesLBL.Size = new System.Drawing.Size(47, 12);
            this.mintuesLBL.TabIndex = 3;
            this.mintuesLBL.Text = "mintues";
            // 
            // memoryCK
            // 
            this.memoryCK.AutoSize = true;
            this.memoryCK.Checked = true;
            this.memoryCK.CheckState = System.Windows.Forms.CheckState.Checked;
            this.memoryCK.Location = new System.Drawing.Point(15, 301);
            this.memoryCK.Name = "memoryCK";
            this.memoryCK.Size = new System.Drawing.Size(78, 16);
            this.memoryCK.TabIndex = 9;
            this.memoryCK.Text = "RAM Lower";
            this.memoryCK.UseVisualStyleBackColor = true;
            // 
            // memoryCBB
            // 
            this.memoryCBB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.memoryCBB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.memoryCBB.FormattingEnabled = true;
            this.memoryCBB.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "40",
            "50"});
            this.memoryCBB.Location = new System.Drawing.Point(131, 302);
            this.memoryCBB.Name = "memoryCBB";
            this.memoryCBB.Size = new System.Drawing.Size(51, 20);
            this.memoryCBB.TabIndex = 7;
            // 
            // memoryLBL
            // 
            this.memoryLBL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.memoryLBL.AutoSize = true;
            this.memoryLBL.Location = new System.Drawing.Point(196, 306);
            this.memoryLBL.Name = "memoryLBL";
            this.memoryLBL.Size = new System.Drawing.Size(11, 12);
            this.memoryLBL.TabIndex = 12;
            this.memoryLBL.Text = "%";
            // 
            // cpuCBB
            // 
            this.cpuCBB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cpuCBB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cpuCBB.FormattingEnabled = true;
            this.cpuCBB.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "40",
            "50"});
            this.cpuCBB.Location = new System.Drawing.Point(131, 274);
            this.cpuCBB.Name = "cpuCBB";
            this.cpuCBB.Size = new System.Drawing.Size(51, 20);
            this.cpuCBB.TabIndex = 6;
            // 
            // cpuCK
            // 
            this.cpuCK.AutoSize = true;
            this.cpuCK.Checked = true;
            this.cpuCK.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cpuCK.Location = new System.Drawing.Point(15, 273);
            this.cpuCK.Name = "cpuCK";
            this.cpuCK.Size = new System.Drawing.Size(78, 16);
            this.cpuCK.TabIndex = 8;
            this.cpuCK.Text = "CPU Lower";
            this.cpuCK.UseVisualStyleBackColor = true;
            // 
            // cpuLBL
            // 
            this.cpuLBL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cpuLBL.AutoSize = true;
            this.cpuLBL.Location = new System.Drawing.Point(196, 278);
            this.cpuLBL.Name = "cpuLBL";
            this.cpuLBL.Size = new System.Drawing.Size(11, 12);
            this.cpuLBL.TabIndex = 11;
            this.cpuLBL.Text = "%";
            // 
            // gpuCK
            // 
            this.gpuCK.AutoSize = true;
            this.gpuCK.Checked = true;
            this.gpuCK.CheckState = System.Windows.Forms.CheckState.Checked;
            this.gpuCK.Location = new System.Drawing.Point(15, 245);
            this.gpuCK.Name = "gpuCK";
            this.gpuCK.Size = new System.Drawing.Size(78, 16);
            this.gpuCK.TabIndex = 4;
            this.gpuCK.Text = "GPU Lower";
            this.gpuCK.UseVisualStyleBackColor = true;
            // 
            // gpuCBB
            // 
            this.gpuCBB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gpuCBB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gpuCBB.FormattingEnabled = true;
            this.gpuCBB.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "40",
            "50"});
            this.gpuCBB.Location = new System.Drawing.Point(131, 246);
            this.gpuCBB.Name = "gpuCBB";
            this.gpuCBB.Size = new System.Drawing.Size(51, 20);
            this.gpuCBB.TabIndex = 5;
            // 
            // gpuLBL
            // 
            this.gpuLBL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gpuLBL.AutoSize = true;
            this.gpuLBL.Location = new System.Drawing.Point(196, 250);
            this.gpuLBL.Name = "gpuLBL";
            this.gpuLBL.Size = new System.Drawing.Size(11, 12);
            this.gpuLBL.TabIndex = 10;
            this.gpuLBL.Text = "%";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.optTLP.SetColumnSpan(this.label2, 2);
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(15, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "达成以下全部条件：";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.optTLP.SetColumnSpan(this.label1, 2);
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(15, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "空闲多长时间，自动释放";
            // 
            // destroyBTN
            // 
            this.destroyBTN.Location = new System.Drawing.Point(15, 530);
            this.destroyBTN.Name = "destroyBTN";
            this.destroyBTN.Size = new System.Drawing.Size(75, 22);
            this.destroyBTN.TabIndex = 15;
            this.destroyBTN.Text = "Destroy";
            this.destroyBTN.UseVisualStyleBackColor = true;
            this.destroyBTN.Click += new System.EventHandler(this.destroyBTN_Click);
            // 
            // exitBTN
            // 
            this.exitBTN.Location = new System.Drawing.Point(319, 530);
            this.exitBTN.Name = "exitBTN";
            this.exitBTN.Size = new System.Drawing.Size(74, 22);
            this.exitBTN.TabIndex = 16;
            this.exitBTN.Text = "Exit";
            this.exitBTN.UseVisualStyleBackColor = true;
            this.exitBTN.Click += new System.EventHandler(this.exitBTN_Click);
            // 
            // applyBTN
            // 
            this.applyBTN.Location = new System.Drawing.Point(239, 530);
            this.applyBTN.Name = "applyBTN";
            this.applyBTN.Size = new System.Drawing.Size(74, 22);
            this.applyBTN.TabIndex = 17;
            this.applyBTN.Text = "Apply";
            this.applyBTN.UseVisualStyleBackColor = true;
            this.applyBTN.Click += new System.EventHandler(this.applyBTN_Click);
            // 
            // logTB
            // 
            this.logTB.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.optTLP.SetColumnSpan(this.logTB, 6);
            this.logTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logTB.Location = new System.Drawing.Point(15, 357);
            this.logTB.Multiline = true;
            this.logTB.Name = "logTB";
            this.logTB.ReadOnly = true;
            this.logTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logTB.Size = new System.Drawing.Size(378, 167);
            this.logTB.TabIndex = 18;
            // 
            // informationLBL
            // 
            this.informationLBL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.informationLBL.AutoSize = true;
            this.informationLBL.Location = new System.Drawing.Point(15, 342);
            this.informationLBL.Name = "informationLBL";
            this.informationLBL.Size = new System.Drawing.Size(77, 12);
            this.informationLBL.TabIndex = 19;
            this.informationLBL.Text = "Information:";
            // 
            // aboutBTN
            // 
            this.aboutBTN.Location = new System.Drawing.Point(319, 329);
            this.aboutBTN.Name = "aboutBTN";
            this.aboutBTN.Size = new System.Drawing.Size(74, 22);
            this.aboutBTN.TabIndex = 20;
            this.aboutBTN.Text = "About";
            this.aboutBTN.UseVisualStyleBackColor = true;
            this.aboutBTN.Click += new System.EventHandler(this.aboutBTN_Click);
            // 
            // akiLBL
            // 
            this.akiLBL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.akiLBL.AutoSize = true;
            this.akiLBL.Location = new System.Drawing.Point(15, 23);
            this.akiLBL.Name = "akiLBL";
            this.akiLBL.Size = new System.Drawing.Size(83, 12);
            this.akiLBL.TabIndex = 21;
            this.akiLBL.Text = "Access_key_id";
            // 
            // aksLBL
            // 
            this.aksLBL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.aksLBL.AutoSize = true;
            this.aksLBL.Location = new System.Drawing.Point(15, 54);
            this.aksLBL.Name = "aksLBL";
            this.aksLBL.Size = new System.Drawing.Size(107, 12);
            this.aksLBL.TabIndex = 22;
            this.aksLBL.Text = "Access_key_secret";
            // 
            // epLBL
            // 
            this.epLBL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.epLBL.AutoSize = true;
            this.epLBL.Location = new System.Drawing.Point(15, 82);
            this.epLBL.Name = "epLBL";
            this.epLBL.Size = new System.Drawing.Size(59, 12);
            this.epLBL.TabIndex = 23;
            this.epLBL.Text = "End point";
            // 
            // ciLBL
            // 
            this.ciLBL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ciLBL.AutoSize = true;
            this.ciLBL.Location = new System.Drawing.Point(15, 110);
            this.ciLBL.Name = "ciLBL";
            this.ciLBL.Size = new System.Drawing.Size(65, 12);
            this.ciLBL.TabIndex = 24;
            this.ciLBL.Text = "Cluster_id";
            // 
            // gnLBL
            // 
            this.gnLBL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gnLBL.AutoSize = true;
            this.gnLBL.Location = new System.Drawing.Point(15, 138);
            this.gnLBL.Name = "gnLBL";
            this.gnLBL.Size = new System.Drawing.Size(65, 12);
            this.gnLBL.TabIndex = 25;
            this.gnLBL.Text = "Group_name";
            // 
            // miLBL
            // 
            this.miLBL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.miLBL.AutoSize = true;
            this.miLBL.Location = new System.Drawing.Point(239, 82);
            this.miLBL.Name = "miLBL";
            this.miLBL.Size = new System.Drawing.Size(53, 12);
            this.miLBL.TabIndex = 26;
            this.miLBL.Text = "Max_item";
            // 
            // akiTB
            // 
            this.akiTB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.optTLP.SetColumnSpan(this.akiTB, 4);
            this.akiTB.Location = new System.Drawing.Point(131, 18);
            this.akiTB.Name = "akiTB";
            this.akiTB.PasswordChar = '#';
            this.akiTB.Size = new System.Drawing.Size(182, 21);
            this.akiTB.TabIndex = 27;
            this.akiTB.Text = "1111111111111111";
            // 
            // aksTB
            // 
            this.aksTB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.optTLP.SetColumnSpan(this.aksTB, 5);
            this.aksTB.Location = new System.Drawing.Point(131, 49);
            this.aksTB.Name = "aksTB";
            this.aksTB.PasswordChar = '*';
            this.aksTB.Size = new System.Drawing.Size(262, 21);
            this.aksTB.TabIndex = 28;
            this.aksTB.Text = "000000000000000000000000000000";
            // 
            // epTB
            // 
            this.epTB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.optTLP.SetColumnSpan(this.epTB, 2);
            this.epTB.Location = new System.Drawing.Point(131, 77);
            this.epTB.Name = "epTB";
            this.epTB.Size = new System.Drawing.Size(100, 21);
            this.epTB.TabIndex = 29;
            this.epTB.Text = "CN_BEIJING";
            // 
            // ciTB
            // 
            this.ciTB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.optTLP.SetColumnSpan(this.ciTB, 4);
            this.ciTB.Location = new System.Drawing.Point(131, 105);
            this.ciTB.Name = "ciTB";
            this.ciTB.Size = new System.Drawing.Size(182, 21);
            this.ciTB.TabIndex = 30;
            this.ciTB.Text = "cls-92ek97clnlncseeg8k800a";
            // 
            // gnTB
            // 
            this.gnTB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.optTLP.SetColumnSpan(this.gnTB, 2);
            this.gnTB.Location = new System.Drawing.Point(131, 133);
            this.gnTB.Name = "gnTB";
            this.gnTB.Size = new System.Drawing.Size(119, 21);
            this.gnTB.TabIndex = 31;
            this.gnTB.Text = "m16sp6rs2076y216E";
            // 
            // miTB
            // 
            this.miTB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.miTB.Location = new System.Drawing.Point(319, 77);
            this.miTB.Name = "miTB";
            this.miTB.Size = new System.Drawing.Size(74, 21);
            this.miTB.TabIndex = 32;
            this.miTB.Text = "100";
            // 
            // eyeBTN
            // 
            this.eyeBTN.Image = ((System.Drawing.Image)(resources.GetObject("eyeBTN.Image")));
            this.eyeBTN.Location = new System.Drawing.Point(319, 15);
            this.eyeBTN.Name = "eyeBTN";
            this.eyeBTN.Size = new System.Drawing.Size(32, 28);
            this.eyeBTN.TabIndex = 33;
            this.eyeBTN.UseVisualStyleBackColor = true;
            this.eyeBTN.MouseDown += new System.Windows.Forms.MouseEventHandler(this.eyeBTN_MouseDown);
            this.eyeBTN.MouseUp += new System.Windows.Forms.MouseEventHandler(this.eyeBTN_MouseUp);
            // 
            // mainTC
            // 
            this.mainTC.Controls.Add(this.nodeTP);
            this.mainTC.Controls.Add(this.optionTP);
            this.mainTC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTC.Location = new System.Drawing.Point(15, 15);
            this.mainTC.Name = "mainTC";
            this.mainTC.SelectedIndex = 0;
            this.mainTC.Size = new System.Drawing.Size(422, 599);
            this.mainTC.TabIndex = 1;
            // 
            // nodeTP
            // 
            this.nodeTP.BackColor = System.Drawing.SystemColors.ControlLight;
            this.nodeTP.Controls.Add(this.slaveTLP);
            this.nodeTP.Location = new System.Drawing.Point(4, 22);
            this.nodeTP.Name = "nodeTP";
            this.nodeTP.Padding = new System.Windows.Forms.Padding(3);
            this.nodeTP.Size = new System.Drawing.Size(414, 573);
            this.nodeTP.TabIndex = 0;
            this.nodeTP.Text = "Node Info";
            // 
            // slaveTLP
            // 
            this.slaveTLP.BackColor = System.Drawing.SystemColors.ControlLight;
            this.slaveTLP.ColumnCount = 3;
            this.slaveTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.slaveTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.slaveTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.slaveTLP.Controls.Add(this.gpuL, 2, 3);
            this.slaveTLP.Controls.Add(this.gpuPB, 1, 3);
            this.slaveTLP.Controls.Add(this.memoryPB, 1, 5);
            this.slaveTLP.Controls.Add(this.label3, 0, 0);
            this.slaveTLP.Controls.Add(this.hdLBL, 0, 11);
            this.slaveTLP.Controls.Add(this.label4, 0, 2);
            this.slaveTLP.Controls.Add(this.label5, 0, 4);
            this.slaveTLP.Controls.Add(this.ipLBL, 0, 6);
            this.slaveTLP.Controls.Add(this.macLBL, 0, 7);
            this.slaveTLP.Controls.Add(this.osLBL, 0, 8);
            this.slaveTLP.Controls.Add(this.rendererLBL, 0, 9);
            this.slaveTLP.Controls.Add(this.cpuusageLBL, 0, 1);
            this.slaveTLP.Controls.Add(this.memoryusageLBL, 0, 5);
            this.slaveTLP.Controls.Add(this.cpuvisLBL, 1, 0);
            this.slaveTLP.Controls.Add(this.gpuvisLBL, 1, 2);
            this.slaveTLP.Controls.Add(this.memoryvisLBL, 1, 4);
            this.slaveTLP.Controls.Add(this.ipvisLBL, 1, 6);
            this.slaveTLP.Controls.Add(this.macidvisLBL, 1, 7);
            this.slaveTLP.Controls.Add(this.osvisLBL, 1, 8);
            this.slaveTLP.Controls.Add(this.hdvisLBL, 1, 11);
            this.slaveTLP.Controls.Add(this.cpuL, 2, 1);
            this.slaveTLP.Controls.Add(this.memoryL, 2, 5);
            this.slaveTLP.Controls.Add(this.renderervisTB, 1, 9);
            this.slaveTLP.Controls.Add(this.cpuPB, 1, 1);
            this.slaveTLP.Controls.Add(this.gpuusageLBL, 0, 3);
            this.slaveTLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slaveTLP.Location = new System.Drawing.Point(3, 3);
            this.slaveTLP.Name = "slaveTLP";
            this.slaveTLP.RowCount = 12;
            this.slaveTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.slaveTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.slaveTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.slaveTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.slaveTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.slaveTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.slaveTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.slaveTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.slaveTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.slaveTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.slaveTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.slaveTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.slaveTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.slaveTLP.Size = new System.Drawing.Size(408, 567);
            this.slaveTLP.TabIndex = 1;
            // 
            // gpuL
            // 
            this.gpuL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.gpuL.AutoSize = true;
            this.gpuL.Location = new System.Drawing.Point(388, 92);
            this.gpuL.Name = "gpuL";
            this.gpuL.Size = new System.Drawing.Size(17, 12);
            this.gpuL.TabIndex = 25;
            this.gpuL.Text = "0%";
            // 
            // gpuPB
            // 
            this.gpuPB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gpuPB.Location = new System.Drawing.Point(123, 89);
            this.gpuPB.Name = "gpuPB";
            this.gpuPB.Size = new System.Drawing.Size(242, 18);
            this.gpuPB.TabIndex = 24;
            // 
            // memoryPB
            // 
            this.memoryPB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.memoryPB.Location = new System.Drawing.Point(123, 145);
            this.memoryPB.Name = "memoryPB";
            this.memoryPB.Size = new System.Drawing.Size(242, 18);
            this.memoryPB.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(3, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "CPU Info";
            // 
            // hdLBL
            // 
            this.hdLBL.AutoSize = true;
            this.hdLBL.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.hdLBL.Location = new System.Drawing.Point(3, 440);
            this.hdLBL.Name = "hdLBL";
            this.hdLBL.Size = new System.Drawing.Size(68, 12);
            this.hdLBL.TabIndex = 2;
            this.hdLBL.Text = "Hard Disk";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(3, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "GPU Info";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(3, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "Memory Info";
            // 
            // ipLBL
            // 
            this.ipLBL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ipLBL.AutoSize = true;
            this.ipLBL.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ipLBL.Location = new System.Drawing.Point(3, 196);
            this.ipLBL.Name = "ipLBL";
            this.ipLBL.Size = new System.Drawing.Size(75, 12);
            this.ipLBL.TabIndex = 3;
            this.ipLBL.Text = "IP Address";
            // 
            // macLBL
            // 
            this.macLBL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.macLBL.AutoSize = true;
            this.macLBL.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.macLBL.Location = new System.Drawing.Point(3, 264);
            this.macLBL.Name = "macLBL";
            this.macLBL.Size = new System.Drawing.Size(47, 12);
            this.macLBL.TabIndex = 4;
            this.macLBL.Text = "MAC ID";
            // 
            // osLBL
            // 
            this.osLBL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.osLBL.AutoSize = true;
            this.osLBL.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.osLBL.Location = new System.Drawing.Point(3, 316);
            this.osLBL.Name = "osLBL";
            this.osLBL.Size = new System.Drawing.Size(75, 24);
            this.osLBL.TabIndex = 5;
            this.osLBL.Text = "Operating System";
            // 
            // rendererLBL
            // 
            this.rendererLBL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rendererLBL.AutoSize = true;
            this.rendererLBL.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rendererLBL.Location = new System.Drawing.Point(3, 378);
            this.rendererLBL.Name = "rendererLBL";
            this.rendererLBL.Size = new System.Drawing.Size(68, 24);
            this.rendererLBL.TabIndex = 6;
            this.rendererLBL.Text = "Renderer Installed";
            // 
            // cpuusageLBL
            // 
            this.cpuusageLBL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cpuusageLBL.AutoSize = true;
            this.cpuusageLBL.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cpuusageLBL.Location = new System.Drawing.Point(3, 36);
            this.cpuusageLBL.Name = "cpuusageLBL";
            this.cpuusageLBL.Size = new System.Drawing.Size(68, 12);
            this.cpuusageLBL.TabIndex = 8;
            this.cpuusageLBL.Text = "CPU Usage";
            // 
            // memoryusageLBL
            // 
            this.memoryusageLBL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.memoryusageLBL.AutoSize = true;
            this.memoryusageLBL.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.memoryusageLBL.Location = new System.Drawing.Point(3, 148);
            this.memoryusageLBL.Name = "memoryusageLBL";
            this.memoryusageLBL.Size = new System.Drawing.Size(89, 12);
            this.memoryusageLBL.TabIndex = 9;
            this.memoryusageLBL.Text = "Memory Usage";
            // 
            // cpuvisLBL
            // 
            this.cpuvisLBL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cpuvisLBL.AutoSize = true;
            this.slaveTLP.SetColumnSpan(this.cpuvisLBL, 2);
            this.cpuvisLBL.Location = new System.Drawing.Point(123, 8);
            this.cpuvisLBL.Name = "cpuvisLBL";
            this.cpuvisLBL.Size = new System.Drawing.Size(41, 12);
            this.cpuvisLBL.TabIndex = 10;
            this.cpuvisLBL.Text = "label1";
            // 
            // gpuvisLBL
            // 
            this.gpuvisLBL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gpuvisLBL.AutoSize = true;
            this.slaveTLP.SetColumnSpan(this.gpuvisLBL, 2);
            this.gpuvisLBL.Location = new System.Drawing.Point(123, 64);
            this.gpuvisLBL.Name = "gpuvisLBL";
            this.gpuvisLBL.Size = new System.Drawing.Size(41, 12);
            this.gpuvisLBL.TabIndex = 11;
            this.gpuvisLBL.Text = "label1";
            // 
            // memoryvisLBL
            // 
            this.memoryvisLBL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.memoryvisLBL.AutoSize = true;
            this.slaveTLP.SetColumnSpan(this.memoryvisLBL, 2);
            this.memoryvisLBL.Location = new System.Drawing.Point(123, 120);
            this.memoryvisLBL.Name = "memoryvisLBL";
            this.memoryvisLBL.Size = new System.Drawing.Size(41, 12);
            this.memoryvisLBL.TabIndex = 12;
            this.memoryvisLBL.Text = "label1";
            // 
            // ipvisLBL
            // 
            this.ipvisLBL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ipvisLBL.AutoSize = true;
            this.slaveTLP.SetColumnSpan(this.ipvisLBL, 2);
            this.ipvisLBL.Location = new System.Drawing.Point(123, 196);
            this.ipvisLBL.Name = "ipvisLBL";
            this.ipvisLBL.Size = new System.Drawing.Size(41, 12);
            this.ipvisLBL.TabIndex = 13;
            this.ipvisLBL.Text = "label1";
            // 
            // macidvisLBL
            // 
            this.macidvisLBL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.macidvisLBL.AutoSize = true;
            this.slaveTLP.SetColumnSpan(this.macidvisLBL, 2);
            this.macidvisLBL.Location = new System.Drawing.Point(123, 264);
            this.macidvisLBL.Name = "macidvisLBL";
            this.macidvisLBL.Size = new System.Drawing.Size(41, 12);
            this.macidvisLBL.TabIndex = 14;
            this.macidvisLBL.Text = "label1";
            // 
            // osvisLBL
            // 
            this.osvisLBL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.osvisLBL.AutoSize = true;
            this.slaveTLP.SetColumnSpan(this.osvisLBL, 2);
            this.osvisLBL.Location = new System.Drawing.Point(123, 322);
            this.osvisLBL.Name = "osvisLBL";
            this.osvisLBL.Size = new System.Drawing.Size(41, 12);
            this.osvisLBL.TabIndex = 15;
            this.osvisLBL.Text = "label1";
            // 
            // hdvisLBL
            // 
            this.hdvisLBL.AutoSize = true;
            this.slaveTLP.SetColumnSpan(this.hdvisLBL, 2);
            this.hdvisLBL.Location = new System.Drawing.Point(123, 440);
            this.hdvisLBL.Name = "hdvisLBL";
            this.hdvisLBL.Size = new System.Drawing.Size(41, 12);
            this.hdvisLBL.TabIndex = 17;
            this.hdvisLBL.Text = "label1";
            // 
            // cpuL
            // 
            this.cpuL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cpuL.AutoSize = true;
            this.cpuL.Location = new System.Drawing.Point(388, 36);
            this.cpuL.Name = "cpuL";
            this.cpuL.Size = new System.Drawing.Size(17, 12);
            this.cpuL.TabIndex = 19;
            this.cpuL.Text = "0%";
            // 
            // memoryL
            // 
            this.memoryL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.memoryL.AutoSize = true;
            this.memoryL.Location = new System.Drawing.Point(388, 148);
            this.memoryL.Name = "memoryL";
            this.memoryL.Size = new System.Drawing.Size(17, 12);
            this.memoryL.TabIndex = 20;
            this.memoryL.Text = "0%";
            // 
            // renderervisTB
            // 
            this.renderervisTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.renderervisTB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.renderervisTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.slaveTLP.SetColumnSpan(this.renderervisTB, 2);
            this.renderervisTB.Location = new System.Drawing.Point(123, 355);
            this.renderervisTB.Multiline = true;
            this.renderervisTB.Name = "renderervisTB";
            this.renderervisTB.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.renderervisTB.Size = new System.Drawing.Size(282, 70);
            this.renderervisTB.TabIndex = 22;
            // 
            // cpuPB
            // 
            this.cpuPB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cpuPB.Location = new System.Drawing.Point(123, 33);
            this.cpuPB.Name = "cpuPB";
            this.cpuPB.Size = new System.Drawing.Size(242, 18);
            this.cpuPB.TabIndex = 18;
            // 
            // gpuusageLBL
            // 
            this.gpuusageLBL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gpuusageLBL.AutoSize = true;
            this.gpuusageLBL.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.gpuusageLBL.Location = new System.Drawing.Point(3, 92);
            this.gpuusageLBL.Name = "gpuusageLBL";
            this.gpuusageLBL.Size = new System.Drawing.Size(68, 12);
            this.gpuusageLBL.TabIndex = 23;
            this.gpuusageLBL.Text = "GPU Usage";
            // 
            // optionTP
            // 
            this.optionTP.BackColor = System.Drawing.SystemColors.ControlLight;
            this.optionTP.Controls.Add(this.optTLP);
            this.optionTP.Location = new System.Drawing.Point(4, 22);
            this.optionTP.Name = "optionTP";
            this.optionTP.Padding = new System.Windows.Forms.Padding(3);
            this.optionTP.Size = new System.Drawing.Size(414, 573);
            this.optionTP.TabIndex = 1;
            this.optionTP.Text = "Options";
            // 
            // mainTLP
            // 
            this.mainTLP.ColumnCount = 3;
            this.mainTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.mainTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.mainTLP.Controls.Add(this.mainTC, 1, 1);
            this.mainTLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTLP.Location = new System.Drawing.Point(0, 0);
            this.mainTLP.Name = "mainTLP";
            this.mainTLP.RowCount = 3;
            this.mainTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.mainTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.mainTLP.Size = new System.Drawing.Size(452, 629);
            this.mainTLP.TabIndex = 2;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "BCSinTask";
            this.notifyIcon1.ContextMenuStrip = this.notifyCMS;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "BCSinTask";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // notifyCMS
            // 
            this.notifyCMS.BackColor = System.Drawing.SystemColors.ControlLight;
            this.notifyCMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showTSMI,
            this.aboutTSMI,
            this.exitTSMI});
            this.notifyCMS.Name = "notifyMenuCMS";
            this.notifyCMS.Size = new System.Drawing.Size(176, 70);
            this.notifyCMS.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.notifyMenuCMS_ItemClicked);
            // 
            // showTSMI
            // 
            this.showTSMI.Image = ((System.Drawing.Image)(resources.GetObject("showTSMI.Image")));
            this.showTSMI.Name = "showTSMI";
            this.showTSMI.Size = new System.Drawing.Size(175, 22);
            this.showTSMI.Text = "Show BCSinTask";
            // 
            // aboutTSMI
            // 
            this.aboutTSMI.Image = ((System.Drawing.Image)(resources.GetObject("aboutTSMI.Image")));
            this.aboutTSMI.Name = "aboutTSMI";
            this.aboutTSMI.Size = new System.Drawing.Size(175, 22);
            this.aboutTSMI.Text = "About BCSinTask";
            // 
            // exitTSMI
            // 
            this.exitTSMI.Image = ((System.Drawing.Image)(resources.GetObject("exitTSMI.Image")));
            this.exitTSMI.Name = "exitTSMI";
            this.exitTSMI.Size = new System.Drawing.Size(175, 22);
            this.exitTSMI.Text = "Exit";
            // 
            // timer2
            // 
            this.timer2.Interval = 5000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(452, 629);
            this.Controls.Add(this.mainTLP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(468, 668);
            this.Name = "mainForm";
            this.Text = "BCS Dispose";
            this.MinimumSizeChanged += new System.EventHandler(this.mainForm_MinimumSizeChanged);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.optTLP.ResumeLayout(false);
            this.optTLP.PerformLayout();
            this.mainTC.ResumeLayout(false);
            this.nodeTP.ResumeLayout(false);
            this.slaveTLP.ResumeLayout(false);
            this.slaveTLP.PerformLayout();
            this.optionTP.ResumeLayout(false);
            this.mainTLP.ResumeLayout(false);
            this.notifyCMS.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel optTLP;
        private System.Windows.Forms.ComboBox gpuCBB;
        private System.Windows.Forms.CheckBox timeCB;
        private System.Windows.Forms.ComboBox timeCBB;
        private System.Windows.Forms.Label mintuesLBL;
        private System.Windows.Forms.CheckBox gpuCK;
        private System.Windows.Forms.ComboBox cpuCBB;
        private System.Windows.Forms.ComboBox memoryCBB;
        private System.Windows.Forms.CheckBox cpuCK;
        private System.Windows.Forms.CheckBox memoryCK;
        private System.Windows.Forms.Label gpuLBL;
        private System.Windows.Forms.Label cpuLBL;
        private System.Windows.Forms.Label memoryLBL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button destroyBTN;
        private System.Windows.Forms.Button exitBTN;
        private System.Windows.Forms.Button applyBTN;
        private System.Windows.Forms.TextBox logTB;
        private System.Windows.Forms.Label informationLBL;
        private System.Windows.Forms.TabControl mainTC;
        private System.Windows.Forms.TabPage nodeTP;
        private System.Windows.Forms.TableLayoutPanel slaveTLP;
        private System.Windows.Forms.ProgressBar memoryPB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label hdLBL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ipLBL;
        private System.Windows.Forms.Label macLBL;
        private System.Windows.Forms.Label osLBL;
        private System.Windows.Forms.Label rendererLBL;
        private System.Windows.Forms.Label cpuusageLBL;
        private System.Windows.Forms.Label memoryusageLBL;
        private System.Windows.Forms.Label cpuvisLBL;
        private System.Windows.Forms.Label gpuvisLBL;
        private System.Windows.Forms.Label memoryvisLBL;
        private System.Windows.Forms.Label ipvisLBL;
        private System.Windows.Forms.Label macidvisLBL;
        private System.Windows.Forms.Label osvisLBL;
        private System.Windows.Forms.Label hdvisLBL;
        private System.Windows.Forms.ProgressBar cpuPB;
        private System.Windows.Forms.Label cpuL;
        private System.Windows.Forms.Label memoryL;
        private System.Windows.Forms.TextBox renderervisTB;
        private System.Windows.Forms.TabPage optionTP;
        private System.Windows.Forms.TableLayoutPanel mainTLP;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip notifyCMS;
        private System.Windows.Forms.ToolStripMenuItem showTSMI;
        private System.Windows.Forms.ToolStripMenuItem exitTSMI;
        private System.Windows.Forms.Label gpuL;
        private System.Windows.Forms.ProgressBar gpuPB;
        private System.Windows.Forms.Label gpuusageLBL;
        private System.Windows.Forms.ToolStripMenuItem aboutTSMI;
        private System.Windows.Forms.Button aboutBTN;
        private System.Windows.Forms.Label akiLBL;
        private System.Windows.Forms.Label aksLBL;
        private System.Windows.Forms.Label epLBL;
        private System.Windows.Forms.Label ciLBL;
        private System.Windows.Forms.Label gnLBL;
        private System.Windows.Forms.Label miLBL;
        private System.Windows.Forms.TextBox akiTB;
        private System.Windows.Forms.TextBox aksTB;
        private System.Windows.Forms.TextBox epTB;
        private System.Windows.Forms.TextBox ciTB;
        private System.Windows.Forms.TextBox gnTB;
        private System.Windows.Forms.TextBox miTB;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button eyeBTN;
    }
}

