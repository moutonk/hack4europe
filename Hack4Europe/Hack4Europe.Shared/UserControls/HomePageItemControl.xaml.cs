﻿using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Hack4Europe.ViewModel;

namespace Hack4Europe.UserControls
{
    public sealed partial class HomePageItemControl : UserControl
    {
        public enum HomePageItemType
        {
            Scenarios,
            Actions,
            Compatibility,
            Settings
        }

        #region DependancyProperties

        public string Title
        {
            get { return (string)this.GetValue(TitleProperty); }
            set { this.SetValue(TitleProperty, value); }
        }

        public static readonly DependencyProperty TitleProperty = DependencyProperty.Register(
        "Title", typeof(string), typeof(HomePageItemControl), new PropertyMetadata(string.Empty));

        public string Icon
        {
            get { return (string)this.GetValue(IconProperty); }
            set { this.SetValue(IconProperty, value); }
        }

        public static readonly DependencyProperty IconProperty = DependencyProperty.Register(
        "Icon", typeof(string), typeof(HomePageItemControl), new PropertyMetadata(string.Empty));

        public HomePageItemType Type
        {
            get { return (HomePageItemType)this.GetValue(TypeProperty); }
            set { this.SetValue(TypeProperty, value); }
        }

        public static readonly DependencyProperty TypeProperty = DependencyProperty.Register(
        "Type", typeof(HomePageItemType), typeof(HomePageItemControl), null);

        #endregion

        public HomePageItemControl()
        {
            this.InitializeComponent();
            DataContext = new HomePageItemViewModel();
        }

        private void HomePageItemControl_OnLoaded(object sender, RoutedEventArgs e)
        {
            (DataContext as HomePageItemViewModel).Icon = Icon;
            (DataContext as HomePageItemViewModel).Title = Title;
            (DataContext as HomePageItemViewModel).Type = Type;
        }
    }
}
