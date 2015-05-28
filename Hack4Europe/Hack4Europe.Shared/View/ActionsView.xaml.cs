using System;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml.Controls;

namespace Hack4Europe.View
{
    public sealed partial class ActionsView : Page
    {
        public ActionsView()
        {
            this.InitializeComponent();
#if WINDOWS_PHONE_APP
            StatusBar.GetForCurrentView().HideAsync();
#endif

            //Action1.DataContext = new ActionCubeControlViewModel { IconCube = "/CommonAssets/Icons/Temperature Filled-100.png", TitleCube = "temperature", NumberCube = "2", ColorCube = (SolidColorBrush)Application.Current.Resources["ActionGold"] };
            //Action2.DataContext = new ActionCubeControlViewModel { IconCube = "/CommonAssets/Icons/IdeaOn-100.png", TitleCube = "lights", NumberCube = "2", ColorCube = (SolidColorBrush)Application.Current.Resources["ActionLime"] };
            //Action3.DataContext = new ActionCubeControlViewModel { IconCube = "/CommonAssets/Icons/Air Conditioner-100.png", TitleCube = "air conditionner", ColorCube = (SolidColorBrush)Application.Current.Resources["ActionLightGrey"] };
            //Action4.DataContext = new ActionCubeControlViewModel { IconCube = "/CommonAssets/Icons/Heating Room Filled-100.png", TitleCube = "heater", ColorCube = (SolidColorBrush)Application.Current.Resources["ActionDarkOrange"] };
            //Action5.DataContext = new ActionCubeControlViewModel { IconCube = "/CommonAssets/Icons/Lamp-100.png", TitleCube = "lamps", ColorCube = (SolidColorBrush)Application.Current.Resources["ActionGreen"] };
            //Action6.DataContext = new ActionCubeControlViewModel { IconCube = "/CommonAssets/Icons/Lock 2-100_white.png", TitleCube = "security", ColorCube = (SolidColorBrush)Application.Current.Resources["FlashBlue"] };
            //Action7.DataContext = new ActionCubeControlViewModel { IconCube = "/CommonAssets/Icons/Wall Socket-100.png", TitleCube = "wall socket", ColorCube = (SolidColorBrush)Application.Current.Resources["MediumBlue"] };
            //Action8.DataContext = new ActionCubeControlViewModel { IconCube = "/CommonAssets/Icons/Motion Detector-100.png", TitleCube = "sensors", ColorCube = (SolidColorBrush)Application.Current.Resources["ActionLightOrange"] };
        }
    }
}
