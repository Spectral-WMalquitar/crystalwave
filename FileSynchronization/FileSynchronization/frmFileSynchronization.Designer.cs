namespace FileSynchronization
{
    partial class frmFileSync
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
            this.components = new System.ComponentModel.Container();
            this.grpScheduledTask = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lstTasks = new System.Windows.Forms.ListView();
            this.SettingsID = new System.Windows.Forms.ColumnHeader();
            this.No = new System.Windows.Forms.ColumnHeader();
            this.ClientName = new System.Windows.Forms.ColumnHeader();
            this.PathName = new System.Windows.Forms.ColumnHeader();
            this.DestinationName = new System.Windows.Forms.ColumnHeader();
            this.Selected = new System.Windows.Forms.ColumnHeader();
            this.grpAddTask = new System.Windows.Forms.GroupBox();
            this.cmbSelected = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
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
            this.btnRun = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.showLogHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrFileSync = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSyncStatus = new System.Windows.Forms.TextBox();
            this.grpScheduledTask.SuspendLayout();
            this.grpAddTask.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpScheduledTask
            // 
            this.grpScheduledTask.Controls.Add(this.progressBar1);
            this.grpScheduledTask.Controls.Add(this.btnDelete);
            this.grpScheduledTask.Controls.Add(this.btnEdit);
            this.grpScheduledTask.Controls.Add(this.lstTasks);
            this.grpScheduledTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpScheduledTask.Location = new System.Drawing.Point(12, 27);
            this.grpScheduledTask.Name = "grpScheduledTask";
            this.grpScheduledTask.Size = new System.Drawing.Size(878, 283);
            this.grpScheduledTask.TabIndex = 1;
            this.grpScheduledTask.TabStop = false;
            this.grpScheduledTask.Text = "Scheduled Tasks ";
            this.grpScheduledTask.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 252);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(700, 19);
            this.progressBar1.TabIndex = 4;
            this.progressBar1.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(795, 249);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(77, 26);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(712, 249);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(77, 26);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lstTasks
            // 
            this.lstTasks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SettingsID,
            this.No,
            this.ClientName,
            this.PathName,
            this.DestinationName,
            this.Selected});
            this.lstTasks.FullRowSelect = true;
            this.lstTasks.GridLines = true;
            this.lstTasks.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstTasks.Location = new System.Drawing.Point(6, 35);
            this.lstTasks.Name = "lstTasks";
            this.lstTasks.Size = new System.Drawing.Size(867, 208);
            this.lstTasks.TabIndex = 1;
            this.lstTasks.UseCompatibleStateImageBehavior = false;
            this.lstTasks.View = System.Windows.Forms.View.Details;
            this.lstTasks.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lstTasks_ItemChecked);
            this.lstTasks.SelectedIndexChanged += new System.EventHandler(this.lstTasks_SelectedIndexChanged);
            this.lstTasks.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lstTasks_ItemCheck);
            // 
            // SettingsID
            // 
            this.SettingsID.Text = "SettingsID";
            this.SettingsID.Width = 0;
            // 
            // No
            // 
            this.No.Text = "No";
            this.No.Width = 35;
            // 
            // ClientName
            // 
            this.ClientName.Text = "Client Name";
            this.ClientName.Width = 152;
            // 
            // PathName
            // 
            this.PathName.Text = "Driver Source Path";
            this.PathName.Width = 290;
            // 
            // DestinationName
            // 
            this.DestinationName.Text = "Destination Folder";
            this.DestinationName.Width = 300;
            // 
            // Selected
            // 
            this.Selected.Text = "Selected";
            // 
            // grpAddTask
            // 
            this.grpAddTask.Controls.Add(this.cmbSelected);
            this.grpAddTask.Controls.Add(this.label6);
            this.grpAddTask.Controls.Add(this.btnCancel);
            this.grpAddTask.Controls.Add(this.btnSave);
            this.grpAddTask.Controls.Add(this.label5);
            this.grpAddTask.Controls.Add(this.cmbNameFormat);
            this.grpAddTask.Controls.Add(this.btnBrowDesti);
            this.grpAddTask.Controls.Add(this.btnBrowSource);
            this.grpAddTask.Controls.Add(this.txtDestinationPath);
            this.grpAddTask.Controls.Add(this.label4);
            this.grpAddTask.Controls.Add(this.txtSourcePath);
            this.grpAddTask.Controls.Add(this.label3);
            this.grpAddTask.Controls.Add(this.txtClientName);
            this.grpAddTask.Controls.Add(this.label2);
            this.grpAddTask.Controls.Add(this.optCreateBak);
            this.grpAddTask.Controls.Add(this.optOverwrite);
            this.grpAddTask.Controls.Add(this.label1);
            this.grpAddTask.Enabled = false;
            this.grpAddTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAddTask.Location = new System.Drawing.Point(12, 316);
            this.grpAddTask.Name = "grpAddTask";
            this.grpAddTask.Size = new System.Drawing.Size(765, 148);
            this.grpAddTask.TabIndex = 2;
            this.grpAddTask.TabStop = false;
            this.grpAddTask.Text = "Task Properties";
            // 
            // cmbSelected
            // 
            this.cmbSelected.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelected.FormattingEnabled = true;
            this.cmbSelected.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.cmbSelected.Location = new System.Drawing.Point(102, 112);
            this.cmbSelected.Name = "cmbSelected";
            this.cmbSelected.Size = new System.Drawing.Size(107, 23);
            this.cmbSelected.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Select to Run";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(670, 115);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(77, 26);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(584, 115);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(77, 26);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(568, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Naming Format";
            // 
            // cmbNameFormat
            // 
            this.cmbNameFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNameFormat.FormattingEnabled = true;
            this.cmbNameFormat.Items.AddRange(new object[] {
            "<--SELECT A FORMAT-->",
            "YYMMDD_HHMMSS",
            "YYMMDD"});
            this.cmbNameFormat.Location = new System.Drawing.Point(571, 73);
            this.cmbNameFormat.Name = "cmbNameFormat";
            this.cmbNameFormat.Size = new System.Drawing.Size(176, 23);
            this.cmbNameFormat.TabIndex = 11;
            // 
            // btnBrowDesti
            // 
            this.btnBrowDesti.Location = new System.Drawing.Point(416, 80);
            this.btnBrowDesti.Name = "btnBrowDesti";
            this.btnBrowDesti.Size = new System.Drawing.Size(26, 21);
            this.btnBrowDesti.TabIndex = 10;
            this.btnBrowDesti.Text = "...";
            this.btnBrowDesti.UseVisualStyleBackColor = true;
            this.btnBrowDesti.Click += new System.EventHandler(this.btnBrowDesti_Click);
            // 
            // btnBrowSource
            // 
            this.btnBrowSource.Location = new System.Drawing.Point(416, 54);
            this.btnBrowSource.Name = "btnBrowSource";
            this.btnBrowSource.Size = new System.Drawing.Size(26, 21);
            this.btnBrowSource.TabIndex = 9;
            this.btnBrowSource.Text = "...";
            this.btnBrowSource.UseVisualStyleBackColor = true;
            this.btnBrowSource.Click += new System.EventHandler(this.btnBrowSource_Click);
            // 
            // txtDestinationPath
            // 
            this.txtDestinationPath.Location = new System.Drawing.Point(102, 80);
            this.txtDestinationPath.Name = "txtDestinationPath";
            this.txtDestinationPath.ReadOnly = true;
            this.txtDestinationPath.Size = new System.Drawing.Size(308, 21);
            this.txtDestinationPath.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(21, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 34);
            this.label4.TabIndex = 7;
            this.label4.Text = "Destination Folder";
            // 
            // txtSourcePath
            // 
            this.txtSourcePath.Location = new System.Drawing.Point(102, 53);
            this.txtSourcePath.Name = "txtSourcePath";
            this.txtSourcePath.ReadOnly = true;
            this.txtSourcePath.Size = new System.Drawing.Size(308, 21);
            this.txtSourcePath.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Source File";
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(102, 26);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(236, 21);
            this.txtClientName.TabIndex = 4;
            this.txtClientName.TextChanged += new System.EventHandler(this.txtClientName_TextChanged);
            this.txtClientName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtClientName_KeyDown);
            this.txtClientName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClientName_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Client Name";
            // 
            // optCreateBak
            // 
            this.optCreateBak.AutoSize = true;
            this.optCreateBak.Location = new System.Drawing.Point(460, 77);
            this.optCreateBak.Name = "optCreateBak";
            this.optCreateBak.Size = new System.Drawing.Size(105, 19);
            this.optCreateBak.TabIndex = 2;
            this.optCreateBak.TabStop = true;
            this.optCreateBak.Text = "Create Backup";
            this.optCreateBak.UseVisualStyleBackColor = true;
            // 
            // optOverwrite
            // 
            this.optOverwrite.AutoSize = true;
            this.optOverwrite.Location = new System.Drawing.Point(459, 52);
            this.optOverwrite.Name = "optOverwrite";
            this.optOverwrite.Size = new System.Drawing.Size(99, 19);
            this.optOverwrite.TabIndex = 1;
            this.optOverwrite.TabStop = true;
            this.optOverwrite.Text = "Overwrite File";
            this.optOverwrite.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(457, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "If the file exists, do the following:";
            // 
            // btnRun
            // 
            this.btnRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.Location = new System.Drawing.Point(783, 324);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(107, 88);
            this.btnRun.TabIndex = 3;
            this.btnRun.Text = "&Run Sync";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(901, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTaskToolStripMenuItem,
            this.toolStripSeparator1,
            this.showLogHistoryToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // addTaskToolStripMenuItem
            // 
            this.addTaskToolStripMenuItem.Name = "addTaskToolStripMenuItem";
            this.addTaskToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.addTaskToolStripMenuItem.Text = "Add Task";
            this.addTaskToolStripMenuItem.Click += new System.EventHandler(this.addTaskToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(164, 6);
            // 
            // showLogHistoryToolStripMenuItem
            // 
            this.showLogHistoryToolStripMenuItem.Name = "showLogHistoryToolStripMenuItem";
            this.showLogHistoryToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.showLogHistoryToolStripMenuItem.Text = "Show Log History";
            this.showLogHistoryToolStripMenuItem.Click += new System.EventHandler(this.showLogHistoryToolStripMenuItem_Click);
            // 
            // tmrFileSync
            // 
            this.tmrFileSync.Interval = 1000;
            this.tmrFileSync.Tick += new System.EventHandler(this.tmrFileSync_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSyncStatus);
            this.groupBox1.Location = new System.Drawing.Point(12, 470);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(878, 191);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sync Status";
            // 
            // txtSyncStatus
            // 
            this.txtSyncStatus.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtSyncStatus.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSyncStatus.Location = new System.Drawing.Point(6, 19);
            this.txtSyncStatus.Multiline = true;
            this.txtSyncStatus.Name = "txtSyncStatus";
            this.txtSyncStatus.ReadOnly = true;
            this.txtSyncStatus.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSyncStatus.Size = new System.Drawing.Size(866, 166);
            this.txtSyncStatus.TabIndex = 0;
            // 
            // frmFileSync
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 669);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.grpAddTask);
            this.Controls.Add(this.grpScheduledTask);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFileSync";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Synchronization ver. 1.0";
            this.Load += new System.EventHandler(this.frmFileSync_Load);
            this.grpScheduledTask.ResumeLayout(false);
            this.grpAddTask.ResumeLayout(false);
            this.grpAddTask.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpScheduledTask;
        private System.Windows.Forms.ListView lstTasks;
        private System.Windows.Forms.ColumnHeader SettingsID;
        private System.Windows.Forms.ColumnHeader No;
        private System.Windows.Forms.ColumnHeader ClientName;
        private System.Windows.Forms.ColumnHeader PathName;
        private System.Windows.Forms.ColumnHeader DestinationName;
        private System.Windows.Forms.GroupBox grpAddTask;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton optCreateBak;
        private System.Windows.Forms.RadioButton optOverwrite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrowDesti;
        private System.Windows.Forms.Button btnBrowSource;
        private System.Windows.Forms.TextBox txtDestinationPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSourcePath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbNameFormat;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTaskToolStripMenuItem;
        public System.Windows.Forms.Timer tmrFileSync;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSyncStatus;
        private System.Windows.Forms.ComboBox cmbSelected;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ColumnHeader Selected;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem showLogHistoryToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

