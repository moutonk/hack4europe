using Windows.UI.Xaml.Media;
using Hack4Europe.UserControls;

namespace Hack4Europe.ViewModel
{
    public class ActionCubeControlViewModel : ViewModelBase
    {
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
    }
}
