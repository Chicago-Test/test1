namespace CodeProject
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDirectory = new System.Windows.Forms.TextBox();
            this.cmdBrowse = new System.Windows.Forms.Button();
            this.cmdEnumTest3 = new System.Windows.Forms.Button();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkSearchSubdirectories = new System.Windows.Forms.CheckBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.NumUpDownMaxDepth = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownMaxDepth)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Directory:";
            // 
            // txtDirectory
            // 
            this.txtDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDirectory.Location = new System.Drawing.Point(93, 15);
            this.txtDirectory.Margin = new System.Windows.Forms.Padding(4);
            this.txtDirectory.Name = "txtDirectory";
            this.txtDirectory.Size = new System.Drawing.Size(1345, 23);
            this.txtDirectory.TabIndex = 1;
            this.txtDirectory.Text = "E:\\temp\\S&P test program";
            // 
            // cmdBrowse
            // 
            this.cmdBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdBrowse.Location = new System.Drawing.Point(1448, 12);
            this.cmdBrowse.Margin = new System.Windows.Forms.Padding(4);
            this.cmdBrowse.Name = "cmdBrowse";
            this.cmdBrowse.Size = new System.Drawing.Size(64, 28);
            this.cmdBrowse.TabIndex = 2;
            this.cmdBrowse.Text = "...";
            this.cmdBrowse.UseVisualStyleBackColor = true;
            this.cmdBrowse.Click += new System.EventHandler(this.cmdBrowse_Click);
            // 
            // cmdEnumTest3
            // 
            this.cmdEnumTest3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdEnumTest3.Location = new System.Drawing.Point(32, 106);
            this.cmdEnumTest3.Margin = new System.Windows.Forms.Padding(4);
            this.cmdEnumTest3.Name = "cmdEnumTest3";
            this.cmdEnumTest3.Size = new System.Drawing.Size(1437, 42);
            this.cmdEnumTest3.TabIndex = 2;
            this.cmdEnumTest3.Text = "Enum with FastDirectoryEnumerator.EnumFiles";
            this.cmdEnumTest3.UseVisualStyleBackColor = true;
            this.cmdEnumTest3.Click += new System.EventHandler(this.cmdEnumTest2_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilter.Location = new System.Drawing.Point(93, 47);
            this.txtFilter.Margin = new System.Windows.Forms.Padding(4);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(1345, 23);
            this.txtFilter.TabIndex = 4;
            this.txtFilter.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Filter:";
            // 
            // chkSearchSubdirectories
            // 
            this.chkSearchSubdirectories.AutoSize = true;
            this.chkSearchSubdirectories.Checked = true;
            this.chkSearchSubdirectories.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSearchSubdirectories.Location = new System.Drawing.Point(93, 79);
            this.chkSearchSubdirectories.Name = "chkSearchSubdirectories";
            this.chkSearchSubdirectories.Size = new System.Drawing.Size(172, 20);
            this.chkSearchSubdirectories.TabIndex = 5;
            this.chkSearchSubdirectories.Text = "Search Subdirectories";
            this.chkSearchSubdirectories.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Location = new System.Drawing.Point(15, 203);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1496, 301);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "Copy to clipboard";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(230, 165);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 28);
            this.button2.TabIndex = 8;
            this.button2.Text = "Save to file";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // NumUpDownMaxDepth
            // 
            this.NumUpDownMaxDepth.Location = new System.Drawing.Point(499, 163);
            this.NumUpDownMaxDepth.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.NumUpDownMaxDepth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.NumUpDownMaxDepth.Name = "NumUpDownMaxDepth";
            this.NumUpDownMaxDepth.Size = new System.Drawing.Size(78, 23);
            this.NumUpDownMaxDepth.TabIndex = 9;
            this.NumUpDownMaxDepth.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.NumUpDownMaxDepth.ValueChanged += new System.EventHandler(this.NumUpDownMaxDepth_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(409, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "max depth";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1528, 535);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NumUpDownMaxDepth);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.cmdEnumTest3);
            this.Controls.Add(this.chkSearchSubdirectories);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmdBrowse);
            this.Controls.Add(this.txtDirectory);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(417, 478);
            this.Name = "Form1";
            this.Text = "Directory Enumerator Test Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownMaxDepth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDirectory;
        private System.Windows.Forms.Button cmdBrowse;
        private System.Windows.Forms.Button cmdEnumTest3;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkSearchSubdirectories;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown NumUpDownMaxDepth;
        private System.Windows.Forms.Label label2;
    }
}

