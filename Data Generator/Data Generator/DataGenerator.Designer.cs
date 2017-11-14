namespace Data_Generator
{
    partial class DataGenerator
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
            this.grpboxTagList = new System.Windows.Forms.GroupBox();
            this.datagridTagList = new System.Windows.Forms.DataGridView();
            this.colTagName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpboxTagList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridTagList)).BeginInit();
            this.SuspendLayout();
            // 
            // grpboxTagList
            // 
            this.grpboxTagList.Controls.Add(this.datagridTagList);
            this.grpboxTagList.Location = new System.Drawing.Point(4, 631);
            this.grpboxTagList.Margin = new System.Windows.Forms.Padding(4);
            this.grpboxTagList.Name = "grpboxTagList";
            this.grpboxTagList.Padding = new System.Windows.Forms.Padding(6);
            this.grpboxTagList.Size = new System.Drawing.Size(716, 284);
            this.grpboxTagList.TabIndex = 17;
            this.grpboxTagList.TabStop = false;
            this.grpboxTagList.Text = "Tag List";
            this.grpboxTagList.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // datagridTagList
            // 
            this.datagridTagList.AllowUserToAddRows = false;
            this.datagridTagList.AllowUserToDeleteRows = false;
            this.datagridTagList.AllowUserToResizeRows = false;
            this.datagridTagList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridTagList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridTagList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTagName,
            this.colValue});
            this.datagridTagList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagridTagList.Location = new System.Drawing.Point(6, 21);
            this.datagridTagList.Margin = new System.Windows.Forms.Padding(4);
            this.datagridTagList.Name = "datagridTagList";
            this.datagridTagList.ReadOnly = true;
            this.datagridTagList.RowHeadersVisible = false;
            this.datagridTagList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.datagridTagList.Size = new System.Drawing.Size(704, 257);
            this.datagridTagList.TabIndex = 0;
            this.datagridTagList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.datagridTagList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridTagList_CellContentClick);
            // 
            // colTagName
            // 
            this.colTagName.HeaderText = "Tag Name";
            this.colTagName.Name = "colTagName";
            this.colTagName.ReadOnly = true;
            // 
            // colValue
            // 
            this.colValue.HeaderText = "Tag Values";
            this.colValue.Name = "colValue";
            this.colValue.ReadOnly = true;
            // 
            // DataGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 918);
            this.Controls.Add(this.grpboxTagList);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "DataGenerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Data Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpboxTagList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridTagList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpboxTagList;
        private System.Windows.Forms.DataGridView datagridTagList;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTagName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValue;
    }
}

