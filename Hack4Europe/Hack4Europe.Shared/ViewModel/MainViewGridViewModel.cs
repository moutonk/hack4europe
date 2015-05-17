using System;
using System.Collections.Generic;
using System.Text;

namespace Hack4Europe.ViewModel
{
    class MainViewGridViewModel : ViewModelBase
    {
        private string _topIconLogo;
        public string TopIconLogoUri
        {
            get
            {
                return _topIconLogo;
            }
            set
            {
                NotifyPropertyChanged(ref _topIconLogo, value);
            }
        }

        private string _topImageUri;
        public string TopImageUri
        {
            get
            {
                return _topImageUri;
            }
            set
            {
                NotifyPropertyChanged(ref _topImageUri, value);
            }
        }

        private string _topTitle;
        public string TopTitle
        {
            get
            {
                return _topTitle;
            }
            set
            {
                NotifyPropertyChanged(ref _topTitle, value);
            }
        }
    }
}
