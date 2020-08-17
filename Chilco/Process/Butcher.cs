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
            if (Process.GetProcesses().Count(p => string.Equals(p.ProcessName, processName, System.StringComparison.OrdinalIgnoreCase)) > 0)
            {
                try
                {
                    Process.GetProcesses().First(p => string.Equals(p.ProcessName, processName, System.StringComparison.OrdinalIgnoreCase)).Kill();
                }catch(System.Exception e)
                {
                    System.Console.WriteLine("ERROR while killing process \"" + processName + "\""
                                            +"Message: \"" + e.Message + "\"");
                }
            }
        }
    }
}