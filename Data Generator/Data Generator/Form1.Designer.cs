namespace Data_Generator
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dd_serverName = new System.Windows.Forms.ComboBox();
            this.dd_tagType = new System.Windows.Forms.ComboBox();
            this.tb_tagName = new System.Windows.Forms.TextBox();
            this.num_freq_hr = new System.Windows.Forms.NumericUpDown();
            this.num_freq_min = new System.Windows.Forms.NumericUpDown();
            this.num_freq_sec = new System.Windows.Forms.NumericUpDown();
            this.cb_freq_random = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lb_rand_time = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.num_freq_rand_sec = new System.Windows.Forms.NumericUpDown();
            this.num_freq_rand_min = new System.Windows.Forms.NumericUpDown();
            this.num_freq_rand_hr = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.num_rand = new System.Windows.Forms.NumericUpDown();
            this.rb_random = new System.Windows.Forms.RadioButton();
            this.rb_fixed = new System.Windows.Forms.RadioButton();
            this.num_fixed = new System.Windows.Forms.NumericUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.num_percentage = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.num_change = new System.Windows.Forms.NumericUpDown();
            this.bt_start = new System.Windows.Forms.Button();
            this.bt_stop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num_freq_hr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_freq_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_freq_sec)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_freq_rand_sec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_freq_rand_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_freq_rand_hr)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_rand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_fixed)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_percentage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_change)).BeginInit();
            this.SuspendLayout();
            // 
            // dd_serverName
            // 
            this.dd_serverName.FormattingEnabled = true;
            this.dd_serverName.Items.AddRange(new object[] {
            "Server 1",
            "Server 2"});
            this.dd_serverName.Location = new System.Drawing.Point(92, 19);
            this.dd_serverName.Name = "dd_serverName";
            this.dd_serverName.Size = new System.Drawing.Size(114, 21);
            this.dd_serverName.TabIndex = 0;
            this.dd_serverName.Text = "Select Server";
            this.dd_serverName.SelectedIndexChanged += new System.EventHandler(this.cb_serverName_SelectedIndexChanged);
            // 
            // dd_tagType
            // 
            this.dd_tagType.FormattingEnabled = true;
            this.dd_tagType.Items.AddRange(new object[] {
            "Float",
            "String"});
            this.dd_tagType.Location = new System.Drawing.Point(92, 46);
            this.dd_tagType.Name = "dd_tagType";
            this.dd_tagType.Size = new System.Drawing.Size(114, 21);
            this.dd_tagType.TabIndex = 1;
            this.dd_tagType.Text = "Tag Type";
            // 
            // tb_tagName
            // 
            this.tb_tagName.Location = new System.Drawing.Point(92, 73);
            this.tb_tagName.Name = "tb_tagName";
            this.tb_tagName.Size = new System.Drawing.Size(114, 20);
            this.tb_tagName.TabIndex = 2;
            // 
            // num_freq_hr
            // 
            this.num_freq_hr.Location = new System.Drawing.Point(95, 19);
            this.num_freq_hr.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.num_freq_hr.Name = "num_freq_hr";
            this.num_freq_hr.Size = new System.Drawing.Size(34, 20);
            this.num_freq_hr.TabIndex = 3;
            // 
            // num_freq_min
            // 
            this.num_freq_min.Location = new System.Drawing.Point(135, 19);
            this.num_freq_min.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.num_freq_min.Name = "num_freq_min";
            this.num_freq_min.Size = new System.Drawing.Size(34, 20);
            this.num_freq_min.TabIndex = 4;
            // 
            // num_freq_sec
            // 
            this.num_freq_sec.Location = new System.Drawing.Point(175, 19);
            this.num_freq_sec.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.num_freq_sec.Name = "num_freq_sec";
            this.num_freq_sec.Size = new System.Drawing.Size(34, 20);
            this.num_freq_sec.TabIndex = 5;
            // 
            // cb_freq_random
            // 
            this.cb_freq_random.AutoSize = true;
            this.cb_freq_random.Location = new System.Drawing.Point(95, 48);
            this.cb_freq_random.Name = "cb_freq_random";
            this.cb_freq_random.Size = new System.Drawing.Size(15, 14);
            this.cb_freq_random.TabIndex = 7;
            this.cb_freq_random.UseVisualStyleBackColor = true;
            this.cb_freq_random.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dd_serverName);
            this.groupBox1.Controls.Add(this.dd_tagType);
            this.groupBox1.Controls.Add(this.tb_tagName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 100);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server and Tag Info";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tag Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tag Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Server Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.lb_rand_time);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.num_freq_rand_sec);
            this.groupBox2.Controls.Add(this.num_freq_rand_min);
            this.groupBox2.Controls.Add(this.num_freq_rand_hr);
            this.groupBox2.Controls.Add(this.num_freq_min);
            this.groupBox2.Controls.Add(this.num_freq_hr);
            this.groupBox2.Controls.Add(this.cb_freq_random);
            this.groupBox2.Controls.Add(this.num_freq_sec);
            this.groupBox2.Location = new System.Drawing.Point(295, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(218, 100);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Frequency";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Random";
            // 
            // lb_rand_time
            // 
            this.lb_rand_time.AutoSize = true;
            this.lb_rand_time.Location = new System.Drawing.Point(6, 76);
            this.lb_rand_time.Name = "lb_rand_time";
            this.lb_rand_time.Size = new System.Drawing.Size(73, 13);
            this.lb_rand_time.TabIndex = 12;
            this.lb_rand_time.Text = "Random Time";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Time";
            // 
            // num_freq_rand_sec
            // 
            this.num_freq_rand_sec.Location = new System.Drawing.Point(175, 73);
            this.num_freq_rand_sec.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.num_freq_rand_sec.Name = "num_freq_rand_sec";
            this.num_freq_rand_sec.Size = new System.Drawing.Size(34, 20);
            this.num_freq_rand_sec.TabIndex = 10;
            // 
            // num_freq_rand_min
            // 
            this.num_freq_rand_min.Location = new System.Drawing.Point(135, 74);
            this.num_freq_rand_min.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.num_freq_rand_min.Name = "num_freq_rand_min";
            this.num_freq_rand_min.Size = new System.Drawing.Size(34, 20);
            this.num_freq_rand_min.TabIndex = 9;
            // 
            // num_freq_rand_hr
            // 
            this.num_freq_rand_hr.Location = new System.Drawing.Point(95, 74);
            this.num_freq_rand_hr.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.num_freq_rand_hr.Name = "num_freq_rand_hr";
            this.num_freq_rand_hr.Size = new System.Drawing.Size(34, 20);
            this.num_freq_rand_hr.TabIndex = 8;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.num_rand);
            this.groupBox3.Controls.Add(this.rb_random);
            this.groupBox3.Controls.Add(this.rb_fixed);
            this.groupBox3.Controls.Add(this.num_fixed);
            this.groupBox3.Location = new System.Drawing.Point(12, 144);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(230, 91);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Data to Generate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fixed/Random";
            // 
            // num_rand
            // 
            this.num_rand.Location = new System.Drawing.Point(174, 51);
            this.num_rand.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_rand.Name = "num_rand";
            this.num_rand.Size = new System.Drawing.Size(50, 20);
            this.num_rand.TabIndex = 3;
            this.num_rand.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // rb_random
            // 
            this.rb_random.AutoSize = true;
            this.rb_random.Location = new System.Drawing.Point(159, 19);
            this.rb_random.Name = "rb_random";
            this.rb_random.Size = new System.Drawing.Size(65, 17);
            this.rb_random.TabIndex = 2;
            this.rb_random.TabStop = true;
            this.rb_random.Text = "Random";
            this.rb_random.UseVisualStyleBackColor = true;
            this.rb_random.CheckedChanged += new System.EventHandler(this.rb_random_CheckedChanged);
            // 
            // rb_fixed
            // 
            this.rb_fixed.AutoSize = true;
            this.rb_fixed.Location = new System.Drawing.Point(103, 19);
            this.rb_fixed.Name = "rb_fixed";
            this.rb_fixed.Size = new System.Drawing.Size(50, 17);
            this.rb_fixed.TabIndex = 1;
            this.rb_fixed.TabStop = true;
            this.rb_fixed.Text = "Fixed";
            this.rb_fixed.UseVisualStyleBackColor = true;
            // 
            // num_fixed
            // 
            this.num_fixed.Location = new System.Drawing.Point(103, 51);
            this.num_fixed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_fixed.Name = "num_fixed";
            this.num_fixed.Size = new System.Drawing.Size(50, 20);
            this.num_fixed.TabIndex = 0;
            this.num_fixed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.num_percentage);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.num_change);
            this.groupBox4.Location = new System.Drawing.Point(295, 144);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(218, 91);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Deviation";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Change By %";
            // 
            // num_percentage
            // 
            this.num_percentage.Location = new System.Drawing.Point(95, 41);
            this.num_percentage.Name = "num_percentage";
            this.num_percentage.Size = new System.Drawing.Size(64, 20);
            this.num_percentage.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Change Value";
            // 
            // num_change
            // 
            this.num_change.Location = new System.Drawing.Point(95, 13);
            this.num_change.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_change.Name = "num_change";
            this.num_change.Size = new System.Drawing.Size(64, 20);
            this.num_change.TabIndex = 0;
            this.num_change.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // bt_start
            // 
            this.bt_start.Location = new System.Drawing.Point(80, 260);
            this.bt_start.Name = "bt_start";
            this.bt_start.Size = new System.Drawing.Size(162, 40);
            this.bt_start.TabIndex = 12;
            this.bt_start.Text = "Start";
            this.bt_start.UseVisualStyleBackColor = true;
            this.bt_start.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_stop
            // 
            this.bt_stop.Location = new System.Drawing.Point(295, 260);
            this.bt_stop.Name = "bt_stop";
            this.bt_stop.Size = new System.Drawing.Size(162, 40);
            this.bt_stop.TabIndex = 13;
            this.bt_stop.Text = "Stop";
            this.bt_stop.UseVisualStyleBackColor = true;
            this.bt_stop.Click += new System.EventHandler(this.bt_stop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 322);
            this.Controls.Add(this.bt_stop);
            this.Controls.Add(this.bt_start);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Data Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_freq_hr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_freq_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_freq_sec)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_freq_rand_sec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_freq_rand_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_freq_rand_hr)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_rand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_fixed)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_percentage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_change)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox dd_serverName;
        private System.Windows.Forms.ComboBox dd_tagType;
        private System.Windows.Forms.TextBox tb_tagName;
        private System.Windows.Forms.NumericUpDown num_freq_hr;
        private System.Windows.Forms.NumericUpDown num_freq_min;
        private System.Windows.Forms.NumericUpDown num_freq_sec;
        private System.Windows.Forms.CheckBox cb_freq_random;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown num_freq_rand_min;
        private System.Windows.Forms.NumericUpDown num_freq_rand_hr;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rb_random;
        private System.Windows.Forms.RadioButton rb_fixed;
        private System.Windows.Forms.NumericUpDown num_fixed;
        private System.Windows.Forms.NumericUpDown num_freq_rand_sec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown num_rand;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lb_rand_time;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown num_percentage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown num_change;
        private System.Windows.Forms.Button bt_start;
        private System.Windows.Forms.Button bt_stop;
    }
}

