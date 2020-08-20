using IWshRuntimeLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static Chilco.Group;

namespace Chilco
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            List<Ruleset> RulesetList;
            Console.WriteLine("Chilco is starting...");
            Group[] groups = FileIO.LoadGroups();
            if (groups == null || groups.Length == 0)
            {
                Console.WriteLine("no Groups saved, getting default rulesets");
                RulesetList = CreateDefaultRulesets();
            }
            else
            {
                Console.WriteLine("Reading saved rulesets");
                RulesetList = groups.Select(group => group.ruleset).ToList();
            }
            Chilco.Main.Update(RulesetList);
        }

        private static List<Ruleset> CreateDefaultRulesets()
        {
            List<Ruleset> RulesetList = new List<Ruleset>() {
                    new Ruleset() {
                        Key = "Default1",
                        Title = "Browser",
                        Processes = new List<string>()
                                    {
                                        "Firefox",
                                        "Chrome"
                                    },
                        DoTimeRollover = true,
                        DailyPlaytime = new TimeSpan(0, 0, 30, 0, 0),
                        MaxPlaytime = new TimeSpan(0, 0, 0, 0, 0),
                        Weekdays = new bool[]{true, true, true, true, true, true, true }
                    } ,

                    new Ruleset() {
                        Key = "Default2",
                        Title = "Spotify",
                        Processes = new List<string>()
                                    {
                                        "Spotify"
                                    },
                        DoTimeRollover = true,
                        DailyPlaytime = new TimeSpan(0, 2, 0, 0, 0),
                        MaxPlaytime = new TimeSpan(0, 0, 0, 0, 0),
                        Weekdays = new bool[]{true, true, true, true, true, true, true }
                    } ,

                    new Ruleset() {
                        Key = "Default3",
                        Title = "Malicious Utilities",
                        Processes = new List<string>()
                                    {
                                        "cmd",
                                        "PowerShell",
                                        "Taskmgr"
                                    },
                        DoTimeRollover = false,
                        DailyPlaytime = new TimeSpan(0, 0, 0, 0, 0),
                        MaxPlaytime = new TimeSpan(0, 0, 0, 0, 0),
                        Weekdays = new bool[]{true, true, true, true, true, true, true }
                    } 
                };

            return RulesetList;
        }
    }
}