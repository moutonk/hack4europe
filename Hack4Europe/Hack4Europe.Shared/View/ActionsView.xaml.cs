using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Hack4Europe.UserControls;

namespace Hack4Europe.View
{
    public sealed partial class ActionsView : Page
    {
        public ActionsView()
        {
            this.InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(GenericActionView), DomoItemControl.DomoItemType.Cooling);
        }

        private void ButtonBase_OnClick1(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(GenericActionView), DomoItemControl.DomoItemType.Heating);
        }

        private void ButtonBase_OnClick2(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(GenericActionView), DomoItemControl.DomoItemType.Safety);
        }

        private void ButtonBase_OnClick3(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(GenericActionView), DomoItemControl.DomoItemType.Temperature);
        }

        private void ButtonBase_OnClick4(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(GenericActionView), DomoItemControl.DomoItemType.Outlet);
        }
    }
}
