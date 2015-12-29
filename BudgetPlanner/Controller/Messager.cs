using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace BudgetPlanner.Controller
{
    public class Messager
    {
        private const String _fileOpenErrorMessage = "Error opening file:";
        private const String _fileSaveErrorMessage = "Error saving file:";
        private static String _caption;

        public static string Caption
        {
            get
            {
                return _caption;
            }
            set
            {
                _caption = value;
            }
        }

        public static void ShowException(Exception ex)
        {
            Show(ex.Message, Controller.Constants.APPLICATION_NAME, MessageBoxIcon.Error, MessageBoxButtons.OK);
        }

        public static void ShowMessage(string message)
        {
            Show(message, Controller.Constants.APPLICATION_NAME, MessageBoxIcon.Exclamation, MessageBoxButtons.OK);
        }

        public static void ShowMessage(string message, MessageBoxIcon icon)
        {
            Show(message, Controller.Constants.APPLICATION_NAME, icon, MessageBoxButtons.OK);
        }

        public static void ShowWarning(Exception ex)
        {
            Show(ex.Message, Controller.Constants.APPLICATION_NAME, MessageBoxIcon.Exclamation, MessageBoxButtons.OK);
        }

        public static void ShowWarning(string message)
        {
            Show(message, Controller.Constants.APPLICATION_NAME, MessageBoxIcon.Exclamation, MessageBoxButtons.OK);
        }

        public static DialogResult ShowQuestion(string message, MessageBoxButtons buttons)
        {
            return Show(message, Controller.Constants.APPLICATION_NAME, MessageBoxIcon.Question, buttons);
        }

        public static DialogResult ShowQuestion(string message, MessageBoxIcon icon, MessageBoxButtons buttons)
        {
            return Show(message, Controller.Constants.APPLICATION_NAME, icon, buttons);
        }

        public static void Show(Exception ex, MessageBoxIcon icon)
        {
            Show(ex.Message, Controller.Constants.APPLICATION_NAME, icon, MessageBoxButtons.OK);
        }

        public static void ShowFileOpenError(string fileName, Exception ex)
        {
            if (fileName != null && fileName != string.Empty)
            {
                if (ex != null)
                    Show(String.Format("{0}{2}{1}{2}{2}{3}", _fileOpenErrorMessage, fileName, Environment.NewLine, ex.Message), Controller.Constants.APPLICATION_NAME, MessageBoxIcon.Exclamation, MessageBoxButtons.OK);
                else
                    Show(String.Format("{0}{1}", _fileOpenErrorMessage, fileName), Controller.Constants.APPLICATION_NAME, MessageBoxIcon.Exclamation, MessageBoxButtons.OK);
            }
            else
            {
                if (ex != null)
                    Show(String.Format("{0}{1}{1}{2}", _fileOpenErrorMessage, Environment.NewLine, ex.Message), Controller.Constants.APPLICATION_NAME, MessageBoxIcon.Exclamation, MessageBoxButtons.OK);
                else
                    Show(_fileOpenErrorMessage, Controller.Constants.APPLICATION_NAME, MessageBoxIcon.Exclamation, MessageBoxButtons.OK);
            }
        }

        public static void ShowFileSaveError(string fileName, Exception ex)
        {
            if (fileName != null && fileName != String.Empty)
            {
                if (ex != null)
                    ShowMessage(String.Format("{0}{2}{1}{2}{2}{3}", _fileSaveErrorMessage, fileName, Environment.NewLine, ex.Message));
                else
                    ShowMessage(String.Format("{0}{1}", _fileSaveErrorMessage, fileName));
            }
            else
            {
                if (ex != null)
                    ShowMessage(String.Format("{0}{1}{1}{2}", _fileSaveErrorMessage, Environment.NewLine, ex.Message));
                else
                    ShowMessage(_fileSaveErrorMessage);
            }
        }

        public static DialogResult Show(string message, string appName, MessageBoxIcon icon, MessageBoxButtons buttons)
        {
            //Caption = Controller.Constants.APPLICATION_NAME;
            return MessageBox.Show(message, appName, buttons, icon);
        }
    }
}
