using System;
using System.Windows.Input;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Hack4Europe.View;

namespace Hack4Europe.ViewModel
{
    class FirstViewViewModel : ViewModelBase, ICommand
    {
        private Frame _frame;
        public ICommand OnClickCommand { get; set; }

        public FirstViewViewModel()
        {
            OnClickCommand = this;
            _frame = (Frame) Window.Current.Content;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            var num = int.Parse((string)parameter);
            switch (num)
            {
                case 0:
                    SignUp();
                    break;

                case 1:
                    SignIn();
                    break;
            }
        }

        public void SignUp()
        {

        }

        public void SignIn()
        {
            _frame.Navigate(typeof (SignInView));
        }
    }
}
