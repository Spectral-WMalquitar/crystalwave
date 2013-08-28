namespace FileSynchronization
{
    partial class frmAddTask
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
            this.label5 = new System.Windows.Forms.Label();
            this.cmbNameFormat = new System.Windows.Forms.ComboBox();
            this.btnBrowDesti = new System.Windows.Forms.Button();
            this.btnBrowSource = new System.Windows.Forms.Button();
            this.txtDestinationPath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSourcePath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.optCreateBak = new System.Windows.Forms.RadioButton();
            this.optOverwrite = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(128, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Naming Format";
            // 
            // cmbNameFormat
            // 
            this.cmbNameFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNameFormat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbNameFormat.FormattingEnabled = true;
            this.cmbNameFormat.Items.AddRange(new object[] {
            "<--SELECT A FORMAT-->",
            "YYMMDD_HHMMSS",
            "YYMMDD"});
            this.cmbNameFormat.Location = new System.Drawing.Point(131, 190);
            this.cmbNameFormat.Name = "cmbNameFormat";
            this.cmbNameFormat.Size = new System.Drawing.Size(176, 21);
            this.cmbNameFormat.TabIndex = 24;
            // 
            // btnBrowDesti
            // 
            this.btnBrowDesti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowDesti.Location = new System.Drawing.Point(344, 76);
            this.btnBrowDesti.Name = "btnBrowDesti";
            this.btnBrowDesti.Size = new System.Drawing.Size(25, 21);
            this.btnBrowDesti.TabIndex = 23;
            this.btnBrowDesti.Text = "...";
            this.btnBrowDesti.UseVisualStyleBackColor = true;
            this.btnBrowDesti.Click += new System.EventHandler(this.btnBrowDesti_Click);
            // 
            // btnBrowSource
            // 
            this.btnBrowSource.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowSource.Location = new System.Drawing.Point(344, 50);
            this.btnBrowSource.Name = "btnBrowSource";
            this.btnBrowSource.Size = new System.Drawing.Size(25, 21);
            this.btnBrowSource.TabIndex = 22;
            this.btnBrowSource.Text = "...";
            this.btnBrowSource.UseVisualStyleBackColor = true;
            this.btnBrowSource.Click += new System.EventHandler(this.btnBrowSource_Click);
            // 
            // txtDestinationPath
            // 
            this.txtDestinationPath.Location = new System.Drawing.Point(97, 76);
            this.txtDestinationPath.Name = "txtDestinationPath";
            this.txtDestinationPath.ReadOnly = true;
            this.txtDestinationPath.Size = new System.Drawing.Size(236, 20);
            this.txtDestinationPath.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(16, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 34);
            this.label4.TabIndex = 20;
            this.label4.Text = "Destination Folder";
            // 
            // txtSourcePath
            // 
            this.txtSourcePath.Location = new System.Drawing.Point(97, 49);
            this.txtSourcePath.Name = "txtSourcePath";
            this.txtSourcePath.ReadOnly = true;
            this.txtSourcePath.Size = new System.Drawing.Size(236, 20);
            this.txtSourcePath.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Source File";
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(97, 22);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(236, 20);
            this.txtClientName.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Client Name";
            // 
            // optCreateBak
            // 
            this.optCreateBak.AutoSize = true;
            this.optCreateBak.Location = new System.Drawing.Point(20, 194);
            this.optCreateBak.Name = "optCreateBak";
            this.optCreateBak.Size = new System.Drawing.Size(96, 17);
            this.optCreateBak.TabIndex = 15;
            this.optCreateBak.TabStop = true;
            this.optCreateBak.Text = "Create Backup";
            this.optCreateBak.UseVisualStyleBackColor = true;
            // 
            // optOverwrite
            // 
            this.optOverwrite.AutoSize = true;
            this.optOverwrite.Location = new System.Drawing.Point(20, 169);
            this.optOverwrite.Name = "optOverwrite";
            this.optOverwrite.Size = new System.Drawing.Size(89, 17);
            this.optOverwrite.TabIndex = 14;
            this.optOverwrite.TabStop = true;
            this.optOverwrite.Text = "Overwrite File";
            this.optOverwrite.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "If the file exists, do the following:";
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(193, 238);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 31);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(289, 238);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 31);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmAddTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 297);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbNameFormat);
            this.Controls.Add(this.btnBrowDesti);
            this.Controls.Add(this.btnBrowSource);
            this.Controls.Add(this.txtDestinationPath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSourcePath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtClientName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.optCreateBak);
            this.Controls.Add(this.optOverwrite);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Task";
            this.Load += new System.EventHandler(this.frmAddTask_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbNameFormat;
        private System.Windows.Forms.Button btnBrowDesti;
        private System.Windows.Forms.Button btnBrowSource;
        private System.Windows.Forms.TextBox txtDestinationPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSourcePath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton optCreateBak;
        private System.Windows.Forms.RadioButton optOverwrite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}