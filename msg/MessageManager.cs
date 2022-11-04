using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace term
{
    public static class MessageManager
    {
        public static void ShowHint(MessageType t, string text)
        {
            switch (t)
            {
                case MessageType.Information:
                    {
                        MessageBox.Show("Hinweis", text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                case MessageType.Error:
                    {
                        MessageBox.Show("Fehler", text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                case MessageType.Question:
                    {
                        MessageBox.Show("Frage", text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        // TODO: Add function to detect whether yes or no has been selected.

                        break;
                    }
            }
        }

        public enum MessageType
        {
            Information,
            Error,
            Question,
            LAST_INDEX
        }
    }
}
