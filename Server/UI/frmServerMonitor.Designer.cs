namespace UI
{
    partial class frmServerMonitor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmServerMonitor));
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.txtServerIPAndPort = new System.Windows.Forms.TextBox();
            this.lblServer = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLog
            // 
            this.txtLog.Enabled = false;
            this.txtLog.Location = new System.Drawing.Point(34, 63);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(658, 300);
            this.txtLog.TabIndex = 0;
            this.txtLog.Text = "";
            // 
            // txtServerIPAndPort
            // 
            this.txtServerIPAndPort.Enabled = false;
            this.txtServerIPAndPort.Location = new System.Drawing.Point(774, 66);
            this.txtServerIPAndPort.Name = "txtServerIPAndPort";
            this.txtServerIPAndPort.Size = new System.Drawing.Size(124, 20);
            this.txtServerIPAndPort.TabIndex = 3;
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Enabled = false;
            this.lblServer.Location = new System.Drawing.Point(698, 66);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(70, 13);
            this.lblServer.TabIndex = 4;
            this.lblServer.Text = "ServerIP:Port";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(91, 396);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(147, 37);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmServerMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 498);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblServer);
            this.Controls.Add(this.txtServerIPAndPort);
            this.Controls.Add(this.txtLog);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmServerMonitor";
            this.Text = "Монитор сервера чата";
            this.Load += new System.EventHandler(this.frmServerMonitor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.TextBox txtServerIPAndPort;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.Button btnExit;
    }
}