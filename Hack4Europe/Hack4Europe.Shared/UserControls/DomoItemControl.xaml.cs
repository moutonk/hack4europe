using System.Linq;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// Pour en savoir plus sur le modèle d'élément Contrôle utilisateur, consultez la page http://go.microsoft.com/fwlink/?LinkId=234236
using Windows.UI.Xaml.Input;
using Hack4Europe.Data;
using Hack4Europe.ViewModel;

namespace Hack4Europe.UserControls
{
    public sealed partial class DomoItemControl : UserControl
    {
        public enum DomoItemType
        {
            Temperature,
            Heating,
            Cooling
        }

        public DomoItemType Type
        {
            get { return (DomoItemType)this.GetValue(TypeProperty); }
            set { this.SetValue(TypeProperty, value); }
        }
        
        public static readonly DependencyProperty TypeProperty = DependencyProperty.Register(
        "Type", typeof(DomoItemType), typeof(DomoItemControl), new PropertyMetadata(DomoItemType.Temperature));

        public DomoItemControl()
        {
            this.InitializeComponent();
            //this.DataContext = new DomoItemControlViewModel();
        }

        private void DomoItem_OnLoaded(object sender, RoutedEventArgs e)
        {
            switch (Type)
            {
                case DomoItemType.Temperature:
                    break;

                case DomoItemType.Cooling:
                    break;

                case DomoItemType.Heating:
                    break;
            }
        }

        private void Icon_OnTapped(object sender, TappedRoutedEventArgs e)
        {
            (this.DataContext as DomoItemControlViewModel).IconOnTapped();  
        }
    }
}
