using System.Drawing;
using AccentControl.ViewModel;

namespace AccentControl.Model
{
    public class Chair : BaseViewModel
    {
        private Color _colorChair;
        private Color _colorNumber;
        private string _imageIcon;
        private string _name;

        public string ImageIcon
        {
            get { return _imageIcon; }
            set { SetProperty(ref _imageIcon, value); }
        }

        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        public Color ColorChair
        {
            get { return _colorChair; }
            set { SetProperty(ref _colorChair, value); }
        }
        public Color ColorNumber
        {
            get { return _colorNumber; }
            set { SetProperty(ref _colorNumber, value); }
        }

    }
}
