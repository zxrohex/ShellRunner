using System.ComponentModel;
using System.Diagnostics;

using ShellRunner.Core;

namespace ShellRunner
{
    public partial class MainForm : Form
    {
        private ProcessExecutor _executor;

        public MainForm()
        {
            InitializeComponent();

            ExecutionTypeComboBox.SelectedIndex = 0;

            SystemInformationLabel.Text = $"OS: {Environment.OSVersion.Platform} {Environment.OSVersion.VersionString} | User: {Environment.UserName}";
        }

        private void SelectFile()
        {
            using (OpenFileDialog ofd = new OpenFileDialog()
            {
                Title = "Datei auswählen ...",
                Filter = "All Files|*.*",
                Multiselect = false
            })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    FileTextBox.Text = ofd.FileName;
                }
            }
        }

        private void SelectFileBtn_Click(object sender, EventArgs e)
        {
            SelectFile();
        }

        private void ExecuteBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FileTextBox.Text))
            {
                MessageBox.Show("Wähle eine Datei aus!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (FileTextBox.Text.Length > 0)
            {

                try
                {
                    _executor = ProcessExecutor.Create(FileTextBox.Text, ArgsTextBox.Text, (ExecutionType)ExecutionTypeComboBox.SelectedIndex);

                    if (_executor.OutputIsRedirected)
                    {
                        OutputConsole oc = new OutputConsole(_executor);

                        oc.Show();
                    }

                    _executor.Run();
                }
                catch (Win32Exception winEx)
                {
                    MessageBox.Show(winEx.Message, "Error executing file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void ExecutionTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ExecutionTypeComboBox.SelectedIndex)
            {
                case 0:
                    RedirectAllOutputCheckBox.Enabled = false;
                    RedirectAllOutputCheckBox.Checked = true;

                    break;
                case 1:
                    RedirectAllOutputCheckBox.Enabled = false;
                    RedirectAllOutputCheckBox.Checked = false;

                    break;
                case 2:
                    RedirectAllOutputCheckBox.Enabled = false;
                    RedirectAllOutputCheckBox.Checked = false;

                    break;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ExecuteBtn.PerformClick();
            }
        }

        private void überToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"ShellRunner v{System.Reflection.Assembly.GetExecutingAssembly().GetName().Version}\n\n© 2025 by Sasha", "Über", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
