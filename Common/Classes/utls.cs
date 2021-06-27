using System;
using System.Drawing;
using System.Windows.Forms;

namespace Common.UIUtls
{
    public static class utls
    {

        public static void AppendTextToRichTextBox(RichTextBox rtb, string text, Color color, Font font, bool fromNewLine = true)
        {
            rtb.SuspendLayout();
            rtb.SelectionStart = rtb.TextLength;
            rtb.SelectionLength = 0;

            rtb.SelectionColor = color;
            rtb.SelectionFont = font;
            //rtb.SelectionBackColor = backColor;
            rtb.AppendText(fromNewLine ? $"{text}{ Environment.NewLine}" : text);

            rtb.SelectionColor = rtb.ForeColor;
            rtb.ScrollToCaret();
            rtb.ResumeLayout();
        }

    }
}
