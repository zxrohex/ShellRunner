using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;

using ShellRunner.Core;
using ShellRunner.Properties;

namespace ShellRunner
{
    public partial class MainForm : Form
    {
        ProcessExecutor _executor;

        bool isRunning = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void ProcessInformationUpdateTimer_Tick(object sender, EventArgs e)
        {
            Invoke(() =>
            {
                MainInfoToolStripStatusLabel.Text = $"PID: {_executor.Process.Id} | {_executor.Stopwatch.Elapsed.ToString()}";


                try
                {
                    ProcessDescriptionLabel.Text = $"PID: {_executor.Process.Id} | SID: {_executor.Process.SessionId}";
                }
                catch (Win32Exception w32ex)
                {
                    ProcessDescriptionLabel.Text = $"Error: {w32ex.Message}";
                }

                try
                {
                    ProcessMoreInfoLabel.Text = $"Start Time: {_executor.Process.StartTime} | Threads: {_executor.Process.Threads.Count} \n" +
                        $"Working Set: {_executor.Process.WorkingSet64 / 1024 / 1024} MB";
                }
                catch (Win32Exception w32ex)
                {
                    ProcessMoreInfoLabel.Text = $"Error: {w32ex.Message}";
                }
            });
            

        }

        private void SwitchUI(int type)
        {
            Invoke(() =>
            {
                switch (type)
                {
                    case 0:
                        SettingsFileGroupBox.Enabled = true;
                        ExecutionSettingsTabControl.Enabled = true;
                        InfoStatusLabel.Text = $"Windows {Environment.OSVersion} | {Environment.UserName}";
                        MainToolStripStatusLabel.Text = "Idling";
                        MainInfoToolStripStatusLabel.Text = $"No process started yet.";
                        ProcessIconNdPictureBox.Image = null;
                        ProcessTitleLabel.Text = "No process started yet.";
                        ProcessDescriptionLabel.Text = $"Start a process.";
                        ProcessMoreInfoLabel.Text = $"Some more information will display here once you start a process.";

                        break;

                    case 1:
                        SettingsFileGroupBox.Enabled = false;
                        ExecutionSettingsTabControl.Enabled = false;

                        try
                        {
                            InfoStatusLabel.Text = $"{Path.GetFileName(_executor.Process.MainModule.FileName)}";
                        }
                        catch (Win32Exception w32ex)
                        {
                            InfoStatusLabel.Text = $"Error: {w32ex.Message}";
                        }

                        MainToolStripStatusLabel.Text = "Running";

                        try
                        {
                            MainInfoToolStripStatusLabel.Text = $"PID: {_executor.Process.Id} | {_executor.Stopwatch.Elapsed.ToString()}";

                        }
                        catch (Win32Exception w32ex)
                        {
                            MainInfoToolStripStatusLabel.Text = $"Error: {w32ex.Message}";
                        }

                        try
                        {
                            ProcessIconNdPictureBox.Image = Icon.ExtractAssociatedIcon(_executor.Process.MainModule.FileName).ToBitmap();
                        }
                        catch (Win32Exception w32ex)
                        {
                            ProcessIconNdPictureBox.Image = null;
                        }

                        try
                        {
                            ProcessTitleLabel.Text = Path.GetFileName(_executor.Process.MainModule.FileName);
                        }
                        catch (Win32Exception w32ex)
                        {
                            ProcessTitleLabel.Text = $"/";
                        }

                        try
                        {
                            ProcessDescriptionLabel.Text = $"PID: {_executor.Process.Id} | SID: {_executor.Process.SessionId}";
                        }
                        catch (Win32Exception w32ex)
                        {
                            ProcessDescriptionLabel.Text = $"PID: / | SID: /";
                        }

                        try
                        {
                            ProcessMoreInfoLabel.Text = $"Start Time: {_executor.Process.StartTime} | Threads: {_executor.Process.Threads.Count} \n" +
                                $"Working Set: {_executor.Process.WorkingSet64 / 1024 / 1024} MB";
                        }
                        catch (Win32Exception w32ex)
                        {
                            ProcessMoreInfoLabel.Text = $"Start Time: / | Threads: / \nWorking Set: /";
                        }

                        break;
                    default:
                        break;
                }
            });
            
        }

        private void RunOrKillButton_Click(object sender, EventArgs e)
        {
            if (!isRunning)
            {
                RunOrKillButton.Image = Resources.Stop;

                _executor = ProcessExecutor.Create(FileTextBox.Text, ArgsTextBox.Text, CreateNoWindowCheckBox.Checked,
                    (ExecutionType)ExecutionTypeComboBox.SelectedIndex);

                _executor.OnExited += () =>
                {
                    Log("Process exited.");
                    RunOrKillButton.Image = Resources.Run;
                    ProcessInformationUpdateTimer.Stop();
                    isRunning = false;
                    SwitchUI(0);
                };

                if (_executor.OutputIsRedirected)
                {
                    _executor.OnOutputDataReceived += (data) =>
                    {
                        Log(data);
                    };

                    StdInputTextBox.Enabled = true;

                    SendStdInputButton.Enabled = true;

                    SendStdInputButton.Click += (s, ev) =>
                    {
                        _executor.Process.StandardInput.WriteLine(StdInputTextBox.Text);
                    };
                }

                _executor.Run();

                isRunning = true;

                ProcessInformationUpdateTimer.Start();

                SwitchUI(1);
            }
            else
            {
                RunOrKillButton.Image = Resources.Run;

                ProcessInformationUpdateTimer.Stop();

                isRunning = false;

                _executor.Kill();

                SwitchUI(0);
            }
        }



        private void ExecutionTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ExecutionTypeComboBox.SelectedIndex)
            {
                case 0:
                    CreateNoWindowCheckBox.Enabled = true;
                    break;

                case 1:
                case 2:
                    CreateNoWindowCheckBox.Enabled = false;
                    CreateNoWindowCheckBox.Checked = false;
                    break;

                default:
                    break;
            }
        }

        private void Log(string message)
        {
            Invoke(() => { OutputLogRichTextBox.AppendText($"[{DateTime.Now}]: {message}\n"); });
        }

        private void SelectFileButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog()
            {
                Title = "Select an file ...",
                Filter = "Executable files (*.exe)|*.exe|All files (*.*)|*.*",
                Multiselect = false
            })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    FileTextBox.Text = ofd.FileName;
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Log($"ShellRunner, Version {Assembly.GetExecutingAssembly().GetName().Version}");
        }
    }
}