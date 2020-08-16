using System.Diagnostics;
using System.Linq;

namespace Chilco
{
    internal static class Butcher
    {
        public static void KillProcesses(Group group)
        {
            //For every Process in the Processgroup
            foreach (string s in group.ruleset.Processes)
            {
                KillProcess(s);
            }
        }

        private static void KillProcess(string processName)
        {
            //For every Process currently running that has the name s
            foreach (Process p in Process.GetProcesses().Where(
                p2 => string.Equals(p2.ProcessName, processName, System.StringComparison.OrdinalIgnoreCase) || 
                (string.Equals(p2.MainWindowTitle, processName, System.StringComparison.OrdinalIgnoreCase) && 
                p2.MainWindowTitle != "" && 
                processName != "")))
            {
                //Checks if process is actually running
                //(sometimes the Process closes itself before being killed and Chilco crashes)
                if (Process.GetProcesses().Count(p3 => string.Equals(p3.ProcessName, processName, System.StringComparison.OrdinalIgnoreCase) ||
                    (string.Equals(p3.MainWindowTitle, processName, System.StringComparison.OrdinalIgnoreCase) && 
                    p3.MainWindowTitle != "" && 
                    processName != "")) > 0)
                {
                    p.Kill();
                }
            }
        }
    }
}