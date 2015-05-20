using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Hack4Europe.ViewModel;

namespace Hack4Europe.UserControls
{
    public sealed partial class MainViewGridControl : UserControl
    {
        #region DependancyProperties

        public string TopImageUri
        {
            get { return (string)this.GetValue(TopImageUriProperty); }
            set { this.SetValue(TopImageUriProperty, value); }
        }

        public static readonly DependencyProperty TopImageUriProperty = DependencyProperty.Register(
        "TopImageUri", typeof(string), typeof(MainViewGridControl), new PropertyMetadata(string.Empty));

        public string TopTitle
        {
            get { return (string)this.GetValue(TopTitleProperty); }
            set { this.SetValue(TopTitleProperty, value); }
        }

        public static readonly DependencyProperty TopTitleProperty = DependencyProperty.Register(
        "TopTitle", typeof(string), typeof(MainViewGridControl), new PropertyMetadata(string.Empty));

        public string TopIconLogoUri
        {
            get { return (string)this.GetValue(TopIconUriProperty); }
            set { this.SetValue(TopIconUriProperty, value); }
        }

        public static readonly DependencyProperty TopIconUriProperty = DependencyProperty.Register(
        "TopIconLogoUri", typeof(string), typeof(MainViewGridControl), new PropertyMetadata(string.Empty));

        public UIElementCollection Children
        {
            get { return (UIElementCollection)GetValue(ChildrenProperty); }
            set { SetValue(ChildrenProperty, value); }
        }

        public static readonly DependencyProperty ChildrenProperty = DependencyProperty.Register(
        "Children", typeof(UIElementCollection), typeof(MainViewGridControl), null);

        #endregion

        public MainViewGridControl()
        {
            this.InitializeComponent();
            Children = ContentStackPanel.Children;
        }

        private void MainViewGridControl_OnLoaded(object sender, RoutedEventArgs e)
        {
            (this.DataContext as MainViewGridViewModel).TopIconLogoUri = TopIconLogoUri;
            (this.DataContext as MainViewGridViewModel).TopImageUri = TopImageUri;
            (this.DataContext as MainViewGridViewModel).TopTitle = TopTitle;
        }
    }
}
