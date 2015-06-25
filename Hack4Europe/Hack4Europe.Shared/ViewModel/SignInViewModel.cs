using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.System.Threading;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Hack4Europe.Model;
using Hack4Europe.View;
using Hack4Europe.Ws;

namespace Hack4Europe.ViewModel
{
    class SignInViewModel : ViewModelBase, ICommand
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

        private string _password;
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                NotifyPropertyChanged(ref _password, value);
            }
        }

        public SignInViewModel()
        {
            OnClickCommand = this;
            _frame = (Frame) Window.Current.Content;
            Login = "kevin@hack4europe.com";
            Password = "toto";
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
                    SignIn();
                    break;
            }
        }

        public void SignUp()
        {

        }

        public void SignIn()
        {
            new SignInModelDal(SignInCallback).SignIn(Login, Password);
        }

        public void SignInCallback(WebServiceResponse response)
        {
            Windows.ApplicationModel.Core.CoreApplication.MainView.CoreWindow.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () => _frame.Navigate(typeof (HomeView)));
        }
    }
}
