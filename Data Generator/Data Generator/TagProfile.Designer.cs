namespace Data_Generator
{
    partial class TagProfile
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpBoxTagProfile = new System.Windows.Forms.GroupBox();
            this.btnCreateTag = new System.Windows.Forms.Button();
            this.grpboxServerTagInfo = new System.Windows.Forms.GroupBox();
            this.lblTagName = new System.Windows.Forms.Label();
            this.lblTagType = new System.Windows.Forms.Label();
            this.lblServerName = new System.Windows.Forms.Label();
            this.comboxServerName = new System.Windows.Forms.ComboBox();
            this.comboxTagType = new System.Windows.Forms.ComboBox();
            this.txtboxTagName = new System.Windows.Forms.TextBox();
            this.grbboxTagData = new System.Windows.Forms.GroupBox();
            this.chkboxDataRandom = new System.Windows.Forms.CheckBox();
            this.lblTagData = new System.Windows.Forms.Label();
            this.numDataUpperLimit = new System.Windows.Forms.NumericUpDown();
            this.num_fixed = new System.Windows.Forms.NumericUpDown();
            this.btnStop = new System.Windows.Forms.Button();
            this.grpBoxDeviation = new System.Windows.Forms.GroupBox();
            this.rdoButtonNegPos = new System.Windows.Forms.RadioButton();
            this.numDevPercUpperLimit = new System.Windows.Forms.NumericUpDown();
            this.chkboxDevPercRandom = new System.Windows.Forms.CheckBox();
            this.numDevFrequencyUpperLimit = new System.Windows.Forms.NumericUpDown();
            this.chkboxDevFrequencyRandom = new System.Windows.Forms.CheckBox();
            this.lblPercChange = new System.Windows.Forms.Label();
            this.numDevPerc = new System.Windows.Forms.NumericUpDown();
            this.lblDevFrequency = new System.Windows.Forms.Label();
            this.numDevFrequency = new System.Windows.Forms.NumericUpDown();
            this.btnStart = new System.Windows.Forms.Button();
            this.grbboxTiming = new System.Windows.Forms.GroupBox();
            this.lblTimeStart = new System.Windows.Forms.Label();
            this.numTimeEndSec = new System.Windows.Forms.NumericUpDown();
            this.numTimeEndMin = new System.Windows.Forms.NumericUpDown();
            this.numTimeEndHr = new System.Windows.Forms.NumericUpDown();
            this.numTimeStartMin = new System.Windows.Forms.NumericUpDown();
            this.numTimeStartHr = new System.Windows.Forms.NumericUpDown();
            this.chkboxTimeRandom = new System.Windows.Forms.CheckBox();
            this.numTimeStartSec = new System.Windows.Forms.NumericUpDown();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.grpBoxTagProfile.SuspendLayout();
            this.grpboxServerTagInfo.SuspendLayout();
            this.grbboxTagData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDataUpperLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_fixed)).BeginInit();
            this.grpBoxDeviation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDevPercUpperLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDevFrequencyUpperLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDevPerc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDevFrequency)).BeginInit();
            this.grbboxTiming.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeEndSec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeEndMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeEndHr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeStartMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeStartHr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeStartSec)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBoxTagProfile
            // 
            this.grpBoxTagProfile.Controls.Add(this.btnCreateTag);
            this.grpBoxTagProfile.Controls.Add(this.grpboxServerTagInfo);
            this.grpBoxTagProfile.Controls.Add(this.grbboxTagData);
            this.grpBoxTagProfile.Controls.Add(this.btnStop);
            this.grpBoxTagProfile.Controls.Add(this.grpBoxDeviation);
            this.grpBoxTagProfile.Controls.Add(this.btnStart);
            this.grpBoxTagProfile.Controls.Add(this.grbboxTiming);
            this.grpBoxTagProfile.Location = new System.Drawing.Point(4, 4);
            this.grpBoxTagProfile.Margin = new System.Windows.Forms.Padding(4);
            this.grpBoxTagProfile.Name = "grpBoxTagProfile";
            this.grpBoxTagProfile.Padding = new System.Windows.Forms.Padding(4);
            this.grpBoxTagProfile.Size = new System.Drawing.Size(717, 592);
            this.grpBoxTagProfile.TabIndex = 19;
            this.grpBoxTagProfile.TabStop = false;
            this.grpBoxTagProfile.Text = "Tag Profile";
            this.grpBoxTagProfile.Enter += new System.EventHandler(this.grpBoxTagProfile_Enter);
            // 
            // btnCreateTag
            // 
            this.btnCreateTag.Location = new System.Drawing.Point(145, 537);
            this.btnCreateTag.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateTag.Name = "btnCreateTag";
            this.btnCreateTag.Size = new System.Drawing.Size(175, 35);
            this.btnCreateTag.TabIndex = 17;
            this.btnCreateTag.Text = "Create Tag";
            this.btnCreateTag.UseVisualStyleBackColor = true;
            this.btnCreateTag.Click += new System.EventHandler(this.button1_Click);
            // 
            // grpboxServerTagInfo
            // 
            this.grpboxServerTagInfo.Controls.Add(this.lblTagName);
            this.grpboxServerTagInfo.Controls.Add(this.lblTagType);
            this.grpboxServerTagInfo.Controls.Add(this.lblServerName);
            this.grpboxServerTagInfo.Controls.Add(this.comboxServerName);
            this.grpboxServerTagInfo.Controls.Add(this.comboxTagType);
            this.grpboxServerTagInfo.Controls.Add(this.txtboxTagName);
            this.grpboxServerTagInfo.Location = new System.Drawing.Point(24, 23);
            this.grpboxServerTagInfo.Margin = new System.Windows.Forms.Padding(4);
            this.grpboxServerTagInfo.Name = "grpboxServerTagInfo";
            this.grpboxServerTagInfo.Padding = new System.Windows.Forms.Padding(4);
            this.grpboxServerTagInfo.Size = new System.Drawing.Size(670, 140);
            this.grpboxServerTagInfo.TabIndex = 8;
            this.grpboxServerTagInfo.TabStop = false;
            this.grpboxServerTagInfo.Text = "Server and Tag Info";
            this.grpboxServerTagInfo.Enter += new System.EventHandler(this.grpboxServerTagInfo_Enter);
            // 
            // lblTagName
            // 
            this.lblTagName.AutoSize = true;
            this.lblTagName.Location = new System.Drawing.Point(17, 97);
            this.lblTagName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTagName.Name = "lblTagName";
            this.lblTagName.Size = new System.Drawing.Size(82, 17);
            this.lblTagName.TabIndex = 5;
            this.lblTagName.Text = "Tag Name";
            // 
            // lblTagType
            // 
            this.lblTagType.AutoSize = true;
            this.lblTagType.Location = new System.Drawing.Point(17, 64);
            this.lblTagType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTagType.Name = "lblTagType";
            this.lblTagType.Size = new System.Drawing.Size(77, 17);
            this.lblTagType.TabIndex = 4;
            this.lblTagType.Text = "Tag Type";
            // 
            // lblServerName
            // 
            this.lblServerName.AutoSize = true;
            this.lblServerName.Location = new System.Drawing.Point(17, 31);
            this.lblServerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServerName.Name = "lblServerName";
            this.lblServerName.Size = new System.Drawing.Size(102, 17);
            this.lblServerName.TabIndex = 3;
            this.lblServerName.Text = "Server Name";
            // 
            // comboxServerName
            // 
            this.comboxServerName.FormattingEnabled = true;
            this.comboxServerName.Items.AddRange(new object[] {
            "Server 1",
            "Server 2"});
            this.comboxServerName.Location = new System.Drawing.Point(183, 27);
            this.comboxServerName.Margin = new System.Windows.Forms.Padding(4);
            this.comboxServerName.Name = "comboxServerName";
            this.comboxServerName.Size = new System.Drawing.Size(196, 24);
            this.comboxServerName.TabIndex = 0;
            this.comboxServerName.Text = "Select Server";
            // 
            // comboxTagType
            // 
            this.comboxTagType.FormattingEnabled = true;
            this.comboxTagType.Items.AddRange(new object[] {
            "Float",
            "String"});
            this.comboxTagType.Location = new System.Drawing.Point(183, 60);
            this.comboxTagType.Margin = new System.Windows.Forms.Padding(4);
            this.comboxTagType.Name = "comboxTagType";
            this.comboxTagType.Size = new System.Drawing.Size(196, 24);
            this.comboxTagType.TabIndex = 1;
            this.comboxTagType.Text = "Tag Type";
            this.comboxTagType.SelectedIndexChanged += new System.EventHandler(this.comboxTagType_SelectedIndexChanged);
            // 
            // txtboxTagName
            // 
            this.txtboxTagName.Location = new System.Drawing.Point(183, 94);
            this.txtboxTagName.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxTagName.Name = "txtboxTagName";
            this.txtboxTagName.Size = new System.Drawing.Size(196, 22);
            this.txtboxTagName.TabIndex = 2;
            this.txtboxTagName.TextChanged += new System.EventHandler(this.txtboxTagName_TextChanged);
            // 
            // grbboxTagData
            // 
            this.grbboxTagData.Controls.Add(this.chkboxDataRandom);
            this.grbboxTagData.Controls.Add(this.radioButton4);
            this.grbboxTagData.Controls.Add(this.lblTagData);
            this.grbboxTagData.Controls.Add(this.numDataUpperLimit);
            this.grbboxTagData.Controls.Add(this.radioButton1);
            this.grbboxTagData.Controls.Add(this.num_fixed);
            this.grbboxTagData.Controls.Add(this.rdoButtonNegPos);
            this.grbboxTagData.Location = new System.Drawing.Point(24, 171);
            this.grbboxTagData.Margin = new System.Windows.Forms.Padding(4);
            this.grbboxTagData.Name = "grbboxTagData";
            this.grbboxTagData.Padding = new System.Windows.Forms.Padding(4);
            this.grbboxTagData.Size = new System.Drawing.Size(670, 112);
            this.grbboxTagData.TabIndex = 10;
            this.grbboxTagData.TabStop = false;
            this.grbboxTagData.Text = "Data";
            // 
            // chkboxDataRandom
            // 
            this.chkboxDataRandom.AutoSize = true;
            this.chkboxDataRandom.Location = new System.Drawing.Point(366, 35);
            this.chkboxDataRandom.Margin = new System.Windows.Forms.Padding(4);
            this.chkboxDataRandom.Name = "chkboxDataRandom";
            this.chkboxDataRandom.Size = new System.Drawing.Size(89, 21);
            this.chkboxDataRandom.TabIndex = 14;
            this.chkboxDataRandom.Text = "Random";
            this.chkboxDataRandom.UseVisualStyleBackColor = true;
            this.chkboxDataRandom.CheckedChanged += new System.EventHandler(this.chkboxDataRandom_CheckedChanged);
            // 
            // lblTagData
            // 
            this.lblTagData.AutoSize = true;
            this.lblTagData.Location = new System.Drawing.Point(19, 40);
            this.lblTagData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTagData.Name = "lblTagData";
            this.lblTagData.Size = new System.Drawing.Size(42, 17);
            this.lblTagData.TabIndex = 5;
            this.lblTagData.Text = "Data";
            // 
            // numDataUpperLimit
            // 
            this.numDataUpperLimit.Location = new System.Drawing.Point(492, 35);
            this.numDataUpperLimit.Margin = new System.Windows.Forms.Padding(4);
            this.numDataUpperLimit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDataUpperLimit.Name = "numDataUpperLimit";
            this.numDataUpperLimit.Size = new System.Drawing.Size(127, 22);
            this.numDataUpperLimit.TabIndex = 13;
            this.numDataUpperLimit.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // num_fixed
            // 
            this.num_fixed.Location = new System.Drawing.Point(183, 35);
            this.num_fixed.Margin = new System.Windows.Forms.Padding(4);
            this.num_fixed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_fixed.Name = "num_fixed";
            this.num_fixed.Size = new System.Drawing.Size(127, 22);
            this.num_fixed.TabIndex = 12;
            this.num_fixed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(410, 537);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(175, 35);
            this.btnStop.TabIndex = 13;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // grpBoxDeviation
            // 
            this.grpBoxDeviation.Controls.Add(this.radioButton5);
            this.grpBoxDeviation.Controls.Add(this.radioButton2);
            this.grpBoxDeviation.Controls.Add(this.radioButton3);
            this.grpBoxDeviation.Controls.Add(this.numDevPercUpperLimit);
            this.grpBoxDeviation.Controls.Add(this.chkboxDevPercRandom);
            this.grpBoxDeviation.Controls.Add(this.numDevFrequencyUpperLimit);
            this.grpBoxDeviation.Controls.Add(this.chkboxDevFrequencyRandom);
            this.grpBoxDeviation.Controls.Add(this.lblPercChange);
            this.grpBoxDeviation.Controls.Add(this.numDevPerc);
            this.grpBoxDeviation.Controls.Add(this.lblDevFrequency);
            this.grpBoxDeviation.Controls.Add(this.numDevFrequency);
            this.grpBoxDeviation.Location = new System.Drawing.Point(24, 291);
            this.grpBoxDeviation.Margin = new System.Windows.Forms.Padding(4);
            this.grpBoxDeviation.Name = "grpBoxDeviation";
            this.grpBoxDeviation.Padding = new System.Windows.Forms.Padding(4);
            this.grpBoxDeviation.Size = new System.Drawing.Size(670, 139);
            this.grpBoxDeviation.TabIndex = 11;
            this.grpBoxDeviation.TabStop = false;
            this.grpBoxDeviation.Text = "Deviation";
            // 
            // rdoButtonNegPos
            // 
            this.rdoButtonNegPos.AutoSize = true;
            this.rdoButtonNegPos.Location = new System.Drawing.Point(121, 74);
            this.rdoButtonNegPos.Margin = new System.Windows.Forms.Padding(4);
            this.rdoButtonNegPos.Name = "rdoButtonNegPos";
            this.rdoButtonNegPos.Size = new System.Drawing.Size(93, 21);
            this.rdoButtonNegPos.TabIndex = 21;
            this.rdoButtonNegPos.Text = "Negative";
            this.rdoButtonNegPos.UseVisualStyleBackColor = true;
            this.rdoButtonNegPos.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // numDevPercUpperLimit
            // 
            this.numDevPercUpperLimit.Location = new System.Drawing.Point(492, 68);
            this.numDevPercUpperLimit.Margin = new System.Windows.Forms.Padding(4);
            this.numDevPercUpperLimit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDevPercUpperLimit.Name = "numDevPercUpperLimit";
            this.numDevPercUpperLimit.Size = new System.Drawing.Size(127, 22);
            this.numDevPercUpperLimit.TabIndex = 19;
            this.numDevPercUpperLimit.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // chkboxDevPercRandom
            // 
            this.chkboxDevPercRandom.AutoSize = true;
            this.chkboxDevPercRandom.Location = new System.Drawing.Point(366, 70);
            this.chkboxDevPercRandom.Margin = new System.Windows.Forms.Padding(4);
            this.chkboxDevPercRandom.Name = "chkboxDevPercRandom";
            this.chkboxDevPercRandom.Size = new System.Drawing.Size(89, 21);
            this.chkboxDevPercRandom.TabIndex = 18;
            this.chkboxDevPercRandom.Text = "Random";
            this.chkboxDevPercRandom.UseVisualStyleBackColor = true;
            this.chkboxDevPercRandom.CheckedChanged += new System.EventHandler(this.chkboxDevPercRandom_CheckedChanged);
            // 
            // numDevFrequencyUpperLimit
            // 
            this.numDevFrequencyUpperLimit.Location = new System.Drawing.Point(492, 28);
            this.numDevFrequencyUpperLimit.Margin = new System.Windows.Forms.Padding(4);
            this.numDevFrequencyUpperLimit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDevFrequencyUpperLimit.Name = "numDevFrequencyUpperLimit";
            this.numDevFrequencyUpperLimit.Size = new System.Drawing.Size(127, 22);
            this.numDevFrequencyUpperLimit.TabIndex = 17;
            this.numDevFrequencyUpperLimit.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // chkboxDevFrequencyRandom
            // 
            this.chkboxDevFrequencyRandom.AutoSize = true;
            this.chkboxDevFrequencyRandom.Location = new System.Drawing.Point(366, 28);
            this.chkboxDevFrequencyRandom.Margin = new System.Windows.Forms.Padding(4);
            this.chkboxDevFrequencyRandom.Name = "chkboxDevFrequencyRandom";
            this.chkboxDevFrequencyRandom.Size = new System.Drawing.Size(89, 21);
            this.chkboxDevFrequencyRandom.TabIndex = 16;
            this.chkboxDevFrequencyRandom.Text = "Random";
            this.chkboxDevFrequencyRandom.UseVisualStyleBackColor = true;
            this.chkboxDevFrequencyRandom.CheckedChanged += new System.EventHandler(this.chkboxDevFrequencyRandom_CheckedChanged);
            // 
            // lblPercChange
            // 
            this.lblPercChange.AutoSize = true;
            this.lblPercChange.Location = new System.Drawing.Point(21, 70);
            this.lblPercChange.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPercChange.Name = "lblPercChange";
            this.lblPercChange.Size = new System.Drawing.Size(81, 17);
            this.lblPercChange.TabIndex = 3;
            this.lblPercChange.Text = "% Change";
            // 
            // numDevPerc
            // 
            this.numDevPerc.Location = new System.Drawing.Point(185, 68);
            this.numDevPerc.Margin = new System.Windows.Forms.Padding(4);
            this.numDevPerc.Name = "numDevPerc";
            this.numDevPerc.Size = new System.Drawing.Size(127, 22);
            this.numDevPerc.TabIndex = 15;
            // 
            // lblDevFrequency
            // 
            this.lblDevFrequency.AutoSize = true;
            this.lblDevFrequency.Location = new System.Drawing.Point(19, 31);
            this.lblDevFrequency.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDevFrequency.Name = "lblDevFrequency";
            this.lblDevFrequency.Size = new System.Drawing.Size(157, 17);
            this.lblDevFrequency.TabIndex = 1;
            this.lblDevFrequency.Text = "Deviation Frequency";
            // 
            // numDevFrequency
            // 
            this.numDevFrequency.Location = new System.Drawing.Point(185, 28);
            this.numDevFrequency.Margin = new System.Windows.Forms.Padding(4);
            this.numDevFrequency.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDevFrequency.Name = "numDevFrequency";
            this.numDevFrequency.Size = new System.Drawing.Size(127, 22);
            this.numDevFrequency.TabIndex = 14;
            this.numDevFrequency.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(410, 537);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(175, 35);
            this.btnStart.TabIndex = 16;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // grbboxTiming
            // 
            this.grbboxTiming.Controls.Add(this.lblTimeStart);
            this.grbboxTiming.Controls.Add(this.numTimeEndSec);
            this.grbboxTiming.Controls.Add(this.numTimeEndMin);
            this.grbboxTiming.Controls.Add(this.numTimeEndHr);
            this.grbboxTiming.Controls.Add(this.numTimeStartMin);
            this.grbboxTiming.Controls.Add(this.numTimeStartHr);
            this.grbboxTiming.Controls.Add(this.chkboxTimeRandom);
            this.grbboxTiming.Controls.Add(this.numTimeStartSec);
            this.grbboxTiming.Location = new System.Drawing.Point(24, 438);
            this.grbboxTiming.Margin = new System.Windows.Forms.Padding(4);
            this.grbboxTiming.Name = "grbboxTiming";
            this.grbboxTiming.Padding = new System.Windows.Forms.Padding(4);
            this.grbboxTiming.Size = new System.Drawing.Size(670, 77);
            this.grbboxTiming.TabIndex = 9;
            this.grbboxTiming.TabStop = false;
            this.grbboxTiming.Text = "Timing";
            // 
            // lblTimeStart
            // 
            this.lblTimeStart.AutoSize = true;
            this.lblTimeStart.Location = new System.Drawing.Point(19, 39);
            this.lblTimeStart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimeStart.Name = "lblTimeStart";
            this.lblTimeStart.Size = new System.Drawing.Size(43, 17);
            this.lblTimeStart.TabIndex = 11;
            this.lblTimeStart.Text = "Time";
            // 
            // numTimeEndSec
            // 
            this.numTimeEndSec.Location = new System.Drawing.Point(603, 33);
            this.numTimeEndSec.Margin = new System.Windows.Forms.Padding(4);
            this.numTimeEndSec.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numTimeEndSec.Name = "numTimeEndSec";
            this.numTimeEndSec.Size = new System.Drawing.Size(50, 22);
            this.numTimeEndSec.TabIndex = 9;
            // 
            // numTimeEndMin
            // 
            this.numTimeEndMin.Location = new System.Drawing.Point(544, 34);
            this.numTimeEndMin.Margin = new System.Windows.Forms.Padding(4);
            this.numTimeEndMin.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numTimeEndMin.Name = "numTimeEndMin";
            this.numTimeEndMin.Size = new System.Drawing.Size(50, 22);
            this.numTimeEndMin.TabIndex = 8;
            // 
            // numTimeEndHr
            // 
            this.numTimeEndHr.Location = new System.Drawing.Point(484, 34);
            this.numTimeEndHr.Margin = new System.Windows.Forms.Padding(4);
            this.numTimeEndHr.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numTimeEndHr.Name = "numTimeEndHr";
            this.numTimeEndHr.Size = new System.Drawing.Size(50, 22);
            this.numTimeEndHr.TabIndex = 7;
            // 
            // numTimeStartMin
            // 
            this.numTimeStartMin.Location = new System.Drawing.Point(204, 35);
            this.numTimeStartMin.Margin = new System.Windows.Forms.Padding(4);
            this.numTimeStartMin.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numTimeStartMin.Name = "numTimeStartMin";
            this.numTimeStartMin.Size = new System.Drawing.Size(50, 22);
            this.numTimeStartMin.TabIndex = 4;
            // 
            // numTimeStartHr
            // 
            this.numTimeStartHr.Location = new System.Drawing.Point(145, 35);
            this.numTimeStartHr.Margin = new System.Windows.Forms.Padding(4);
            this.numTimeStartHr.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numTimeStartHr.Name = "numTimeStartHr";
            this.numTimeStartHr.Size = new System.Drawing.Size(50, 22);
            this.numTimeStartHr.TabIndex = 3;
            // 
            // chkboxTimeRandom
            // 
            this.chkboxTimeRandom.AutoSize = true;
            this.chkboxTimeRandom.Location = new System.Drawing.Point(366, 34);
            this.chkboxTimeRandom.Margin = new System.Windows.Forms.Padding(4);
            this.chkboxTimeRandom.Name = "chkboxTimeRandom";
            this.chkboxTimeRandom.Size = new System.Drawing.Size(89, 21);
            this.chkboxTimeRandom.TabIndex = 7;
            this.chkboxTimeRandom.Text = "Random";
            this.chkboxTimeRandom.UseVisualStyleBackColor = true;
            this.chkboxTimeRandom.CheckedChanged += new System.EventHandler(this.chkboxTimeRandom_CheckedChanged);
            // 
            // numTimeStartSec
            // 
            this.numTimeStartSec.Location = new System.Drawing.Point(264, 35);
            this.numTimeStartSec.Margin = new System.Windows.Forms.Padding(4);
            this.numTimeStartSec.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numTimeStartSec.Name = "numTimeStartSec";
            this.numTimeStartSec.Size = new System.Drawing.Size(50, 22);
            this.numTimeStartSec.TabIndex = 5;
            this.numTimeStartSec.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(22, 74);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(91, 21);
            this.radioButton1.TabIndex = 22;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Posative";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(24, 103);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(91, 21);
            this.radioButton2.TabIndex = 25;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Posative";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(125, 103);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(93, 21);
            this.radioButton3.TabIndex = 24;
            this.radioButton3.Text = "Negative";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(222, 74);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(88, 21);
            this.radioButton4.TabIndex = 26;
            this.radioButton4.Text = "Random";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(226, 103);
            this.radioButton5.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(88, 21);
            this.radioButton5.TabIndex = 27;
            this.radioButton5.Text = "Random";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // TagProfile
            // 
            this.AccessibleName = "TestJoe";
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpBoxTagProfile);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TagProfile";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Size = new System.Drawing.Size(725, 596);
            this.Load += new System.EventHandler(this.TagProfile_Load);
            this.grpBoxTagProfile.ResumeLayout(false);
            this.grpboxServerTagInfo.ResumeLayout(false);
            this.grpboxServerTagInfo.PerformLayout();
            this.grbboxTagData.ResumeLayout(false);
            this.grbboxTagData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDataUpperLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_fixed)).EndInit();
            this.grpBoxDeviation.ResumeLayout(false);
            this.grpBoxDeviation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDevPercUpperLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDevFrequencyUpperLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDevPerc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDevFrequency)).EndInit();
            this.grbboxTiming.ResumeLayout(false);
            this.grbboxTiming.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeEndSec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeEndMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeEndHr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeStartMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeStartHr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeStartSec)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxTagProfile;
        private System.Windows.Forms.Button btnCreateTag;
        private System.Windows.Forms.GroupBox grpboxServerTagInfo;
        private System.Windows.Forms.Label lblTagName;
        private System.Windows.Forms.Label lblTagType;
        private System.Windows.Forms.Label lblServerName;
        private System.Windows.Forms.ComboBox comboxServerName;
        private System.Windows.Forms.ComboBox comboxTagType;
        private System.Windows.Forms.TextBox txtboxTagName;
        private System.Windows.Forms.GroupBox grbboxTagData;
        private System.Windows.Forms.CheckBox chkboxDataRandom;
        private System.Windows.Forms.Label lblTagData;
        private System.Windows.Forms.NumericUpDown numDataUpperLimit;
        private System.Windows.Forms.NumericUpDown num_fixed;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.GroupBox grpBoxDeviation;
        private System.Windows.Forms.NumericUpDown numDevPercUpperLimit;
        private System.Windows.Forms.CheckBox chkboxDevPercRandom;
        private System.Windows.Forms.NumericUpDown numDevFrequencyUpperLimit;
        private System.Windows.Forms.CheckBox chkboxDevFrequencyRandom;
        private System.Windows.Forms.Label lblPercChange;
        private System.Windows.Forms.NumericUpDown numDevPerc;
        private System.Windows.Forms.Label lblDevFrequency;
        private System.Windows.Forms.NumericUpDown numDevFrequency;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox grbboxTiming;
        private System.Windows.Forms.Label lblTimeStart;
        private System.Windows.Forms.NumericUpDown numTimeEndSec;
        private System.Windows.Forms.NumericUpDown numTimeEndMin;
        private System.Windows.Forms.NumericUpDown numTimeEndHr;
        private System.Windows.Forms.NumericUpDown numTimeStartMin;
        private System.Windows.Forms.NumericUpDown numTimeStartHr;
        private System.Windows.Forms.CheckBox chkboxTimeRandom;
        private System.Windows.Forms.NumericUpDown numTimeStartSec;
        private System.Windows.Forms.RadioButton rdoButtonNegPos;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}
