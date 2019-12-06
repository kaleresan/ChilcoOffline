using System;
using System.IO;

namespace Chilco
{
    internal static class FileIO
    {
       
        private static readonly string groupPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), @"settings.json");
        
        public static Group[] LoadGroups()
        {
            if (File.Exists(groupPath))
            {
                string json = File.ReadAllText(groupPath);
                return Newtonsoft.Json.JsonConvert.DeserializeObject<Group[]>(json);
            }

            return new Group[0];
        }

        public static void SaveGroups(Group[] groups)
        {
            File.Create(groupPath).Close();
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(groups);
            File.WriteAllText(groupPath, json);
        }
    }
}