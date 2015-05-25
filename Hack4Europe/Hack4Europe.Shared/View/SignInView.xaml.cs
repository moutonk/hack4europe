using Windows.System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Hack4Europe.ViewModel;

namespace Hack4Europe.View
{
    public sealed partial class SignInView : Page
    {
        public SignInView()
        {
            this.InitializeComponent();
        }

        private void EmailOnKey_Down(object sender, KeyRoutedEventArgs e)
        {
            if (e.Key == VirtualKey.Enter)
                PasswordBox.Focus(FocusState.Keyboard);
        }

        private void PasswordBox_OnKeyDown(object sender, KeyRoutedEventArgs e)
        {
            if (e.Key == VirtualKey.Enter)
                (ContentGrid.DataContext as SignInViewModel).SignUp();
        }
    }
}
