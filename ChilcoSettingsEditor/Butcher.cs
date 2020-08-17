using System.Diagnostics;
using System.Linq;

namespace Chilco
{
    internal static class Butcher
    {
        public static void KillProcess(string processName)
        {
            while (Process.GetProcesses().Count(p => string.Equals(p.ProcessName, processName, System.StringComparison.OrdinalIgnoreCase) && !p.HasExited) > 0)
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