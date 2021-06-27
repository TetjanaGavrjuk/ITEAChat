namespace Client.UI
{
    partial class frmChatRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChatRoom));
            this.txtChat = new System.Windows.Forms.RichTextBox();
            this.txtUserMessage = new System.Windows.Forms.RichTextBox();
            this.cmdSendMessage = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblNick = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.txtServerIPAndPort = new System.Windows.Forms.TextBox();
            this.lblServer = new System.Windows.Forms.Label();
            this.btnServerIP = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtChat
            // 
            this.txtChat.Enabled = false;
            this.txtChat.Location = new System.Drawing.Point(34, 63);
            this.txtChat.Name = "txtChat";
            this.txtChat.Size = new System.Drawing.Size(658, 300);
            this.txtChat.TabIndex = 0;
            this.txtChat.Text = "";
            // 
            // txtUserMessage
            // 
            this.txtUserMessage.Location = new System.Drawing.Point(34, 412);
            this.txtUserMessage.Name = "txtUserMessage";
            this.txtUserMessage.Size = new System.Drawing.Size(653, 74);
            this.txtUserMessage.TabIndex = 1;
            this.txtUserMessage.Text = "";
            // 
            // cmdSendMessage
            // 
            this.cmdSendMessage.Image = ((System.Drawing.Image)(resources.GetObject("cmdSendMessage.Image")));
            this.cmdSendMessage.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cmdSendMessage.Location = new System.Drawing.Point(693, 429);
            this.cmdSendMessage.Name = "cmdSendMessage";
            this.cmdSendMessage.Size = new System.Drawing.Size(38, 38);
            this.cmdSendMessage.TabIndex = 2;
            this.cmdSendMessage.UseVisualStyleBackColor = true;
            this.cmdSendMessage.Click += new System.EventHandler(this.cmdSendMessage_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Enabled = false;
            this.txtUserName.Location = new System.Drawing.Point(777, 57);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(124, 20);
            this.txtUserName.TabIndex = 3;
            // 
            // lblNick
            // 
            this.lblNick.AutoSize = true;
            this.lblNick.Enabled = false;
            this.lblNick.Location = new System.Drawing.Point(697, 60);
            this.lblNick.Name = "lblNick";
            this.lblNick.Size = new System.Drawing.Size(74, 13);
            this.lblNick.TabIndex = 4;
            this.lblNick.Text = "My NickName";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSettings});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(942, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuSettings
            // 
            this.mnuSettings.Name = "mnuSettings";
            this.mnuSettings.Size = new System.Drawing.Size(79, 20);
            this.mnuSettings.Text = "Настройки";
            this.mnuSettings.Click += new System.EventHandler(this.mnuSettings_Click);
            // 
            // txtServerIPAndPort
            // 
            this.txtServerIPAndPort.Enabled = false;
            this.txtServerIPAndPort.Location = new System.Drawing.Point(777, 83);
            this.txtServerIPAndPort.Name = "txtServerIPAndPort";
            this.txtServerIPAndPort.Size = new System.Drawing.Size(124, 20);
            this.txtServerIPAndPort.TabIndex = 3;
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Enabled = false;
            this.lblServer.Location = new System.Drawing.Point(697, 86);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(70, 13);
            this.lblServer.TabIndex = 4;
            this.lblServer.Text = "ServerIP:Port";
            // 
            // btnServerIP
            // 
            this.btnServerIP.Location = new System.Drawing.Point(903, 83);
            this.btnServerIP.Name = "btnServerIP";
            this.btnServerIP.Size = new System.Drawing.Size(27, 22);
            this.btnServerIP.TabIndex = 6;
            this.btnServerIP.Text = "...";
            this.btnServerIP.UseVisualStyleBackColor = true;
            this.btnServerIP.Click += new System.EventHandler(this.btnServerIP_Click);
            // 
            // frmChatRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 498);
            this.Controls.Add(this.btnServerIP);
            this.Controls.Add(this.lblServer);
            this.Controls.Add(this.lblNick);
            this.Controls.Add(this.txtServerIPAndPort);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.cmdSendMessage);
            this.Controls.Add(this.txtUserMessage);
            this.Controls.Add(this.txtChat);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmChatRoom";
            this.Text = "Чат";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmChatRoom_FormClosed);
            this.Load += new System.EventHandler(this.frmChatRoom_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtChat;
        private System.Windows.Forms.RichTextBox txtUserMessage;
        private System.Windows.Forms.Button cmdSendMessage;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblNick;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuSettings;
        private System.Windows.Forms.TextBox txtServerIPAndPort;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.Button btnServerIP;
    }
}