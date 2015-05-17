﻿using Windows.UI.Xaml.Controls;
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
            Safety
        }

        //public DomoItemType Type
        //{
        //    get { return (DomoItemType)this.GetValue(TypeProperty); }
        //    set { this.SetValue(TypeProperty, value); }
        //}
        
        //public static readonly DependencyProperty TypeProperty = DependencyProperty.Register(
        //"Type", typeof(DomoItemType), typeof(DomoItemControl), new PropertyMetadata(DomoItemType.Temperature));

        public DomoItemControl()
        {
            this.InitializeComponent();
            //this.DataContext = new DomoItemControlViewModel();
        }

        private void Icon_OnTapped(object sender, TappedRoutedEventArgs e)
        {
            (this.DataContext as DomoItemControlViewModel).IconOnTapped();  
        }
    }
}