using Xamarin.Forms;
using System.ComponentModel;
using AccentControl.ViewModel;

namespace AccentControl
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();
        }

        
    }
}
