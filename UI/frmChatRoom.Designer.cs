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
            this.SuspendLayout();
            // 
            // txtChat
            // 
            this.txtChat.Location = new System.Drawing.Point(34, 24);
            this.txtChat.Name = "txtChat";
            this.txtChat.Size = new System.Drawing.Size(658, 268);
            this.txtChat.TabIndex = 0;
            this.txtChat.Text = "";
            // 
            // txtUserMessage
            // 
            this.txtUserMessage.Location = new System.Drawing.Point(34, 355);
            this.txtUserMessage.Name = "txtUserMessage";
            this.txtUserMessage.Size = new System.Drawing.Size(653, 74);
            this.txtUserMessage.TabIndex = 1;
            this.txtUserMessage.Text = "";
            // 
            // cmdSendMessage
            // 
            this.cmdSendMessage.Image = ((System.Drawing.Image)(resources.GetObject("cmdSendMessage.Image")));
            this.cmdSendMessage.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cmdSendMessage.Location = new System.Drawing.Point(706, 364);
            this.cmdSendMessage.Name = "cmdSendMessage";
            this.cmdSendMessage.Size = new System.Drawing.Size(38, 38);
            this.cmdSendMessage.TabIndex = 2;
            this.cmdSendMessage.UseVisualStyleBackColor = true;
            this.cmdSendMessage.Click += new System.EventHandler(this.cmdSendMessage_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(111, 325);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(124, 20);
            this.txtUserName.TabIndex = 3;
            // 
            // lblNick
            // 
            this.lblNick.AutoSize = true;
            this.lblNick.Location = new System.Drawing.Point(31, 328);
            this.lblNick.Name = "lblNick";
            this.lblNick.Size = new System.Drawing.Size(74, 13);
            this.lblNick.TabIndex = 4;
            this.lblNick.Text = "My NickName";
            // 
            // frmChatRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 441);
            this.Controls.Add(this.lblNick);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.cmdSendMessage);
            this.Controls.Add(this.txtUserMessage);
            this.Controls.Add(this.txtChat);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmChatRoom";
            this.Text = "Чат";
            this.Load += new System.EventHandler(this.frmChatRoom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtChat;
        private System.Windows.Forms.RichTextBox txtUserMessage;
        private System.Windows.Forms.Button cmdSendMessage;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblNick;
    }
}