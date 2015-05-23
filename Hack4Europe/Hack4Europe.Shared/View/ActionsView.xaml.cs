using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Hack4Europe.ViewModel;

namespace Hack4Europe.View
{
    public sealed partial class ActionsView : Page
    {
        public ActionsView()
        {
            this.InitializeComponent();

        //    Action1.DataContext = new ActionCubeControlViewModel { IconCube = "/CommonAssets/Icons/Temperature Filled-100.png", TitleCube = "temperature", NumberCube = "2", ColorCube = (SolidColorBrush)Application.Current.Resources["ActionGold"] };
        //    Action2.DataContext = new ActionCubeControlViewModel { IconCube = "/CommonAssets/Icons/IdeaOn-100.png", TitleCube = "lights", NumberCube = "2", ColorCube = (SolidColorBrush)Application.Current.Resources["ActionLime"] };
        //    Action3.DataContext = new ActionCubeControlViewModel { IconCube = "/CommonAssets/Icons/Air Conditioner-100.png", TitleCube = "air conditionner", ColorCube = (SolidColorBrush)Application.Current.Resources["ActionLightGrey"] };
        //    Action4.DataContext = new ActionCubeControlViewModel { IconCube = "/CommonAssets/Icons/Heating Room Filled-100.png", TitleCube = "heater", ColorCube = (SolidColorBrush)Application.Current.Resources["ActionDarkOrange"] };
        //    Action5.DataContext = new ActionCubeControlViewModel { IconCube = "/CommonAssets/Icons/Lamp-100.png", TitleCube = "lamps", ColorCube = (SolidColorBrush)Application.Current.Resources["ActionGreen"] };
        //    Action6.DataContext = new ActionCubeControlViewModel { IconCube = "/CommonAssets/Icons/Lock 2-100_white.png", TitleCube = "security", ColorCube = (SolidColorBrush)Application.Current.Resources["FlashBlue"] };
        //    Action7.DataContext = new ActionCubeControlViewModel { IconCube = "/CommonAssets/Icons/Wall Socket-100.png", TitleCube = "wall socket", ColorCube = (SolidColorBrush)Application.Current.Resources["MediumBlue"] };
        //    Action8.DataContext = new ActionCubeControlViewModel { IconCube = "/CommonAssets/Icons/Motion Detector-100.png", TitleCube = "sensors", ColorCube = (SolidColorBrush)Application.Current.Resources["ActionLightOrange"] };
        }

        //private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        //{
        //    Frame.Navigate(typeof(GenericActionView), DomoItemControl.DomoItemType.Cooling);
        //}

        //private void ButtonBase_OnClick1(object sender, RoutedEventArgs e)
        //{
        //    Frame.Navigate(typeof(GenericActionView), DomoItemControl.DomoItemType.Heating);
        //}

        //private void ButtonBase_OnClick2(object sender, RoutedEventArgs e)
        //{
        //    Frame.Navigate(typeof(GenericActionView), DomoItemControl.DomoItemType.Safety);
        //}

        //private void ButtonBase_OnClick3(object sender, RoutedEventArgs e)
        //{
        //    Frame.Navigate(typeof(GenericActionView), DomoItemControl.DomoItemType.Temperature);
        //}

        //private void ButtonBase_OnClick4(object sender, RoutedEventArgs e)
        //{
        //    Frame.Navigate(typeof(GenericActionView), DomoItemControl.DomoItemType.Outlet);
        //}
    }
}
