using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Pour en savoir plus sur le modèle d'élément Contrôle utilisateur, consultez la page http://go.microsoft.com/fwlink/?LinkId=234236

namespace Hack4Europe.UserControls
{
    public sealed partial class DomoItem : UserControl
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
        "Type", typeof(DomoItemType), typeof(DomoItem), new PropertyMetadata(DomoItemType.Temperature));

        public DomoItem() : base()
        {
            this.InitializeComponent();
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
    }
}
