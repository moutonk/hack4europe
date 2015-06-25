using System;
using System.Windows.Input;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
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

        public ScenarioGroupViewModel(ScenarioGroupControl.ScenarioGroupeTypEnum ScenarioGroupType)
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
