using System;
using System.Windows.Forms;

namespace Common.AppSettings
{
    partial class frmSettings
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
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.pnlData = new System.Windows.Forms.Panel();
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabCommon = new System.Windows.Forms.TabPage();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabNet = new System.Windows.Forms.TabPage();
            this.btnFillByLocalIP = new System.Windows.Forms.Button();
            this.txtServerPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtServerIP = new System.Windows.Forms.TextBox();
            this.lblServerIP = new System.Windows.Forms.Label();
            this.tabMisc = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlButtons.SuspendLayout();
            this.pnlData.SuspendLayout();
            this.tabs.SuspendLayout();
            this.tabCommon.SuspendLayout();
            this.tabNet.SuspendLayout();
            this.tabMisc.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButtons
            // 
            this.pnlButtons.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlButtons.Controls.Add(this.btnApply);
            this.pnlButtons.Controls.Add(this.btnCancel);
            this.pnlButtons.Location = new System.Drawing.Point(0, 238);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(800, 58);
            this.pnlButtons.TabIndex = 0;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(592, 9);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(80, 36);
            this.btnApply.TabIndex = 2;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(499, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(77, 31);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // statusBar
            // 
            this.statusBar.Location = new System.Drawing.Point(0, 308);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(822, 22);
            this.statusBar.TabIndex = 1;
            this.statusBar.Text = "statusStrip1";
            // 
            // pnlData
            // 
            this.pnlData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlData.Controls.Add(this.tabs);
            this.pnlData.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlData.Location = new System.Drawing.Point(0, 0);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(822, 232);
            this.pnlData.TabIndex = 2;
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabCommon);
            this.tabs.Controls.Add(this.tabNet);
            this.tabs.Controls.Add(this.tabMisc);
            this.tabs.Location = new System.Drawing.Point(20, 13);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(762, 210);
            this.tabs.TabIndex = 0;
            // 
            // tabCommon
            // 
            this.tabCommon.Controls.Add(this.txtLogin);
            this.tabCommon.Controls.Add(this.label1);
            this.tabCommon.Location = new System.Drawing.Point(4, 22);
            this.tabCommon.Name = "tabCommon";
            this.tabCommon.Padding = new System.Windows.Forms.Padding(3);
            this.tabCommon.Size = new System.Drawing.Size(754, 184);
            this.tabCommon.TabIndex = 0;
            this.tabCommon.Text = "Общее";
            this.tabCommon.UseVisualStyleBackColor = true;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(69, 31);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(189, 20);
            this.txtLogin.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "UserLogin";
            // 
            // tabNet
            // 
            this.tabNet.Controls.Add(this.btnFillByLocalIP);
            this.tabNet.Controls.Add(this.txtServerPort);
            this.tabNet.Controls.Add(this.label2);
            this.tabNet.Controls.Add(this.txtServerIP);
            this.tabNet.Controls.Add(this.lblServerIP);
            this.tabNet.Location = new System.Drawing.Point(4, 22);
            this.tabNet.Name = "tabNet";
            this.tabNet.Padding = new System.Windows.Forms.Padding(3);
            this.tabNet.Size = new System.Drawing.Size(754, 184);
            this.tabNet.TabIndex = 1;
            this.tabNet.Text = "Сеть";
            this.tabNet.UseVisualStyleBackColor = true;
            // 
            // btnFillByLocalIP
            // 
            this.btnFillByLocalIP.Location = new System.Drawing.Point(203, 21);
            this.btnFillByLocalIP.Name = "btnFillByLocalIP";
            this.btnFillByLocalIP.Size = new System.Drawing.Size(83, 26);
            this.btnFillByLocalIP.TabIndex = 4;
            this.btnFillByLocalIP.Text = "IP локал";
            this.btnFillByLocalIP.UseVisualStyleBackColor = true;
            this.btnFillByLocalIP.Click += new System.EventHandler(this.btnFillByLocalIP_Click);
            // 
            // txtServerPort
            // 
            this.txtServerPort.Location = new System.Drawing.Point(72, 63);
            this.txtServerPort.Name = "txtServerPort";
            this.txtServerPort.Size = new System.Drawing.Size(115, 20);
            this.txtServerPort.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Server port";
            // 
            // txtServerIP
            // 
            this.txtServerIP.Location = new System.Drawing.Point(71, 25);
            this.txtServerIP.Name = "txtServerIP";
            this.txtServerIP.Size = new System.Drawing.Size(116, 20);
            this.txtServerIP.TabIndex = 1;
            // 
            // lblServerIP
            // 
            this.lblServerIP.AutoSize = true;
            this.lblServerIP.Location = new System.Drawing.Point(6, 25);
            this.lblServerIP.Name = "lblServerIP";
            this.lblServerIP.Size = new System.Drawing.Size(51, 13);
            this.lblServerIP.TabIndex = 0;
            this.lblServerIP.Text = "Server IP";
            // 
            // tabMisc
            // 
            this.tabMisc.Controls.Add(this.label3);
            this.tabMisc.Controls.Add(this.panel1);
            this.tabMisc.Location = new System.Drawing.Point(4, 22);
            this.tabMisc.Name = "tabMisc";
            this.tabMisc.Padding = new System.Windows.Forms.Padding(3);
            this.tabMisc.Size = new System.Drawing.Size(754, 184);
            this.tabMisc.TabIndex = 2;
            this.tabMisc.Text = "Дополнительно";
            this.tabMisc.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Location = new System.Drawing.Point(38, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(136, 71);
            this.panel1.TabIndex = 2;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(21, 43);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(40, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.Text = "Ctrl";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(21, 20);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(71, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Ctrl+Enter";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Отправлять сообщения по комбинации клавиш";
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 330);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.pnlButtons);
            this.Name = "frmSettings";
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.Shown += new System.EventHandler(this.frmSettings_Shown);
            this.pnlButtons.ResumeLayout(false);
            this.pnlData.ResumeLayout(false);
            this.tabs.ResumeLayout(false);
            this.tabCommon.ResumeLayout(false);
            this.tabCommon.PerformLayout();
            this.tabNet.ResumeLayout(false);
            this.tabNet.PerformLayout();
            this.tabMisc.ResumeLayout(false);
            this.tabMisc.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabCommon;
        private System.Windows.Forms.TabPage tabNet;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.TextBox txtServerIP;
        private System.Windows.Forms.Label lblServerIP;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private TextBox txtServerPort;
        private Button btnFillByLocalIP;
        private TabPage tabMisc;
        private Label label3;
        private Panel panel1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
    }
}