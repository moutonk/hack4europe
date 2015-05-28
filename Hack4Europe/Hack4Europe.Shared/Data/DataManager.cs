using System.Collections.Generic;
using Hack4Europe.ViewModel;

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

        public static List<List<IconInfoViewModel>> CircularLinkedIconList = new List<List<IconInfoViewModel>>
        {
            new List<IconInfoViewModel>
            {
                new IconInfoViewModel {Id = 0, State = IconInfoViewModel.IconState.Active, Uri = "/CommonAssets/Icons/Electricity-100_fat.png"},
                new IconInfoViewModel {Id = 1, State = IconInfoViewModel.IconState.Inactive, Uri = "/CommonAssets/Icons/Electricity-100_thin.png"},
            },
            new List<IconInfoViewModel>
            {
                new IconInfoViewModel {Id = 2, State = IconInfoViewModel.IconState.Active, Uri = "/CommonAssets/Icons/Heating Room Filled-100.png"},
                new IconInfoViewModel {Id = 3, State = IconInfoViewModel.IconState.Inactive, Uri = "/CommonAssets/Icons/Heating Room-100.png"}
            },
            new List<IconInfoViewModel>
            {
                new IconInfoViewModel {Id = 4, State = IconInfoViewModel.IconState.Active, Uri = "/CommonAssets/Icons/IdeaOn-100.png"},
                new IconInfoViewModel {Id = 5, State = IconInfoViewModel.IconState.Inactive, Uri = "/CommonAssets/Icons/Idea-100.png"}
            },
            new List<IconInfoViewModel>
            {
                new IconInfoViewModel {Id = 6, State = IconInfoViewModel.IconState.Active, Uri = "/CommonAssets/Icons/Winter-100_fat.png"},
                new IconInfoViewModel {Id = 7, State = IconInfoViewModel.IconState.Inactive, Uri = "/CommonAssets/Icons/Winter-100_thin.png"}
            },
            new List<IconInfoViewModel>
            {
                new IconInfoViewModel {Id = 8, State = IconInfoViewModel.IconState.Active, Uri = "/CommonAssets/Icons/Lock-100.png"},
                new IconInfoViewModel {Id = 9, State = IconInfoViewModel.IconState.Inactive, Uri = "/CommonAssets/Icons/Unlock-100.png"}
            }
        };
    }
}
