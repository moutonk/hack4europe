using System.Collections.Generic;
using Hack4Europe.ViewModel;
using System.Collections.ObjectModel;
using Hack4Europe.UserControls;

namespace Hack4Europe.Data
{
    public static class DataManager
    {
        public static bool ForceRefreshTimer { get; set; }
        public static bool HasToRequestNotifications { get; set; }
        public static string Token { get; set; }
        public static Dictionary<string, object> DataDictionary { get; set; }
        public static Dictionary<string, string> StorageFileDictionary { get; set; }

        public static ObservableCollection<DomoItemControlViewModel> TemperatureDomoItemList { get; set; }
        public static ObservableCollection<DomoItemControlViewModel> AirConditionerDomoItemList { get; set; }
        public static ObservableCollection<DomoItemControlViewModel> HeaterDomoItemList { get; set; }
        public static ObservableCollection<DomoItemControlViewModel> LampsDomoItemList { get; set; }
        public static ObservableCollection<DomoItemControlViewModel> SecurityDomoItemList { get; set; }
        public static ObservableCollection<DomoItemControlViewModel> WallSocketDomoItemList { get; set; }
        public static ObservableCollection<DomoItemControlViewModel> SensorsDomoItemList { get; set; }
        public static ObservableCollection<DomoItemControlViewModel> ScenariosItemList { get; set; }

        static DataManager()
        {
            Token = null;
            ForceRefreshTimer = false;
            HasToRequestNotifications = false;
            DataDictionary = new Dictionary<string, object>();
            StorageFileDictionary = new Dictionary<string, string>();

            //TemperatureDomoItemList = new ObservableCollection<DomoItemControlViewModel>();
            //AirConditionerDomoItemList = new ObservableCollection<DomoItemControlViewModel>();
            //HeaterDomoItemList = new ObservableCollection<DomoItemControlViewModel>();
            //LampsDomoItemList = new ObservableCollection<DomoItemControlViewModel>();
            //SecurityDomoItemList = new ObservableCollection<DomoItemControlViewModel>();
            //WallSocketDomoItemList = new ObservableCollection<DomoItemControlViewModel>();
            //SensorsDomoItemList = new ObservableCollection<DomoItemControlViewModel>();

            TemperatureDomoItemList = new ObservableCollection<DomoItemControlViewModel>
            {
                new DomoItemControlViewModel {Icon = new IconInfoViewModel {Uri = "/CommonAssets/Icons/Temperature Filled-100.png", Id = 10, State = IconInfoViewModel.IconState.Active}, Type = DomoItemControl.DomoItemType.Temperature, TextDescription = "Living room", ValueSlider = 30, WsOver = true},
                new DomoItemControlViewModel {Icon = new IconInfoViewModel {Uri = "/CommonAssets/Icons/Temperature Filled-100.png", Id = 10, State = IconInfoViewModel.IconState.Active}, Type = DomoItemControl.DomoItemType.Temperature, TextDescription = "Bedroom", ValueSlider = 40, WsOver = true},
                new DomoItemControlViewModel {Icon = new IconInfoViewModel {Uri = "/CommonAssets/Icons/Temperature Filled-100.png", Id = 10, State = IconInfoViewModel.IconState.Active}, Type = DomoItemControl.DomoItemType.Temperature, TextDescription = "Kitchen", ValueSlider = 10, WsOver = true},
            };

            AirConditionerDomoItemList = new ObservableCollection<DomoItemControlViewModel>
            {
                new DomoItemControlViewModel {Icon = new IconInfoViewModel {Uri = "/CommonAssets/Icons/Winter-100_fat.png", Id = 6, State = IconInfoViewModel.IconState.Active}, Type = DomoItemControl.DomoItemType.Cooling, TextDescription = "Living room", ValueSlider = 30, WsOver = true},
                new DomoItemControlViewModel {Icon = new IconInfoViewModel {Uri = "/CommonAssets/Icons/Winter-100_thin.png", Id = 7, State = IconInfoViewModel.IconState.Inactive}, Type = DomoItemControl.DomoItemType.Cooling, TextDescription = "Bedroom", ValueSlider = 40, WsOver = true},
                new DomoItemControlViewModel {Icon = new IconInfoViewModel {Uri = "/CommonAssets/Icons/Winter-100_fat.png", Id = 6, State = IconInfoViewModel.IconState.Active}, Type = DomoItemControl.DomoItemType.Cooling, TextDescription = "Kitchen", ValueSlider = 10, WsOver = true},
            };

            HeaterDomoItemList = new ObservableCollection<DomoItemControlViewModel>
            {
                new DomoItemControlViewModel {Icon = new IconInfoViewModel {Uri = "/CommonAssets/Icons/Heating Room Filled-100.png", Id = 2, State = IconInfoViewModel.IconState.Active}, Type = DomoItemControl.DomoItemType.Heating, TextDescription = "Living room", ValueSlider = 30, WsOver = true},
                new DomoItemControlViewModel {Icon = new IconInfoViewModel {Uri = "/CommonAssets/Icons/Heating Room Filled-100.png", Id = 2, State = IconInfoViewModel.IconState.Active}, Type = DomoItemControl.DomoItemType.Heating, TextDescription = "Bedroom", ValueSlider = 40, WsOver = true},
                new DomoItemControlViewModel {Icon = new IconInfoViewModel {Uri = "/CommonAssets/Icons/Heating Room-100.png", Id = 3, State = IconInfoViewModel.IconState.Inactive}, Type = DomoItemControl.DomoItemType.Heating, TextDescription = "Kitchen", ValueSlider = 10, WsOver = true},
            };

            LampsDomoItemList = new ObservableCollection<DomoItemControlViewModel>
            {
                new DomoItemControlViewModel {Icon = new IconInfoViewModel {Uri = "/CommonAssets/Icons/IdeaOn-100.png", Id = 4, State = IconInfoViewModel.IconState.Active}, Type = DomoItemControl.DomoItemType.Lamp, TextDescription = "Living room", ValueSlider = 30, WsOver = true},
                new DomoItemControlViewModel {Icon = new IconInfoViewModel {Uri = "/CommonAssets/Icons/Idea-100.png", Id = 5, State = IconInfoViewModel.IconState.Inactive}, Type = DomoItemControl.DomoItemType.Lamp, TextDescription = "Bedroom", ValueSlider = 40, WsOver = true},
                new DomoItemControlViewModel {Icon = new IconInfoViewModel {Uri = "/CommonAssets/Icons/IdeaOn-100.png", Id = 4, State = IconInfoViewModel.IconState.Active}, Type = DomoItemControl.DomoItemType.Lamp, TextDescription = "Kitchen", ValueSlider = 10, WsOver = true},
                new DomoItemControlViewModel {Icon = new IconInfoViewModel {Uri = "/CommonAssets/Icons/IdeaOn-100.png", Id = 4, State = IconInfoViewModel.IconState.Active}, Type = DomoItemControl.DomoItemType.Lamp, TextDescription = "Garage", ValueSlider = 10, WsOver = true},
                new DomoItemControlViewModel {Icon = new IconInfoViewModel {Uri = "/CommonAssets/Icons/IdeaOn-100.png", Id = 4, State = IconInfoViewModel.IconState.Active}, Type = DomoItemControl.DomoItemType.Lamp, TextDescription = "Restroom", ValueSlider = 10, WsOver = true},
            };

            SecurityDomoItemList = new ObservableCollection<DomoItemControlViewModel>
            {
                new DomoItemControlViewModel {Icon = new IconInfoViewModel {Uri = "/CommonAssets/Icons/Lock-100.png", Id = 8, State = IconInfoViewModel.IconState.Active}, Type = DomoItemControl.DomoItemType.Safety, TextDescription = "Front door", ValueSlider = 30, WsOver = true},
                new DomoItemControlViewModel {Icon = new IconInfoViewModel {Uri = "/CommonAssets/Icons/Unlock-100.png", Id = 9, State = IconInfoViewModel.IconState.Inactive}, Type = DomoItemControl.DomoItemType.Safety, TextDescription = "Garage door", ValueSlider = 40, WsOver = true},
            };

            WallSocketDomoItemList = new ObservableCollection<DomoItemControlViewModel>
            {
                new DomoItemControlViewModel {Icon = new IconInfoViewModel {Uri = "/CommonAssets/Icons/Electricity-100_fat.png", Id = 0, State = IconInfoViewModel.IconState.Active}, Type = DomoItemControl.DomoItemType.WallSocket, TextDescription = "TV", ValueSlider = 30, WsOver = true},
                new DomoItemControlViewModel {Icon = new IconInfoViewModel {Uri = "/CommonAssets/Icons/Electricity-100_fat.png", Id = 0, State = IconInfoViewModel.IconState.Active}, Type = DomoItemControl.DomoItemType.WallSocket, TextDescription = "Kitchen microwave", ValueSlider = 40, WsOver = true},
                new DomoItemControlViewModel {Icon = new IconInfoViewModel {Uri = "/CommonAssets/Icons/Electricity-100_thin.png", Id = 1, State = IconInfoViewModel.IconState.Inactive}, Type = DomoItemControl.DomoItemType.WallSocket, TextDescription = "Bedroom desk lamp", ValueSlider = 40, WsOver = true},
                new DomoItemControlViewModel {Icon = new IconInfoViewModel {Uri = "/CommonAssets/Icons/Electricity-100_thin.png", Id = 1, State = IconInfoViewModel.IconState.Inactive}, Type = DomoItemControl.DomoItemType.WallSocket, TextDescription = "Oven", ValueSlider = 40, WsOver = true},
            };

            ScenariosItemList = new ObservableCollection<DomoItemControlViewModel>
            {
                new DomoItemControlViewModel {Icon = new IconInfoViewModel {Uri = "/CommonAssets/Icons/Rain-100.png", Id = -1, State = IconInfoViewModel.IconState.Active}, Type = DomoItemControl.DomoItemType.Scenario, TextDescription = "When it's runny outside, turn off the air conditionning", ValueSlider = 30, WsOver = true},
                new DomoItemControlViewModel {Icon = new IconInfoViewModel {Uri = "/CommonAssets/Icons/Sun-100.png", Id = -1, State = IconInfoViewModel.IconState.Active}, Type = DomoItemControl.DomoItemType.Scenario, TextDescription = "When it's sunny outside, open the blinds and turn off the heater", ValueSlider = 40, WsOver = true},
                new DomoItemControlViewModel {Icon = new IconInfoViewModel {Uri = "/CommonAssets/Icons/Temperature Filled-100.png", Id = -1, State = IconInfoViewModel.IconState.Active}, Type = DomoItemControl.DomoItemType.Scenario, TextDescription = "If the temperature goes below 18°, turn on the heater in every room", ValueSlider = 40, WsOver = true},
            };

            //SensorsDomoItemList = new ObservableCollection<DomoItemControlViewModel>
            //{
            //    new DomoItemControlViewModel {Icon = new IconInfoViewModel {Uri = "/CommonAssets/Icons/Electricity-100_fat.png", Id = 1, State = IconInfoViewModel.IconState.Active}, Type = DomoItemControl.DomoItemType.WallSocket, TextDescription = "TV", ValueSlider = 30, WsOver = true},
            //    new DomoItemControlViewModel {Icon = new IconInfoViewModel {Uri = "/CommonAssets/Icons/Electricity-100_fat.png", Id = 1, State = IconInfoViewModel.IconState.Active}, Type = DomoItemControl.DomoItemType.WallSocket, TextDescription = "Kitchen microwave", ValueSlider = 40, WsOver = true},
            //    new DomoItemControlViewModel {Icon = new IconInfoViewModel {Uri = "/CommonAssets/Icons/Electricity-100_thin.png", Id = 1, State = IconInfoViewModel.IconState.Inactive}, Type = DomoItemControl.DomoItemType.WallSocket, TextDescription = "Bedroom desk lamp", ValueSlider = 40, WsOver = true},
            //    new DomoItemControlViewModel {Icon = new IconInfoViewModel {Uri = "/CommonAssets/Icons/Electricity-100_thin.png", Id = 1, State = IconInfoViewModel.IconState.Inactive}, Type = DomoItemControl.DomoItemType.WallSocket, TextDescription = "Oven", ValueSlider = 40, WsOver = true},
            //};

            //var tmp = new ObservableCollection<DomoItemControlViewModel>()
            //{
            //    new DomoItemControlViewModel {Icon = new IconInfoViewModel {Uri = "/CommonAssets/Icons/Electricity-100_thin.png", Id = 1, State = IconInfoViewModel.IconState.Inactive}, Type = DomoItemControl.DomoItemType.Temperature, TextDescription = "dlshd dpaozda zczac az az; fet eve ev ev ac a az g zeyr zv eze zev ezv ezv", ValueSlider = 30, WsOver = true},
            //    new DomoItemControlViewModel {Icon = new IconInfoViewModel {Uri = "/CommonAssets/Icons/Winter-100_fat.png", Id = 6, State = IconInfoViewModel.IconState.Active}, Type = DomoItemControl.DomoItemType.Cooling, TextDescription = "àfjezfe ceice cazpcojzac z^pcjazcnaz c,;za clzbcozhac", ValueSlider = 54, WsOver = true},
            //    new DomoItemControlViewModel {Icon = new IconInfoViewModel {Uri = "/CommonAssets/Icons/Heating Room-100.png", Id = 3, State = IconInfoViewModel.IconState.Inactive}, Type = DomoItemControl.DomoItemType.Heating, TextDescription = "dzdzadz", ValueSlider = 12, WsOver = true},
            //    new DomoItemControlViewModel {Icon = new IconInfoViewModel {Uri = "/CommonAssets/Icons/Lock-100.png", Id = 8, State = IconInfoViewModel.IconState.Active}, Type = DomoItemControl.DomoItemType.Safety, TextDescription = "dlshd dpaozda zczac az az; fet eve ev ev ac a az g zeyr zv eze zev ezv ezv dqdzco czaicnzicn czapcnzac zc cpnzcc czac", ValueSlider = 98, WsOver = true},
            //};
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
            },
            new List<IconInfoViewModel>
            {
                new IconInfoViewModel {Id = 10, State = IconInfoViewModel.IconState.Active, Uri = "/CommonAssets/Icons/Temperature Filled-100.png"},
            }
        };
    }
}
