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
            this.cmdProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdProcess.Location = new System.Drawing.Point(717, 340);
            this.cmdProcess.Name = "cmdProcess";
            this.cmdProcess.Size = new System.Drawing.Size(88, 26);
            this.cmdProcess.TabIndex = 1;
            this.cmdProcess.Text = "Process";
            this.cmdProcess.UseVisualStyleBackColor = true;
            this.cmdProcess.Click += new System.EventHandler(this.cmdProcess_Click);
            // 
            // lstConsole
            // 
            this.lstConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstConsole.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstConsole.ForeColor = System.Drawing.Color.Green;
            this.lstConsole.FormattingEnabled = true;
            this.lstConsole.ItemHeight = 18;
            this.lstConsole.Location = new System.Drawing.Point(12, 7);
            this.lstConsole.Name = "lstConsole";
            this.lstConsole.Size = new System.Drawing.Size(792, 328);
            this.lstConsole.TabIndex = 2;
            // 
            // txtInput
            // 
            this.txtInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInput.Location = new System.Drawing.Point(12, 344);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(699, 20);
            this.txtInput.TabIndex = 0;
            this.txtInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
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

