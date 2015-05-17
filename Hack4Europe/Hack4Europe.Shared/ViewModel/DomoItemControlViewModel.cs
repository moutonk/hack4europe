using System.Linq;
using Hack4Europe.Data;
using Hack4Europe.UserControls;

namespace Hack4Europe.ViewModel
{
    class DomoItemControlViewModel : ViewModelBase
    {
        private string _textDescription;
        public string TextDescription
        {
            get
            {
                return _textDescription;
            }
            set
            {
                NotifyPropertyChanged(ref _textDescription, value);
            }
        }

        private int _valueSlider;
        public int ValueSlider
        {
            get
            {
                return _valueSlider;
            }
            set
            {
                NotifyPropertyChanged(ref _valueSlider, value);
            }
        }

        private IconInfoViewModel _icon;
        public IconInfoViewModel Icon
        {
            get
            {
                return _icon;
            }
            set
            {
                NotifyPropertyChanged(ref _icon, value);
            }
        }

        private DomoItemControl.DomoItemType _type;
        public DomoItemControl.DomoItemType Type
        {
            get
            {
                return _type;
            }
            set
            {
                NotifyPropertyChanged(ref _type, value);
            }
        }
        
        public bool IsActive { get; set; }

        public void IconOnTapped()
        {
            foreach (var iconList in DataManager.CircularLinkedIconList)
            {
                foreach (var icon in iconList)
                {
                    if (icon.Id == Icon.Id)
                    {
                        if (iconList.IndexOf(icon) == iconList.Count - 1)
                            Icon = iconList.FirstOrDefault();
                        else
                            Icon = iconList.GetRange(iconList.IndexOf(icon) + 1, 1).FirstOrDefault();
                        return;

                    }
                }
                
            }
        }

    }

    public class IconInfoViewModel : ViewModelBase
    {
        public enum IconState
        {
            Active,
            Inactive
        }

        public int Id { get; set; }
        public IconState State { get; set; }

        private string _uri;
        public string Uri
        {
            get
            {
                return _uri;
            }
            set
            {
                NotifyPropertyChanged(ref _uri, value);
            }
        }
    }
}
