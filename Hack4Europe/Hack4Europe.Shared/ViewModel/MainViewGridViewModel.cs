using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Hack4Europe.UserControls;

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

        //private ObservableCollection<DomoItemControlViewModel> _domoItemsList;
        //public ObservableCollection<DomoItemControlViewModel> DomoItemsList
        //{
        //    get
        //    {
        //        return _domoItemsList;
        //    }
        //    set
        //    {
        //        NotifyPropertyChanged(ref _domoItemsList, value);
        //    }
        //}

        //public MainViewGridViewModel()
        //{
        //    var tmp = new ObservableCollection<DomoItemControlViewModel>()
        //    {
        //        new DomoItemControlViewModel {Icon = new IconInfoViewModel {Uri = "/CommonAssets/Icons/Electricity-100_thin.png", Id = 1, State = IconInfoViewModel.IconState.Inactive}, Type = DomoItemControl.DomoItemType.Temperature, TextDescription = "dlshd dpaozda zczac az az; fet eve ev ev ac a az g zeyr zv eze zev ezv ezv", ValueSlider = 30, WsOver = true},
        //        new DomoItemControlViewModel {Icon = new IconInfoViewModel {Uri = "/CommonAssets/Icons/Winter-100_fat.png", Id = 6, State = IconInfoViewModel.IconState.Active}, Type = DomoItemControl.DomoItemType.Cooling, TextDescription = "àfjezfe ceice cazpcojzac z^pcjazcnaz c,;za clzbcozhac", ValueSlider = 54, WsOver = true},
        //        new DomoItemControlViewModel {Icon = new IconInfoViewModel {Uri = "/CommonAssets/Icons/Heating Room-100.png", Id = 3, State = IconInfoViewModel.IconState.Inactive}, Type = DomoItemControl.DomoItemType.Heating, TextDescription = "dzdzadz", ValueSlider = 12, WsOver = true},
        //        new DomoItemControlViewModel {Icon = new IconInfoViewModel {Uri = "/CommonAssets/Icons/Lock-100.png", Id = 8, State = IconInfoViewModel.IconState.Active}, Type = DomoItemControl.DomoItemType.Safety, TextDescription = "dlshd dpaozda zczac az az; fet eve ev ev ac a az g zeyr zv eze zev ezv ezv dqdzco czaicnzicn czapcnzac zc cpnzcc czac", ValueSlider = 98, WsOver = true},
        //    };
        //    DomoItemsList = tmp;
        //}
    }
}
