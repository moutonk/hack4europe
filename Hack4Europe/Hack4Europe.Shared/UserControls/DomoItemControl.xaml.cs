using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Hack4Europe.ViewModel;

namespace Hack4Europe.UserControls
{
    public sealed partial class DomoItemControl : UserControl
    {
        public enum DomoItemType
        {
            Temperature,
            Heating,
            Cooling,
            Safety,
            WallSocket,
            Sensor,
            Light,
            Lamp,
            Scenario
        }

        public DomoItemControl()
        {
            InitializeComponent();
            //DataContext = new DomoItemControlViewModel();
        }

        private void Icon_OnTapped(object sender, TappedRoutedEventArgs e)
        {
            (this.DataContext as DomoItemControlViewModel).IconOnTapped();  
        }
    }
}
