using System.Collections.Generic;

namespace Hack4Europe.Data
{
    public static class DataManager
    {
        public static bool ForceRefreshTimer { get; set; }
        public static bool HasToRequestNotifications { get; set; }
        public static string Token { get; set; }
        public static Dictionary<string, object> DataDictionary { get; set; }
        public static Dictionary<string, string> StorageFileDictionary { get; set; }

        static DataManager()
        {
            Token = null;
            ForceRefreshTimer = false;
            HasToRequestNotifications = false;
            DataDictionary = new Dictionary<string, object>();
            StorageFileDictionary = new Dictionary<string, string>();
        }

        public static void AddData(string key, string storageFileName, object content)
        {
            if (DataDictionary.ContainsKey(key))
                return;

            DataDictionary.Add(key, content);
            StorageFileDictionary.Add(key, storageFileName);
        }

        public static void LoadSettings<T>(string key)
        {
            var settings = (T)LocalData.GetSettings();

            if (settings != null)
                DataDictionary[key] = settings;
        }

        public static void SaveSettings<T>(string key)
        {
            LocalData.SetSettings(DataDictionary[key]);
        }
    }
}
