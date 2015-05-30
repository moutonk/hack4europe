using System;
using System.ComponentModel;
using System.Windows.Input;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Hack4Europe.Model;
using Hack4Europe.View;
using Hack4Europe.Ws;
using Windows.UI.Core;

namespace Hack4Europe.ViewModel
{
    class FirstViewViewModel : ViewModelBase, ICommand
    {
        private Frame _frame;
        public ICommand OnClickCommand { get; set; }

        private string _login;
        public string Login
        {
            get
            {
                return _login;
            }
            set
            {
                NotifyPropertyChanged(ref _login, value);
            }
        }

        private string _password1;
        public string Password1
        {
            get
            {
                return _password1;
            }
            set
            {
                NotifyPropertyChanged(ref _password1, value);
            }
        }

        private string _password2;
        public string Password2
        {
            get
            {
                return _password2;
            }
            set
            {
                NotifyPropertyChanged(ref _password2, value);
            }
        }

        public FirstViewViewModel()
        {
            OnClickCommand = this;
            _frame = (Frame) Window.Current.Content;
            Login = "keke";
            Password1 = "toto";
            Password2 = "toto";
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
            new SignUpModelDal(SignUpCallback).SignUp(Login, Password1, Password2);
        }

        public void SignUpCallback(WebServiceResponse data)
        {
            Windows.ApplicationModel.Core.CoreApplication.MainView.CoreWindow.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () => _frame.Navigate(typeof(SignInView)));
        }

        public void SignIn()
        {
            _frame.Navigate(typeof (SignInView));
        }
    }
}
