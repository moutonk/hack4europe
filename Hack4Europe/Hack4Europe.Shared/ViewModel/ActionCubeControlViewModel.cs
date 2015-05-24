using System.Windows.Input;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Hack4Europe.UserControls;
using Hack4Europe.View;

namespace Hack4Europe.ViewModel
{
    public class ActionCubeControlViewModel : ViewModelBase, ICommand
    {
        private static Frame _rootFrame;

        public ICommand CommandCube { get; set; }

        private string _iconCube;
        public string IconCube
        {
            get
            {
                return _iconCube;
            }
            set
            {
                NotifyPropertyChanged(ref _iconCube, value);
            }
        }

        private string _numberCube;
        public string NumberCube
        {
            get
            {
                return _numberCube;
            }
            set
            {
                if (TypeCube == ActionCubeControl.ActionType.Temperature)
                    NotifyPropertyChanged(ref _numberCube, "7 ");

                if (TypeCube == ActionCubeControl.ActionType.Lights)
                    NotifyPropertyChanged(ref _numberCube, "8 ");
            }
        }

        private string _titleCube;
        public string TitleCube
        {
            get
            {
                return _titleCube;
            }
            set
            {
                NotifyPropertyChanged(ref _titleCube, value);
            }
        }

        private ActionCubeControl.ActionType _typeCube;
        public ActionCubeControl.ActionType TypeCube
        {
            get
            {
                return _typeCube;
            }
            set
            {
                NotifyPropertyChanged(ref _typeCube, value);
            }
        }

        private SolidColorBrush _colorCube;
        public SolidColorBrush ColorCube
        {
            get
            {
                return _colorCube;
            }
            set
            {
                NotifyPropertyChanged(ref _colorCube, value);
            }
        }

        public ActionCubeControlViewModel()
        {
            CommandCube = this;
            _rootFrame = (Frame)Window.Current.Content;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event System.EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            switch (TypeCube)
            {
                case ActionCubeControl.ActionType.AC:
                    _rootFrame.Navigate(typeof(GenericActionView), DomoItemControl.DomoItemType.Cooling);
                    break;

                case ActionCubeControl.ActionType.Heater:
                    _rootFrame.Navigate(typeof(GenericActionView), DomoItemControl.DomoItemType.Heating);
                    break;

                case ActionCubeControl.ActionType.Security:
                    _rootFrame.Navigate(typeof(GenericActionView), DomoItemControl.DomoItemType.Safety);
                    break;

                case ActionCubeControl.ActionType.Temperature:
                    _rootFrame.Navigate(typeof(GenericActionView), DomoItemControl.DomoItemType.Temperature);
                    break;

                case ActionCubeControl.ActionType.WallSocket:
                    _rootFrame.Navigate(typeof(GenericActionView), DomoItemControl.DomoItemType.WallSocket);
                    break;

                case ActionCubeControl.ActionType.Sensors:
                    _rootFrame.Navigate(typeof(GenericActionView), DomoItemControl.DomoItemType.Sensor);
                    break;

                case ActionCubeControl.ActionType.Lamps:
                    _rootFrame.Navigate(typeof(GenericActionView), DomoItemControl.DomoItemType.Lamp);
                    break;

                case ActionCubeControl.ActionType.Lights:
                    _rootFrame.Navigate(typeof(GenericActionView), DomoItemControl.DomoItemType.Light);
                    break;
            }
        }
    }
}
