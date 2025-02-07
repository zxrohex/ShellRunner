using System.ComponentModel;
using System.Diagnostics;

namespace ShellRunner
{
    public partial class MainForm : Form
    {
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

        private ProcessStartInfo CreateStartInfo(string file, int type = 0, string args = "")
        {
            return type switch
            {
                0 => new ProcessStartInfo(file)
                {
                    UseShellExecute = false,
                    RedirectStandardError = RedirectAllOutputCheckBox.Checked,
                    RedirectStandardOutput = RedirectAllOutputCheckBox.Checked,
                    RedirectStandardInput = RedirectAllOutputCheckBox.Checked,
                    CreateNoWindow = CreateNoWindowCheckBox.Checked,
                    Arguments = args,
                    FileName = file,
                    LoadUserProfile = LoadUserProfileCheckBox.Checked
                },
                1 => new ProcessStartInfo("explorer.exe")
                {
                    UseShellExecute = true,
                    CreateNoWindow = CreateNoWindowCheckBox.Checked,
                    FileName = file,
                    Arguments = args,
                    LoadUserProfile = LoadUserProfileCheckBox.Checked
                },
                2 => new ProcessStartInfo("cmd.exe")
                {
                    UseShellExecute = false,
                    CreateNoWindow = CreateNoWindowCheckBox.Checked,
                    FileName = "cmd.exe",
                    Arguments = $"/c {args}",
                    LoadUserProfile = LoadUserProfileCheckBox.Checked
                }
            };
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
                ProcessStartInfo psi = CreateStartInfo(FileTextBox.Text, ExecutionTypeComboBox.SelectedIndex, ArgsTextBox.Text);

                try
                {
                    if (RedirectAllOutputCheckBox.Checked)
                    {
                        RunAsync(psi);

                    }
                    else
                    {
                        Process.Start(psi);
                    }
                }
                catch (Win32Exception winEx)
                {
                    MessageBox.Show(winEx.Message, "Error executing file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }


        private void RunAsync(ProcessStartInfo psi)
        {
            Process p = new Process()
            {
                StartInfo = psi,
                EnableRaisingEvents = true
            };

            OutputConsole oc = new OutputConsole(p);


            p.OutputDataReceived += (sender, e) =>
            {
                if (e.Data != null && !p.HasExited)
                {
                    oc.AppendText(e.Data);
                }
            };
            p.ErrorDataReceived += (sender, e) =>
            {
                if (e.Data != null && !p.HasExited)
                {
                    oc.AppendText(e.Data);
                }
            };


            oc.OnInputWritten += (input) =>
            {
                if (!p.HasExited)
                {
                    p.StandardInput.WriteLine(input);
                }

            };

            oc.OnUserExiting += () =>
            {
                if (!p.HasExited)
                {
                    p.Kill();
                }
            };

            oc.Show();

            p.Start();
            p.BeginOutputReadLine();
            p.BeginErrorReadLine();
        }

        private void ExecutionTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ExecutionTypeComboBox.SelectedIndex)
            {
                case 0:
                    RedirectAllOutputCheckBox.Enabled = true;

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
