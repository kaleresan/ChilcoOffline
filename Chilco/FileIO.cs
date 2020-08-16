using System;
using System.IO;

namespace Chilco
{
    internal static class FileIO
    {
       
        private static readonly string groupPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), @"settings.json");
        private static readonly string defaultGroupPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), @"default_settings.json");

        public static Group[] LoadGroups()
        {
            Group[] groups = null;

            groups = Loadfile(groupPath);
            if (groups != null) return groups;

            groups = Loadfile(defaultGroupPath);
            if (groups != null) return groups;

            return new Group[0];
        }
        private static Group[] Loadfile(string path)
        {
            try
            {
                if (File.Exists(path))
                {
                    string json = File.ReadAllText(path);
                    if (json != null && json != "")
                    {
                        return Newtonsoft.Json.JsonConvert.DeserializeObject<Group[]>(json);
                    }
                }
                return null;
            }
            catch (Exception) { return null; }
        }
        public static void SaveGroups(Group[] groups)
        {
            File.Create(groupPath).Close();
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(groups);
            File.WriteAllText(groupPath, json);
        }
    }
}