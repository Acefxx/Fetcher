namespace Fetcher
{
    partial class frmFetcher
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
            this.cmdProcess = new System.Windows.Forms.Button();
            this.lstConsole = new System.Windows.Forms.ListBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmdProcess
            // 
            this.cmdProcess.Location = new System.Drawing.Point(717, 340);
            this.cmdProcess.Name = "cmdProcess";
            this.cmdProcess.Size = new System.Drawing.Size(88, 26);
            this.cmdProcess.TabIndex = 0;
            this.cmdProcess.Text = "Process";
            this.cmdProcess.UseVisualStyleBackColor = true;
            this.cmdProcess.Click += new System.EventHandler(this.cmdProcess_Click);
            // 
            // lstConsole
            // 
            this.lstConsole.FormattingEnabled = true;
            this.lstConsole.Location = new System.Drawing.Point(12, 7);
            this.lstConsole.Name = "lstConsole";
            this.lstConsole.Size = new System.Drawing.Size(792, 329);
            this.lstConsole.TabIndex = 1;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(12, 344);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(699, 20);
            this.txtInput.TabIndex = 2;
            // 
            // frmFetcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 372);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lstConsole);
            this.Controls.Add(this.cmdProcess);
            this.Name = "frmFetcher";
            this.Text = "Fetcher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdProcess;
        private System.Windows.Forms.ListBox lstConsole;
        private System.Windows.Forms.TextBox txtInput;
    }
}

