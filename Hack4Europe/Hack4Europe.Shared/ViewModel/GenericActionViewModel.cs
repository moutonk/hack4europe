using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Hack4Europe.UserControls;
using Hack4Europe.Data;
using Hack4Europe.View;

namespace Hack4Europe.ViewModel
{
    class GenericActionViewModel : CommonViewModel, ICommand
    {
        private readonly Action _toExecuteForCommand;
        private static Frame _rootFrame;
        private ObservableCollection<DomoItemControlViewModel> _domoItemsList;

        public ObservableCollection<DomoItemControlViewModel> DomoItemsList
        {
            get
            {
                return _domoItemsList;
            }
            set
            {
                NotifyPropertyChanged(ref _domoItemsList, value);
            }
        }
        public ICommand AddCommand { get; set; }

        public GenericActionViewModel(DomoItemControl.DomoItemType type)
        {
            AddCommand = this;
            Type = type;
            _rootFrame = (Frame)Window.Current.Content;
            
            switch (type)
            {
                case DomoItemControl.DomoItemType.Temperature:
                    TopIconLogoUri = "/CommonAssets/Icons/Temperature Filled-100.png";
                    TopTitle = "Temperatures";
                    DomoItemsList = DataManager.TemperatureDomoItemList;
                    _toExecuteForCommand = () => _rootFrame.Navigate(typeof (CreateScenarioView));
                    break;

                case DomoItemControl.DomoItemType.Cooling:
                    TopIconLogoUri = "/CommonAssets/Icons/Air Conditioner-100.png";
                    TopTitle = "Air conditioner";
                    DomoItemsList = DataManager.AirConditionerDomoItemList;
                    _toExecuteForCommand = () => _rootFrame.Navigate(typeof (CreateScenarioView));
                    break;

                case DomoItemControl.DomoItemType.Heating:
                    TopIconLogoUri = "/CommonAssets/Icons/Heating Room Filled-100.png";
                    TopTitle = "Heating";
                    DomoItemsList = DataManager.HeaterDomoItemList;
                    _toExecuteForCommand = () => _rootFrame.Navigate(typeof (CreateScenarioView));
                    break;

                case DomoItemControl.DomoItemType.WallSocket:
                    TopIconLogoUri = "/CommonAssets/Icons/Wall Socket-100.png";
                    TopTitle = "Wall sockets";
                    DomoItemsList = DataManager.WallSocketDomoItemList;
                    _toExecuteForCommand = () => _rootFrame.Navigate(typeof (CreateScenarioView));
                    break;

                case DomoItemControl.DomoItemType.Safety:
                    TopIconLogoUri = "/CommonAssets/Icons/Lock 2-100_white.png";
                    TopTitle = "Safety";
                    DomoItemsList = DataManager.SecurityDomoItemList;
                    _toExecuteForCommand = () => _rootFrame.Navigate(typeof (CreateScenarioView));
                    break;

                case DomoItemControl.DomoItemType.Light:
                    TopIconLogoUri = "/CommonAssets/Icons/IdeaOn-100.png";
                    TopTitle = "Lights";
                    DomoItemsList = DataManager.LampsDomoItemList;
                    _toExecuteForCommand = () => _rootFrame.Navigate(typeof (CreateScenarioView));
                    break;

                case DomoItemControl.DomoItemType.Lamp:
                    TopIconLogoUri = "/CommonAssets/Icons/Lamp-100.png";
                    TopTitle = "Lamps";
                    DomoItemsList = DataManager.LampsDomoItemList;
                    _toExecuteForCommand = () => _rootFrame.Navigate(typeof (CreateScenarioView));
                    break;

                case DomoItemControl.DomoItemType.Sensor:
                    TopIconLogoUri = "/CommonAssets/Icons/Motion Detector-100.png";
                    TopTitle = "Sensors";
                    DomoItemsList = DataManager.SensorsDomoItemList;
                    _toExecuteForCommand = () => _rootFrame.Navigate(typeof (CreateScenarioView));
                    break;

                case DomoItemControl.DomoItemType.Scenario:
                    TopIconLogoUri = "/CommonAssets/Icons/Overview Pages 2-100.png";
                    TopTitle = "Scenarios";
                    DomoItemsList = DataManager.ScenariosItemList;
                    _toExecuteForCommand = () => _rootFrame.Navigate(typeof (CreateScenarioView));
                    break;
            }
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            _toExecuteForCommand();
        }

            //var tmp = new ObservableCollection<DomoItemControlViewModel>()
            //{
            //    new DomoItemControlViewModel {Icon = new IconInfoViewModel {Uri = "/CommonAssets/Icons/Electricity-100_thin.png", Id = 1, State = IconInfoViewModel.IconState.Inactive}, Type = DomoItemControl.DomoItemType.Temperature, TextDescription = "dlshd dpaozda zczac az az; fet eve ev ev ac a az g zeyr zv eze zev ezv ezv", ValueSlider = 30, WsOver = true},
            //    new DomoItemControlViewModel {Icon = new IconInfoViewModel {Uri = "/CommonAssets/Icons/Winter-100_fat.png", Id = 6, State = IconInfoViewModel.IconState.Active}, Type = DomoItemControl.DomoItemType.Cooling, TextDescription = "àfjezfe ceice cazpcojzac z^pcjazcnaz c,;za clzbcozhac", ValueSlider = 54, WsOver = true},
            //    new DomoItemControlViewModel {Icon = new IconInfoViewModel {Uri = "/CommonAssets/Icons/Heating Room-100.png", Id = 3, State = IconInfoViewModel.IconState.Inactive}, Type = DomoItemControl.DomoItemType.Heating, TextDescription = "dzdzadz", ValueSlider = 12, WsOver = true},
            //    new DomoItemControlViewModel {Icon = new IconInfoViewModel {Uri = "/CommonAssets/Icons/Lock-100.png", Id = 8, State = IconInfoViewModel.IconState.Active}, Type = DomoItemControl.DomoItemType.Safety, TextDescription = "dlshd dpaozda zczac az az; fet eve ev ev ac a az g zeyr zv eze zev ezv ezv dqdzco czaicnzicn czapcnzac zc cpnzcc czac", ValueSlider = 98, WsOver = true},
            //    new DomoItemControlViewModel {Icon = new IconInfoViewModel {Uri = "/CommonAssets/Icons/Lock-100.png", Id = 8, State = IconInfoViewModel.IconState.Active}, Type = DomoItemControl.DomoItemType.Safety, TextDescription = "dlshd dpaozda zczac az az; fet eve ev ev ac a az g zeyr zv eze zev ezv ezv dqdzco czaicnzicn czapcnzac zc cpnzcc czac", ValueSlider = 98, WsOver = true},
            //    new DomoItemControlViewModel {Icon = new IconInfoViewModel {Uri = "/CommonAssets/Icons/Lock-100.png", Id = 8, State = IconInfoViewModel.IconState.Active}, Type = DomoItemControl.DomoItemType.Safety, TextDescription = "dlshd dpaozda zczac az az; fet eve ev ev ac a az g zeyr zv eze zev ezv ezv dqdzco czaicnzicn czapcnzac zc cpnzcc czac", ValueSlider = 98, WsOver = true},
            //    new DomoItemControlViewModel {Icon = new IconInfoViewModel {Uri = "/CommonAssets/Icons/Lock-100.png", Id = 8, State = IconInfoViewModel.IconState.Active}, Type = DomoItemControl.DomoItemType.Safety, TextDescription = "dlshd dpaozda zczac az az; fet eve ev ev ac a az g zeyr zv eze zev ezv ezv dqdzco czaicnzicn czapcnzac zc cpnzcc czac", ValueSlider = 98, WsOver = true},
            //    new DomoItemControlViewModel {Icon = new IconInfoViewModel {Uri = "/CommonAssets/Icons/Lock-100.png", Id = 8, State = IconInfoViewModel.IconState.Active}, Type = DomoItemControl.DomoItemType.Safety, TextDescription = "dlshd dpaozda zczac az az; fet eve ev ev ac a az g zeyr zv eze zev ezv ezv dqdzco czaicnzicn czapcnzac zc cpnzcc czac", ValueSlider = 98, WsOver = true},
            //    new DomoItemControlViewModel {Icon = new IconInfoViewModel {Uri = "/CommonAssets/Icons/Lock-100.png", Id = 8, State = IconInfoViewModel.IconState.Active}, Type = DomoItemControl.DomoItemType.Safety, TextDescription = "dlshd dpaozda zczac az az; fet eve ev ev ac a az g zeyr zv eze zev ezv ezv dqdzco czaicnzicn czapcnzac zc cpnzcc czac", ValueSlider = 98, WsOver = true},
            //    new DomoItemControlViewModel {Icon = new IconInfoViewModel {Uri = "/CommonAssets/Icons/Lock-100.png", Id = 8, State = IconInfoViewModel.IconState.Active}, Type = DomoItemControl.DomoItemType.Safety, TextDescription = "dlshd dpaozda zczac az az; fet eve ev ev ac a az g zeyr zv eze zev ezv ezv dqdzco czaicnzicn czapcnzac zc cpnzcc czac", ValueSlider = 98, WsOver = true},
            //};
            //DomoItemsList = tmp;
    }
}
