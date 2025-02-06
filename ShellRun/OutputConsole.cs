using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ShellRun
{
    public partial class OutputConsole : Form
    {
        public delegate void InputWritten(string input);
        public event InputWritten OnInputWritten;

        public delegate void UserExiting();
        public event UserExiting OnUserExiting;

        private Process _process;

        public OutputConsole(Process process)
        {
            InitializeComponent();
            _process = process;
            _process.Exited += (sender, e) =>
            {
                Invoke(() =>
                {
                    WriteInputBtn.Enabled = false;
                    WriteInputTextBox.Enabled = false;
                });
            };
        }

        public void AppendText(string text)
        { 

            Invoke(() =>
            {
                OutputRichTextBox.AppendText(text + "\n");
            });
        }

        private void WriteInputBtn_Click(object sender, EventArgs e)
        {
            OnInputWritten?.Invoke(WriteInputTextBox.Text);
        }

        private void OutputConsole_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Kill the process before disposing the form
            if (_process != null && !_process.HasExited)
            {
                _process.Kill();
            }

            OnUserExiting?.Invoke();
        }
    }
}
