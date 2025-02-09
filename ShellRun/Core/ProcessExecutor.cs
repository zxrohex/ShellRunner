using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellRunner.Core
{
    public enum ExecutionType
    {
        Execute = 0,
        ShellExecute = 1,
        CmdExecute = 2
    }

    public class ProcessExecutor
    {
        public string File { get; private set; }

        public string Arguments { get; private set; }

        public Process Process { get; private set; }

        public ProcessStartInfo StartInfo { get; private set; }

        public bool OutputIsRedirected => StartInfo.RedirectStandardOutput && StartInfo.RedirectStandardError;

        public delegate void OutputDataReceived(string data);
        public event OutputDataReceived OnOutputDataReceived;

        public delegate void Exited();
        public event Exited OnExited;

        public bool IsExited => Process.HasExited;

        public Stopwatch Stopwatch { get; private set; }

        private ProcessExecutor(string file, string arguments, ProcessStartInfo startInfo)
        {
            File = file;
            Arguments = arguments;

            StartInfo = startInfo;

            Process = new Process()
            {
                StartInfo = StartInfo,
                EnableRaisingEvents = true
            };

            Process.Exited += (sender, e) =>
            {
                Stopwatch.Stop();

                OnExited?.Invoke();
            };

        }

        public void Run()
        {
            
            Process.Start();

            (Stopwatch = new Stopwatch()).Start();

            if (StartInfo.RedirectStandardOutput)
            {
                Process.BeginOutputReadLine();

                Process.OutputDataReceived += (sender, e) =>
                {
                    if (e.Data != null)
                    {
                        OnOutputDataReceived?.Invoke(e.Data);
                    }
                };
            }

            if (StartInfo.RedirectStandardError)
            {
                Process.BeginErrorReadLine();

                Process.ErrorDataReceived += (sender, e) =>
                {
                    if (e.Data != null)
                    {
                        OnOutputDataReceived?.Invoke(e.Data);
                    }
                };
            }

        }

        public void Kill()
        {
            if (!Process.HasExited)
            {
                Process.Kill();

                Stopwatch.Stop();
            }
        }

        public void WriteToStdInput(string data)
        {
            if (!Process.HasExited && StartInfo.RedirectStandardInput)
            {
                Process.StandardInput.WriteLine(data);
            }
        }

        public static ProcessExecutor Create(string file, ExecutionType executionType)
        {
            switch (executionType)
            {
                case ExecutionType.Execute:
                    return CreateExecute(file);

                case ExecutionType.ShellExecute:
                    return CreateShellExecute(file);

                case ExecutionType.CmdExecute:
                    return CreateCmdExecute(file);

                default:
                    return null;
            }
        }

        public static ProcessExecutor Create(string file, string arguments, ExecutionType executionType)
        {
            switch (executionType)
            {
                case ExecutionType.Execute:
                    return CreateExecute(file, arguments);

                case ExecutionType.ShellExecute:
                    return CreateShellExecute(file, arguments);

                case ExecutionType.CmdExecute:
                    return CreateCmdExecute(file, arguments);

                default:
                    return null;
            }
        }

        public static ProcessExecutor Create(string file, string arguments, bool createNoWindow, ExecutionType executionType)
        {
            switch (executionType)
            {
                case ExecutionType.Execute:
                    return CreateExecute(file, arguments, createNoWindow);

                case ExecutionType.ShellExecute:
                    return CreateShellExecute(file, arguments, createNoWindow);

                case ExecutionType.CmdExecute:
                    return CreateCmdExecute(file, arguments, createNoWindow);

                default:
                    return null;
            }
        }

        public static ProcessExecutor CreateExecute(string file, string arguments = "", bool createNoWindow = true)
        {
            return new ProcessExecutor(file, arguments, new ProcessStartInfo()
            {
                FileName = file,
                Arguments = arguments,
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                RedirectStandardInput = true,
                CreateNoWindow = createNoWindow
            });
        }

        public static ProcessExecutor CreateShellExecute(string file, string arguments = "", bool createNoWindow = true)
        {
            return new ProcessExecutor(file, arguments, new ProcessStartInfo()
            {
                FileName = file,
                Arguments = arguments,
                UseShellExecute = true,
                CreateNoWindow = createNoWindow
            });
        }

        public static ProcessExecutor CreateCmdExecute(string file, string arguments = "", bool createNoWindow = true)
        {
            return new ProcessExecutor("cmd.exe", arguments, new ProcessStartInfo()
            {
                FileName = "cmd.exe",
                Arguments = $"/k {file} {arguments}",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                RedirectStandardInput = true,
                CreateNoWindow = createNoWindow
            });
        }
    }
}
