using System.Windows.Input;

namespace Hack4Europe.ViewModel
{
    class SettingsViewModel : ViewModelBase, ICommand
    {
        public ICommand ItemClickCommand { get; set; }

        public SettingsViewModel()
        {
            ItemClickCommand = this;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event System.EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            var num = (int) parameter;

            switch (num)
            {
                case 0:
                    LogOff();
                    break;

                case 1:
                    About();
                    break;
            }
        }

        public void LogOff()
        {

        }

        public void About()
        {

        }
    }
}
