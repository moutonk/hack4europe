using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Hack4Europe.Data;
using Hack4Europe.UserControls;
using Hack4Europe.View;

namespace Hack4Europe.ViewModel
{
    public class ScenarioGroupViewModel : ViewModelBase, ICommand
    {
        private readonly Action _toExecuteForCommand;
        private static Frame _rootFrame;

        public ICommand AddCommand { get; set; }

        private string _headerTitle;
        public string HeaderTitle
        {
            get
            {
                return _headerTitle;
            }
            set
            {
                NotifyPropertyChanged(ref _headerTitle, value);
            }
        }

        private SolidColorBrush _headerColor;
        public SolidColorBrush HeaderColor
        {
            get
            {
                return _headerColor;
            }
            set
            {
                NotifyPropertyChanged(ref _headerColor, value);
            }
        }

        private bool _isAddActive;
        public bool IsAddActive
        {
            get
            {
                return _isAddActive;
            }
            set
            {
                NotifyPropertyChanged(ref _isAddActive, value);
            }
        }

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

        public ScenarioGroupViewModel(ScenarioGroupControl.ScenarioGroupeTypEnum ScenarioGroupType, DomoItemControl.DomoItemType ScenarioGroupSubType)
        {
            AddCommand = this;
            _rootFrame = (Frame)Window.Current.Content;

            switch (ScenarioGroupType)
            {
                case ScenarioGroupControl.ScenarioGroupeTypEnum.Action:
                    _toExecuteForCommand = () => _rootFrame.Navigate(typeof(CreateActionView));
                    break;

                case ScenarioGroupControl.ScenarioGroupeTypEnum.Trigger:
                    _toExecuteForCommand = () => _rootFrame.Navigate(typeof(CreateTriggerView));
                    break;
            }

            switch (ScenarioGroupSubType)
            {
                case DomoItemControl.DomoItemType.Cooling:
                    DomoItemsList = DataManager.AirConditionerDomoItemList;
                    break;

                case DomoItemControl.DomoItemType.Heating:
                    DomoItemsList = DataManager.HeaterDomoItemList;
                    break;

                case DomoItemControl.DomoItemType.Lamp:
                    DomoItemsList = DataManager.LampsDomoItemList;
                    break;

                case DomoItemControl.DomoItemType.Light:
                    DomoItemsList = DataManager.LampsDomoItemList;
                    break;

                case DomoItemControl.DomoItemType.Safety:
                    DomoItemsList = DataManager.SecurityDomoItemList;
                    break;

                case DomoItemControl.DomoItemType.Sensor:
                    DomoItemsList = DataManager.SensorsDomoItemList;
                    break;

                case DomoItemControl.DomoItemType.Temperature:
                    DomoItemsList = DataManager.TemperatureDomoItemList;
                    break;

                case DomoItemControl.DomoItemType.WallSocket:
                    DomoItemsList = DataManager.WallSocketDomoItemList;
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
    }
}
