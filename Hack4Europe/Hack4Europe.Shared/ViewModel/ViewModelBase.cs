using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Hack4Europe.ViewModel
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        protected ViewModelBase()
        {
            WsOver = true;
        }

        private bool _wsOver;
        public bool WsOver
        {
            get { return _wsOver; }
            set
            {
                NotifyPropertyChanged(ref _wsOver, value);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string nomPropriete)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(nomPropriete));
        }

        protected bool NotifyPropertyChanged<T>(ref T variable, T valeur, [CallerMemberName] string nomPropriete = null)
        {
            if (object.Equals(variable, valeur)) return false;

            variable = valeur;
            NotifyPropertyChanged(nomPropriete);
            return true;
        }
    }
}
