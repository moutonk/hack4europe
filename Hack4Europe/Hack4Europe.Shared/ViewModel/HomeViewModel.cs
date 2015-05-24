using System.Collections.ObjectModel;
using System.Windows.Input;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Hack4Europe.UserControls;
using Hack4Europe.View;

namespace Hack4Europe.ViewModel
{
    class HomeViewModel : ViewModelBase, ICommand
    {
        private static Frame _rootFrame;

        public ICommand VoiceCommand { get; set; }

        public HomeViewModel()
        {
            VoiceCommand = this;
            _rootFrame = (Frame)Window.Current.Content;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event System.EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            _rootFrame.Navigate(typeof(VoiceRecognitionView));
        }
    }
}
