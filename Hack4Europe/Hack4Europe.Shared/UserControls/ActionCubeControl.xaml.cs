using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Hack4Europe.ViewModel;

namespace Hack4Europe.UserControls
{
    public sealed partial class ActionCubeControl : UserControl
    {
        public enum ActionType
        {
            Temperature,
            Lights,
            Heater,
            AC,
            WallSocket,
            Security,
            Sensors,
            Lamps
        }

        #region dp

        public string IconCube
        {
            get { return (string)this.GetValue(IconCubeProperty); }
            set { this.SetValue(IconCubeProperty, value); }
        }

        public static readonly DependencyProperty IconCubeProperty = DependencyProperty.Register(
        "IconCube", typeof(string), typeof(ActionCubeControl), new PropertyMetadata(string.Empty));

        public string NumberCube
        {
            get { return (string)this.GetValue(NumberCubeProperty); }
            set { this.SetValue(NumberCubeProperty, value); }
        }

        public static readonly DependencyProperty NumberCubeProperty = DependencyProperty.Register(
        "NumberCube", typeof(string), typeof(ActionCubeControl), new PropertyMetadata(string.Empty));

        public string TitleCube
        {
            get { return (string)this.GetValue(TitleCubeProperty); }
            set { this.SetValue(TitleCubeProperty, value); }
        }

        public static readonly DependencyProperty TitleCubeProperty = DependencyProperty.Register(
        "TitleCube", typeof(string), typeof(ActionCubeControl), new PropertyMetadata(string.Empty));

        public SolidColorBrush ColorCube
        {
            get { return (SolidColorBrush)this.GetValue(ColorCubeProperty); }
            set { this.SetValue(ColorCubeProperty, value); }
        }

        public static readonly DependencyProperty ColorCubeProperty = DependencyProperty.Register(
        "ColorCube", typeof(SolidColorBrush), typeof(ActionCubeControl), new PropertyMetadata(new SolidColorBrush()));

        public ActionType TypeCube
        {
            get { return (ActionType)this.GetValue(TypeCubeProperty); }
            set { this.SetValue(TypeCubeProperty, value); }
        }

        public static readonly DependencyProperty TypeCubeProperty = DependencyProperty.Register(
        "TypeCube", typeof(SolidColorBrush), typeof(ActionCubeControl), null);

        #endregion

        public ActionCubeControl()
        {
            this.InitializeComponent();
            DataContext = new ActionCubeControlViewModel();
            //DataContext = new ActionCubeControlViewModel { IconCube = "/CommonAssets/Icons/Temperature Filled-100.png", TitleCube = "temperature", NumberCube = "2", ColorCube = (SolidColorBrush)Application.Current.Resources["ActionGold"] };
        }

        private void ActionCubeControl_OnLoaded(object sender, RoutedEventArgs e)
        {
            try
            {
                (this.DataContext as ActionCubeControlViewModel).IconCube = IconCube;
                (this.DataContext as ActionCubeControlViewModel).ColorCube = ColorCube;
                (this.DataContext as ActionCubeControlViewModel).TitleCube = TitleCube;
                (this.DataContext as ActionCubeControlViewModel).TypeCube = TypeCube;
                (this.DataContext as ActionCubeControlViewModel).NumberCube = NumberCube;
            }
            catch (Exception exp)
            {

            }
        }
    }
}
