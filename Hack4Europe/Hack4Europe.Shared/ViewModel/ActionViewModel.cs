
namespace Hack4Europe.ViewModel
{
    public class ActionViewModel : ViewModelBase
    {
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
    }
}
