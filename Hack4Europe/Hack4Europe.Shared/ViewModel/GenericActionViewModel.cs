using System.Collections.ObjectModel;
using Hack4Europe.UserControls;

namespace Hack4Europe.ViewModel
{
    class GenericActionViewModel : CommonViewModel
    {
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

        public GenericActionViewModel(DomoItemControl.DomoItemType type)
        {
            switch (type)
            {
                case DomoItemControl.DomoItemType.Temperature:
                    TopIconLogoUri = "/CommonAssets/Icon/Temperature Filled-100.png";
                    TopImageUri = "/CommonAssets/Icon/Temperature Filled-100.png";
                    TopTitle = "temp";
                    break;

                case DomoItemControl.DomoItemType.Cooling:
                    TopIconLogoUri = "/CommonAssets/Icon/Temperature Filled-100.png";
                    TopImageUri = "/CommonAssets/Icon/Temperature Filled-100.png";
                    TopTitle = "Cooling";
                    break;

                case DomoItemControl.DomoItemType.Heating:
                    TopIconLogoUri = "/CommonAssets/Icon/Temperature Filled-100.png";
                    TopImageUri = "/CommonAssets/Icon/Temperature Filled-100.png";
                    TopTitle = "Heating";
                    break;

                case DomoItemControl.DomoItemType.Outlet:
                    TopIconLogoUri = "/CommonAssets/Icon/Temperature Filled-100.png";
                    TopImageUri = "/CommonAssets/Icon/Temperature Filled-100.png";
                    TopTitle = "Outlet";
                    break;

                case DomoItemControl.DomoItemType.Safety:
                    TopIconLogoUri = "/CommonAssets/Icon/Temperature Filled-100.png";
                    TopImageUri = "/CommonAssets/Icon/Temperature Filled-100.png";
                    TopTitle = "Safety";
                    break;
            }

            var tmp = new ObservableCollection<DomoItemControlViewModel>()
            {
                new DomoItemControlViewModel {Icon = new IconInfoViewModel {Uri = "/CommonAssets/Icons/Electricity-100_thin.png", Id = 1, State = IconInfoViewModel.IconState.Inactive}, Type = DomoItemControl.DomoItemType.Temperature, TextDescription = "dlshd dpaozda zczac az az; fet eve ev ev ac a az g zeyr zv eze zev ezv ezv", ValueSlider = 30, WsOver = true},
                new DomoItemControlViewModel {Icon = new IconInfoViewModel {Uri = "/CommonAssets/Icons/Winter-100_fat.png", Id = 6, State = IconInfoViewModel.IconState.Active}, Type = DomoItemControl.DomoItemType.Cooling, TextDescription = "àfjezfe ceice cazpcojzac z^pcjazcnaz c,;za clzbcozhac", ValueSlider = 54, WsOver = true},
                new DomoItemControlViewModel {Icon = new IconInfoViewModel {Uri = "/CommonAssets/Icons/Heating Room-100.png", Id = 3, State = IconInfoViewModel.IconState.Inactive}, Type = DomoItemControl.DomoItemType.Heating, TextDescription = "dzdzadz", ValueSlider = 12, WsOver = true},
                new DomoItemControlViewModel {Icon = new IconInfoViewModel {Uri = "/CommonAssets/Icons/Lock-100.png", Id = 8, State = IconInfoViewModel.IconState.Active}, Type = DomoItemControl.DomoItemType.Safety, TextDescription = "dlshd dpaozda zczac az az; fet eve ev ev ac a az g zeyr zv eze zev ezv ezv dqdzco czaicnzicn czapcnzac zc cpnzcc czac", ValueSlider = 98, WsOver = true},
                new DomoItemControlViewModel {Icon = new IconInfoViewModel {Uri = "/CommonAssets/Icons/Lock-100.png", Id = 8, State = IconInfoViewModel.IconState.Active}, Type = DomoItemControl.DomoItemType.Safety, TextDescription = "dlshd dpaozda zczac az az; fet eve ev ev ac a az g zeyr zv eze zev ezv ezv dqdzco czaicnzicn czapcnzac zc cpnzcc czac", ValueSlider = 98, WsOver = true},
                new DomoItemControlViewModel {Icon = new IconInfoViewModel {Uri = "/CommonAssets/Icons/Lock-100.png", Id = 8, State = IconInfoViewModel.IconState.Active}, Type = DomoItemControl.DomoItemType.Safety, TextDescription = "dlshd dpaozda zczac az az; fet eve ev ev ac a az g zeyr zv eze zev ezv ezv dqdzco czaicnzicn czapcnzac zc cpnzcc czac", ValueSlider = 98, WsOver = true},
                new DomoItemControlViewModel {Icon = new IconInfoViewModel {Uri = "/CommonAssets/Icons/Lock-100.png", Id = 8, State = IconInfoViewModel.IconState.Active}, Type = DomoItemControl.DomoItemType.Safety, TextDescription = "dlshd dpaozda zczac az az; fet eve ev ev ac a az g zeyr zv eze zev ezv ezv dqdzco czaicnzicn czapcnzac zc cpnzcc czac", ValueSlider = 98, WsOver = true},
                new DomoItemControlViewModel {Icon = new IconInfoViewModel {Uri = "/CommonAssets/Icons/Lock-100.png", Id = 8, State = IconInfoViewModel.IconState.Active}, Type = DomoItemControl.DomoItemType.Safety, TextDescription = "dlshd dpaozda zczac az az; fet eve ev ev ac a az g zeyr zv eze zev ezv ezv dqdzco czaicnzicn czapcnzac zc cpnzcc czac", ValueSlider = 98, WsOver = true},
                new DomoItemControlViewModel {Icon = new IconInfoViewModel {Uri = "/CommonAssets/Icons/Lock-100.png", Id = 8, State = IconInfoViewModel.IconState.Active}, Type = DomoItemControl.DomoItemType.Safety, TextDescription = "dlshd dpaozda zczac az az; fet eve ev ev ac a az g zeyr zv eze zev ezv ezv dqdzco czaicnzicn czapcnzac zc cpnzcc czac", ValueSlider = 98, WsOver = true},
                new DomoItemControlViewModel {Icon = new IconInfoViewModel {Uri = "/CommonAssets/Icons/Lock-100.png", Id = 8, State = IconInfoViewModel.IconState.Active}, Type = DomoItemControl.DomoItemType.Safety, TextDescription = "dlshd dpaozda zczac az az; fet eve ev ev ac a az g zeyr zv eze zev ezv ezv dqdzco czaicnzicn czapcnzac zc cpnzcc czac", ValueSlider = 98, WsOver = true},
            };
            DomoItemsList = tmp;
        }
    }
}
