using Windows.UI.Xaml.Media;

namespace Hack4Europe.ViewModel
{
    class ActionCubeControlViewModel : ViewModelBase
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
                NotifyPropertyChanged(ref _numberCube, value);
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
