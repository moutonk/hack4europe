using Windows.Phone.UI.Input;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using Hack4Europe.View;

namespace Hack4Europe
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;
            HardwareButtons.BackPressed += delegate(object sender, BackPressedEventArgs args)
            {
                if (Frame.CanGoBack)
                {
                    args.Handled = true;
                    if (Frame.CanGoBack == true)
                    {
                        Frame.GoBack();
                    }
                    else
                    {
                        //quitter
                    }
                }
            };

        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void MainPage_OnLoaded(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof (FirstPageView));
        }

    }
}
