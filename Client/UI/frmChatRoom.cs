using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Common;
using Common.AppSettings;

namespace Client.UI
{
    public partial class frmChatRoom : Form
    {
        public frmChatRoom()
        {
            InitializeComponent();
        }

        private void frmChatRoom_Load(object sender, EventArgs e)
        {
            txtUserName.Text = Globals.CurrUser.Login;
        }

       // Добавить к чату- сообщение, введенное пользователем
       private void cmdSendMessage_Click(object sender, EventArgs e)
        {
            txtChat.AppendText(Environment.NewLine); //  Добавить символ перевода строки

            Font font = new Font("Cambria", 10, FontStyle.Bold);
            AppendTextToChat(txtChat, txtUserName.Text, Color.Blue, font);

            font = new Font("Cambria", 10, FontStyle.Regular);
            AppendTextToChat(txtChat, txtUserMessage.Text, Color.Blue, font);

        }
        private void AppendTextToChat( RichTextBox rtb, string text, Color color, Font font,  bool isNewLine = true)
        {
            rtb.SuspendLayout();
            rtb.SelectionStart = rtb.TextLength;
            rtb.SelectionLength = 0;

            rtb.SelectionColor = color;
            rtb.SelectionFont = font;
            //rtb.SelectionBackColor = backColor;
            rtb.AppendText(isNewLine ? $"{text}{ Environment.NewLine}" : text);

            rtb.SelectionColor = rtb.ForeColor;
            rtb.ScrollToCaret();
            rtb.ResumeLayout();
        }

        private void mnuSettings_Click(object sender, EventArgs e)
        {
            frmSettings frmSettings = new frmSettings();
            frmSettings.ShowDialog(this);
        }

    }
}
