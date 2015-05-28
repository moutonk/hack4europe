using Windows.UI.ViewManagement;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using Hack4Europe.UserControls;
using Hack4Europe.ViewModel;

namespace Hack4Europe.View
{
    public sealed partial class ScenariosView : Page
    {
        public ScenariosView()
        {
            this.InitializeComponent();
#if WINDOWS_PHONE_APP
            StatusBar.GetForCurrentView().HideAsync();
#endif
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            var type = (DomoItemControl.DomoItemType)e.Parameter;
            this.DataContext = new GenericActionViewModel(type);
            var vm = DataContext as GenericActionViewModel;

            base.OnNavigatedTo(e);
        }
    }
}
