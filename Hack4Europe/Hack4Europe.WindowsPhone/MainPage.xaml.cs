using System;
using System.Linq.Expressions;
using Windows.Phone.UI.Input;
using Windows.UI.Popups;
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
            Init();
        }

        private async void Init()
        {
            HardwareButtons.BackPressed += async delegate(object sender, BackPressedEventArgs args)
            {
                if (Frame.CanGoBack)
                {
                    args.Handled = true;
                    if (Frame.CanGoBack == true && (Frame.CurrentSourcePageType != typeof(FirstPageView) &&
                                                    Frame.CurrentSourcePageType != typeof(HomeView)))
                    {
                        Frame.GoBack();
                    }
                    else
                    {
                        var dialog = new MessageDialog("Are you sure?") { Title = "Really?" };
                        dialog.Commands.Add(new UICommand { Label = "Ok", Id = 0 });
                        dialog.Commands.Add(new UICommand { Label = "Cancel", Id = 1 });
                        var res = await dialog.ShowAsync();

                        if ((int)res.Id == 0)
                        {
                            Application.Current.Exit();
                        }
                    }
                }
            };
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void MainPage_OnLoaded(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(FirstPageView));
        }
    }
}
