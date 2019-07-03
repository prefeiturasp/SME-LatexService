using System.Diagnostics;

namespace LatexService.Business.Extensions
{
    public static class ShellHelper
    {
        public static string Bash(this string cmd)
        {
            string escapeArgs = cmd.Replace("\"", "\\\"");

            var process = new Process()
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "/bin/bash",
                    Arguments = $"-c \"{escapeArgs}\"",
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };

            process.Start();
            string result = process.StandardOutput.ReadToEnd();
            process.WaitForExit();

            return (result);
        }
    }
}