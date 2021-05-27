using System;
using System.Windows.Forms;

namespace Common.Settings
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
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.pnlData = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabCommon = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pnlMsgSendKey = new System.Windows.Forms.Panel();
            this.rbSendByCtrlEnter = new System.Windows.Forms.RadioButton();
            this.rbSendByCtrl = new System.Windows.Forms.RadioButton();
            this.btnApply = new System.Windows.Forms.Button();
            this.lblServerIP = new System.Windows.Forms.Label();
            this.txtServerIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlButtons.SuspendLayout();
            this.pnlData.SuspendLayout();
            this.tabs.SuspendLayout();
            this.tabCommon.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.pnlMsgSendKey.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButtons
            // 
            this.pnlButtons.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlButtons.Controls.Add(this.btnApply);
            this.pnlButtons.Controls.Add(this.btnCancel);
            this.pnlButtons.Controls.Add(this.btnSave);
            this.pnlButtons.Location = new System.Drawing.Point(0, 367);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(800, 58);
            this.pnlButtons.TabIndex = 0;
            // 
            // statusBar
            // 
            this.statusBar.Location = new System.Drawing.Point(0, 428);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(800, 22);
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
            this.pnlData.Size = new System.Drawing.Size(800, 361);
            this.pnlData.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(690, 11);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(81, 32);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(499, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(77, 31);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabCommon);
            this.tabs.Controls.Add(this.tabPage2);
            this.tabs.Location = new System.Drawing.Point(20, 13);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(762, 330);
            this.tabs.TabIndex = 0;
            // 
            // tabCommon
            // 
            this.tabCommon.Controls.Add(this.txtLogin);
            this.tabCommon.Controls.Add(this.label1);
            this.tabCommon.Controls.Add(this.pnlMsgSendKey);
            this.tabCommon.Location = new System.Drawing.Point(4, 22);
            this.tabCommon.Name = "tabCommon";
            this.tabCommon.Padding = new System.Windows.Forms.Padding(3);
            this.tabCommon.Size = new System.Drawing.Size(754, 304);
            this.tabCommon.TabIndex = 0;
            this.tabCommon.Text = "Общее";
            this.tabCommon.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txtServerIP);
            this.tabPage2.Controls.Add(this.lblServerIP);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(754, 304);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Сеть";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pnlMsgSendKey
            // 
            this.pnlMsgSendKey.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlMsgSendKey.Controls.Add(this.rbSendByCtrl);
            this.pnlMsgSendKey.Controls.Add(this.rbSendByCtrlEnter);
            this.pnlMsgSendKey.Location = new System.Drawing.Point(24, 33);
            this.pnlMsgSendKey.Name = "pnlMsgSendKey";
            this.pnlMsgSendKey.Size = new System.Drawing.Size(157, 80);
            this.pnlMsgSendKey.TabIndex = 1;
            // 
            // rbSendByCtrlEnter
            // 
            this.rbSendByCtrlEnter.AutoSize = true;
            this.rbSendByCtrlEnter.Checked = true;
            this.rbSendByCtrlEnter.Location = new System.Drawing.Point(33, 20);
            this.rbSendByCtrlEnter.Name = "rbSendByCtrlEnter";
            this.rbSendByCtrlEnter.Size = new System.Drawing.Size(71, 17);
            this.rbSendByCtrlEnter.TabIndex = 1;
            this.rbSendByCtrlEnter.TabStop = true;
            this.rbSendByCtrlEnter.Text = "Ctrl+Enter";
            this.rbSendByCtrlEnter.UseVisualStyleBackColor = true;
            // 
            // rbSendByCtrl
            // 
            this.rbSendByCtrl.AutoSize = true;
            this.rbSendByCtrl.Location = new System.Drawing.Point(33, 43);
            this.rbSendByCtrl.Name = "rbSendByCtrl";
            this.rbSendByCtrl.Size = new System.Drawing.Size(40, 17);
            this.rbSendByCtrl.TabIndex = 2;
            this.rbSendByCtrl.Text = "Ctrl";
            this.rbSendByCtrl.UseVisualStyleBackColor = true;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(592, 9);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(80, 36);
            this.btnApply.TabIndex = 2;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
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
            // txtServerIP
            // 
            this.txtServerIP.Location = new System.Drawing.Point(71, 25);
            this.txtServerIP.Name = "txtServerIP";
            this.txtServerIP.Size = new System.Drawing.Size(116, 20);
            this.txtServerIP.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "UserLogin";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(85, 128);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(96, 20);
            this.txtLogin.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Server port";
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.pnlButtons);
            this.Name = "frmSettings";
            this.Text = "Настройки";
            this.pnlButtons.ResumeLayout(false);
            this.pnlData.ResumeLayout(false);
            this.tabs.ResumeLayout(false);
            this.tabCommon.ResumeLayout(false);
            this.tabCommon.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.pnlMsgSendKey.ResumeLayout(false);
            this.pnlMsgSendKey.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabCommon;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel pnlMsgSendKey;
        private System.Windows.Forms.RadioButton rbSendByCtrl;
        private System.Windows.Forms.RadioButton rbSendByCtrlEnter;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.TextBox txtServerIP;
        private System.Windows.Forms.Label lblServerIP;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}