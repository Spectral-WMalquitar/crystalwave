namespace FileSynchronization
{
    partial class frmLogHistory
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
            this.txtLogHistory = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtLogHistory
            // 
            this.txtLogHistory.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtLogHistory.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogHistory.Location = new System.Drawing.Point(4, 1);
            this.txtLogHistory.Multiline = true;
            this.txtLogHistory.Name = "txtLogHistory";
            this.txtLogHistory.ReadOnly = true;
            this.txtLogHistory.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLogHistory.Size = new System.Drawing.Size(767, 520);
            this.txtLogHistory.TabIndex = 0;
            this.txtLogHistory.TextChanged += new System.EventHandler(this.txtLogHistory_TextChanged);
            // 
            // frmLogHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 525);
            this.Controls.Add(this.txtLogHistory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log History";
            this.Load += new System.EventHandler(this.frmLogHistory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLogHistory;
    }
}