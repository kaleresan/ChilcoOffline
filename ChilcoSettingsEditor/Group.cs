using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Chilco
{
    internal class Group
    {
        public TimeSpan LeftoverTime;
        public DateTime DateLastRun;
        public Ruleset ruleset;
        public static List<Group> GetGroups { get; private set; } = new List<Group>();

        [JsonConstructor]
        public Group(string Key, string Title, List<String> Processes, TimeSpan LeftoverTime, bool DoTimeRollover, DateTime DateLastRun, TimeSpan DailyPlaytime, TimeSpan MaxPlaytime, bool[] Weekdays)
        {
            this.LeftoverTime = LeftoverTime;
            this.DateLastRun = DateLastRun;
            this.ruleset = new Ruleset(Key, Title, Processes, DoTimeRollover, DailyPlaytime, MaxPlaytime, Weekdays);
        }

        public Group(TimeSpan leftoverTime, DateTime dateLastRun, Ruleset ruleset)
        {
            this.LeftoverTime = leftoverTime;
            this.DateLastRun = dateLastRun;
            this.ruleset = ruleset;
        }

        public struct Ruleset
        {
            public string Key;
            public string Title;
            public List<string> Processes;
            public bool DoTimeRollover;
            public TimeSpan DailyPlaytime;
            public TimeSpan MaxPlaytime;
            public bool[] Weekdays;
            [JsonConstructor]
            public Ruleset(string Key, string Title, List<string> Processes, bool DoTimeRollover, TimeSpan DailyPlaytime, TimeSpan MaxPlaytime, bool[] Weekdays)
            {
                this.Key = Key;
                this.Title = Title;
                this.Processes = Processes;
                this.DoTimeRollover = DoTimeRollover;
                this.DailyPlaytime = DailyPlaytime;
                this.MaxPlaytime = MaxPlaytime;
                if (Weekdays != null)
                    this.Weekdays = Weekdays;
                else
                    this.Weekdays = new bool[] {true, true, true, true, true, true, true};
            }
        }
    }
}