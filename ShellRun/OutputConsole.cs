using System;
using System.Diagnostics;
using System.Windows.Forms;

using ShellRunner.Core;

namespace ShellRunner
{
    public partial class OutputConsole : Form
    {
        public delegate void InputWritten(string input);
        public event InputWritten OnInputWritten;

        public delegate void UserExiting();
        public event UserExiting OnUserExiting;

        private ProcessExecutor _executor;

        public OutputConsole(ProcessExecutor process)
        {
            InitializeComponent();
            _executor = process;
            _executor.Process.Exited += (sender, e) =>
            {
                Invoke(() =>
                {
                    WriteInputBtn.Enabled = false;
                    WriteInputTextBox.Enabled = false;
                });
            };

            _executor.OnOutputDataReceived += (data) =>
            {
                AppendText(data);
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
            //OnInputWritten?.Invoke(WriteInputTextBox.Text);

            _executor.WriteToStdInput(WriteInputTextBox.Text);
        }

        private void OutputConsole_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Kill the process before disposing the form
            if (_executor.Process != null && !_executor.Process.HasExited)
            {
                _executor.Process.Kill();
            }

            OnUserExiting?.Invoke();
        }
    }
}
