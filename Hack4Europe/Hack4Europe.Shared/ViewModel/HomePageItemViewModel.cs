namespace Hack4Europe.ViewModel
{
    class HomePageItemViewModel : ViewModelBase
    {
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
    }
}
