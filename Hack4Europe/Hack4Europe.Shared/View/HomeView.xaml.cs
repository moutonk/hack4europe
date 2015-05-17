using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Pour en savoir plus sur le modèle d'élément Page vierge, consultez la page http://go.microsoft.com/fwlink/?LinkId=234238
using Hack4Europe.UserControls;
using Hack4Europe.ViewModel;

namespace Hack4Europe.View
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class HomeView : Page
    {
        public HomeView()
        {
            this.InitializeComponent();
            this.DataContext = new MainViewGridViewModel();

            var tmp = new List<DomoItemControlViewModel>
            {
                new DomoItemControlViewModel {Icon = new IconInfoViewModel {Uri = "/CommonAssets/Icons/Electricity-100_thin.png", Id = 1, State = IconInfoViewModel.IconState.Inactive}, Type = DomoItemControl.DomoItemType.Temperature, TextDescription = "dlshd dpaozda zczac az az; fet eve ev ev ac a az g zeyr zv eze zev ezv ezv", ValueSlider = 30, WsOver = true},
                new DomoItemControlViewModel {Icon = new IconInfoViewModel {Uri = "/CommonAssets/Icons/Winter-100_fat.png", Id = 6, State = IconInfoViewModel.IconState.Active}, Type = DomoItemControl.DomoItemType.Cooling, TextDescription = "àfjezfe ceice cazpcojzac z^pcjazcnaz c,;za clzbcozhac", ValueSlider = 54, WsOver = true},
                new DomoItemControlViewModel {Icon = new IconInfoViewModel {Uri = "/CommonAssets/Icons/Heating Room-100.png", Id = 3, State = IconInfoViewModel.IconState.Inactive}, Type = DomoItemControl.DomoItemType.Heating, TextDescription = "dzdzadz", ValueSlider = 12, WsOver = true},
                new DomoItemControlViewModel {Icon = new IconInfoViewModel {Uri = "/CommonAssets/Icons/Lock-100.png", Id = 8, State = IconInfoViewModel.IconState.Active}, Type = DomoItemControl.DomoItemType.Safety, TextDescription = "dlshd dpaozda zczac az az; fet eve ev ev ac a az g zeyr zv eze zev ezv ezv dqdzco czaicnzicn czapcnzac zc cpnzcc czac", ValueSlider = 98, WsOver = true},
            };
            TotoListBox.ItemsSource = tmp;
        }
    }
}
