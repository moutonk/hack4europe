using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Hack4Europe.ViewModel;

namespace Hack4Europe.UserControls
{
    /// <summary>
    /// Interaction logic for ScenarioGroup.xaml
    /// </summary>
    public partial class ScenarioGroupControl : UserControl
    {
        public enum ScenarioGroupeTypEnum
        {
            Trigger,
            Action
        }

        #region dp

        public bool IsAddActive
        {
            get { return (bool)this.GetValue(IsAddActiveProperty); }
            set { this.SetValue(IsAddActiveProperty, value); }
        }

        public static readonly DependencyProperty IsAddActiveProperty = DependencyProperty.Register(
        "IsAddActive", typeof(bool), typeof(ScenarioGroupControl), new PropertyMetadata(false));

        public string HeaderTitle
        {
            get { return (string)this.GetValue(HeaderTitleProperty); }
            set { this.SetValue(HeaderTitleProperty, value); }
        }

        public static readonly DependencyProperty HeaderTitleProperty = DependencyProperty.Register(
        "HeaderTitle", typeof(string), typeof(ScenarioGroupControl), new PropertyMetadata(string.Empty));

        public SolidColorBrush HeaderColorBrush
        {
            get { return (SolidColorBrush)this.GetValue(HeaderColorBrushProperty); }
            set { this.SetValue(HeaderColorBrushProperty, value); }
        }

        public static readonly DependencyProperty HeaderColorBrushProperty = DependencyProperty.Register(
        "HeaderColorBrush", typeof(SolidColorBrush), typeof(ScenarioGroupControl), new PropertyMetadata(new SolidColorBrush()));

        public UIElementCollection Children
        {
            get { return (UIElementCollection)GetValue(ChildrenProperty); }
            set { SetValue(ChildrenProperty, value); }
        }

        public static readonly DependencyProperty ChildrenProperty = DependencyProperty.Register(
        "Children", typeof(UIElementCollection), typeof(ScenarioGroupControl), null);

        public ScenarioGroupeTypEnum ScenarioGroupType
        {
            get { return (ScenarioGroupeTypEnum)GetValue(ScenarioGroupTypeProperty); }
            set { SetValue(ScenarioGroupTypeProperty, value); }
        }

        public static readonly DependencyProperty ScenarioGroupTypeProperty = DependencyProperty.Register(
        "ScenarioGroupType", typeof(ScenarioGroupeTypEnum), typeof(ScenarioGroupControl), new PropertyMetadata(ScenarioGroupeTypEnum.Action));

        public DomoItemControl.DomoItemType ScenarioGroupDomoItemType
        {
            get { return (DomoItemControl.DomoItemType)GetValue(ScenarioGroupDomoItemTypeProperty); }
            set { SetValue(ScenarioGroupDomoItemTypeProperty, value); }
        }

        public static readonly DependencyProperty ScenarioGroupDomoItemTypeProperty = DependencyProperty.Register(
        "ScenarioGroupDomoItemType", typeof(DomoItemControl.DomoItemType), typeof(ScenarioGroupControl), new PropertyMetadata(DomoItemControl.DomoItemType.None));

        #endregion dp

        public ScenarioGroupControl()
        {
            InitializeComponent();
        }

        private void ScenarioGroupControl_OnLoaded(object sender, RoutedEventArgs e)
        {
            try
            {
                DataContext = new ScenarioGroupViewModel(ScenarioGroupType, ScenarioGroupDomoItemType);
                (this.DataContext as ScenarioGroupViewModel).HeaderTitle = HeaderTitle;
                (this.DataContext as ScenarioGroupViewModel).HeaderColor = HeaderColorBrush;
                (this.DataContext as ScenarioGroupViewModel).IsAddActive = IsAddActive;
            }
            catch (Exception exp)
            {

            }
        }
    }
}
