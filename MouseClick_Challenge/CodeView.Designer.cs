namespace MouseClick_Challenge
{
    partial class CodeView
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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.txtMainForm = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // txtMainForm
            // 
            this.txtMainForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMainForm.Location = new System.Drawing.Point(0, 0);
            this.txtMainForm.Multiline = true;
            this.txtMainForm.Name = "txtMainForm";
            this.txtMainForm.ReadOnly = true;
            this.txtMainForm.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMainForm.Size = new System.Drawing.Size(1009, 741);
            this.txtMainForm.TabIndex = 1;
            // 
            // CodeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1009, 741);
            this.Controls.Add(this.txtMainForm);
            this.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12.25F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "CodeView";
            this.ShowIcon = false;
            this.Text = "CodeView";
            this.Load += new System.EventHandler(this.CodeView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TextBox txtMainForm;
    }
}