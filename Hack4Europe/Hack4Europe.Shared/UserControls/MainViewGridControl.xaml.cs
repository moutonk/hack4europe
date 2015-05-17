using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;

// Pour en savoir plus sur le modèle d'élément Contrôle utilisateur, consultez la page http://go.microsoft.com/fwlink/?LinkId=234236
using Hack4Europe.ViewModel;

namespace Hack4Europe.UserControls
{
    public sealed partial class MainViewGridControl : UserControl
    {
        public MainViewGridControl()
        {
            this.InitializeComponent();
            this.DataContext = new MainViewGridViewModel();
        }

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

        private void MainViewGridControl_OnLoaded(object sender, RoutedEventArgs e)
        {
            (this.DataContext as MainViewGridViewModel).TopIconLogoUri = TopIconLogoUri;
            (this.DataContext as MainViewGridViewModel).TopImageUri = TopImageUri;
            (this.DataContext as MainViewGridViewModel).TopTitle = TopTitle;
        }
    }
}
