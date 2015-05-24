using System.Windows.Input;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Hack4Europe.UserControls;
using Hack4Europe.View;

namespace Hack4Europe.ViewModel
{
    class HomePageItemViewModel : ViewModelBase, ICommand
    {
        private static Frame _rootFrame;

        private string _title;
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                NotifyPropertyChanged(ref _title, value);
            }
        }

        private string _icon;
        public string Icon
        {
            get
            {
                return _icon;
            }
            set
            {
                NotifyPropertyChanged(ref _icon, value);
            }
        }

        private HomePageItemControl.HomePageItemType _type;
        public HomePageItemControl.HomePageItemType Type
        {
            get
            {
                return _type;
            }
            set
            {
                NotifyPropertyChanged(ref _type, value);
            }
        }

        public ICommand OnClickCommand { get; set; }

        public HomePageItemViewModel()
        {
            OnClickCommand = this;
            _rootFrame = (Frame)Window.Current.Content;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event System.EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            switch (Type)
            {
                case HomePageItemControl.HomePageItemType.Actions:
                    _rootFrame.Navigate(typeof(ActionsView));
                    break;

                case HomePageItemControl.HomePageItemType.Scenarios:
                    _rootFrame.Navigate(typeof(ScenariosView));
                    break;

                case HomePageItemControl.HomePageItemType.Compatibility:
                    _rootFrame.Navigate(typeof(ScenariosView));
                    break;

                case HomePageItemControl.HomePageItemType.Settings:
                    _rootFrame.Navigate(typeof(CompatibilityView));
                    break;
            }
        }
    }
}
