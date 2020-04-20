using Xamarin.Forms;
using System.Drawing;
using AccentControl.Model;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using AccentControl.Helpers;

namespace AccentControl.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        private Chair _itemSelected;
        public Command<Chair> _selectedCommand;
        private ObservableCollection<Chair> _chair;       

        public ObservableCollection<Chair> Chairs
        {
            get { return _chair; }
            set { SetProperty(ref _chair, value); }
        }
        public Chair ItemSelected
        {
            get { return _itemSelected; }
            set { SetProperty(ref _itemSelected, value); }
        }
        

        public MainViewModel()
        {
            LoadChairList();
        }

        public Command<Chair> SelectedCommand => _selectedCommand ?? (_selectedCommand = new Command<Chair>(async (chair) => await SelectedCommandExecute(chair)));

        private async Task SelectedCommandExecute(Chair chair)
        {
            if(chair.ColorNumber == System.Drawing.Color.LightBlue)
                await DisplayAlert("Alert", "This chair cannot be selected", "ok");

            else if (chair.ColorNumber == System.Drawing.Color.Blue)
            {
                chair.ColorNumber = System.Drawing.Color.Green;
                chair.ColorChair = System.Drawing.Color.LightGreen;
            }
            else if(chair.ColorNumber == System.Drawing.Color.Green)
            {
                chair.ColorNumber = System.Drawing.Color.Blue;
                chair.ColorChair = System.Drawing.Color.Blue;
            }
        }

        private void LoadChairList()
        {
            this.Chairs = new ObservableCollection<Chair>(new List<Chair>
            {
                new Chair
                {
                    ImageIcon = FontAwesomeIcons.Chair,
                    Name = "1",
                    ColorNumber = System.Drawing.Color.LightBlue,
                    ColorChair = System.Drawing.Color.LightBlue
                },
                new Chair
                {
                    ImageIcon = FontAwesomeIcons.Chair,
                    Name = "2",
                    ColorNumber = System.Drawing.Color.LightBlue,
                    ColorChair = System.Drawing.Color.LightBlue
                },
                 new Chair
                {
                    ImageIcon = "",
                    Name = "",
                },
                 new Chair
                {
                    ImageIcon = FontAwesomeIcons.Chair,
                    Name = "3",
                    ColorNumber = System.Drawing.Color.Blue,
                    ColorChair = System.Drawing.Color.Blue
                },
                new Chair
                {
                    ImageIcon = FontAwesomeIcons.Chair,
                    Name = "4",
                    ColorNumber = System.Drawing.Color.Blue,
                    ColorChair = System.Drawing.Color.Blue
                },
                 new Chair
                {
                    ImageIcon = FontAwesomeIcons.Chair,
                    Name = "5",
                    ColorNumber = System.Drawing.Color.Green,
                    ColorChair = System.Drawing.Color.LightGreen
                },
                new Chair
                {
                    ImageIcon = FontAwesomeIcons.Chair,
                    Name = "6",
                    ColorNumber = System.Drawing.Color.Green,
                    ColorChair = System.Drawing.Color.LightGreen
                },
                new Chair
                {
                    ImageIcon = "",
                    Name = "",
                },
                new Chair
                {
                    ImageIcon = FontAwesomeIcons.Chair,
                    Name = "7",
                    ColorNumber = System.Drawing.Color.LightBlue,
                    ColorChair = System.Drawing.Color.LightBlue
                },
                 new Chair
                {
                    ImageIcon = FontAwesomeIcons.Chair,
                    Name = "8",
                    ColorNumber = System.Drawing.Color.LightBlue,
                    ColorChair = System.Drawing.Color.LightBlue
                },
                 new Chair
                {
                    ImageIcon = FontAwesomeIcons.Chair,
                    Name = "9",
                    ColorNumber = System.Drawing.Color.Blue,
                    ColorChair = System.Drawing.Color.Blue
                },
                 new Chair
                {
                    ImageIcon = FontAwesomeIcons.Chair,
                    Name = "10",
                    ColorNumber = System.Drawing.Color.Blue,
                    ColorChair = System.Drawing.Color.Blue
                },
                 new Chair
                {
                    ImageIcon = "",
                    Name = "",
                },
                 new Chair
                {
                    ImageIcon = FontAwesomeIcons.Chair,
                    Name = "11",
                    ColorNumber = System.Drawing.Color.LightBlue,
                    ColorChair = System.Drawing.Color.LightBlue
                },
                 new Chair
                {
                    ImageIcon = FontAwesomeIcons.Chair,
                    Name = "12",
                    ColorNumber = System.Drawing.Color.LightBlue,
                    ColorChair = System.Drawing.Color.LightBlue
                },
                new Chair
                {
                    ImageIcon = FontAwesomeIcons.Chair,
                    Name = "13",
                    ColorNumber = System.Drawing.Color.Blue,
                    ColorChair = System.Drawing.Color.Blue
                },
                 new Chair
                {
                    ImageIcon = FontAwesomeIcons.Chair,
                    Name = "14",
                    ColorNumber = System.Drawing.Color.Blue,
                    ColorChair = System.Drawing.Color.Blue
                },
                new Chair
                {
                    ImageIcon = "",
                    Name = "",
                },
                 new Chair
                {
                    ImageIcon = FontAwesomeIcons.Chair,
                    Name = "15",
                    ColorNumber = System.Drawing.Color.Blue,
                    ColorChair = System.Drawing.Color.Blue
                },
                 new Chair
                {
                    ImageIcon = FontAwesomeIcons.Chair,
                    Name = "16",
                    ColorNumber = System.Drawing.Color.Blue,
                    ColorChair = System.Drawing.Color.Blue
                },
                 new Chair
                {
                    ImageIcon = FontAwesomeIcons.Chair,
                    Name = "17",
                    ColorNumber = System.Drawing.Color.Blue,
                    ColorChair = System.Drawing.Color.Blue
                },
                 new Chair
                {
                    ImageIcon = FontAwesomeIcons.Chair,
                    Name = "18",
                    ColorNumber = System.Drawing.Color.Blue,
                    ColorChair = System.Drawing.Color.Blue
                },
                 new Chair
                {
                    ImageIcon = "",
                    Name = "",
                },
                 new Chair{
                    ImageIcon = FontAwesomeIcons.Chair,
                    Name = "19",
                    ColorNumber = System.Drawing.Color.Blue,
                    ColorChair = System.Drawing.Color.Blue
                },
                 new Chair
                {
                    ImageIcon = FontAwesomeIcons.Chair,
                    Name = "20",
                    ColorNumber = System.Drawing.Color.Blue,
                    ColorChair = System.Drawing.Color.Blue
                },
                 new Chair
                {
                    ImageIcon = FontAwesomeIcons.ArrowLeft,
                    Name = "",
                   ColorNumber = System.Drawing.Color.Black,
                    ColorChair = System.Drawing.Color.Black
                },
                 new Chair
                {
                    ImageIcon = "",
                    Name = "",
                },
                 new Chair
                {
                    ImageIcon = FontAwesomeIcons.DoorClosed,
                    Name = "Exit",
                    ColorNumber = System.Drawing.Color.FromArgb(int.Parse("#E0FF0000".Replace("#",""),System.Globalization.NumberStyles.AllowHexSpecifier)),
                    ColorChair = System.Drawing.Color.FromArgb(int.Parse("#E0FF0000".Replace("#",""),System.Globalization.NumberStyles.AllowHexSpecifier)),
                },
                 new Chair
                {
                    ImageIcon = "",
                    Name = "",
                },
                 new Chair
                {
                    ImageIcon = FontAwesomeIcons.ArrowRight,
                    Name = "",
                    ColorNumber = System.Drawing.Color.Black,
                    ColorChair = System.Drawing.Color.Black
                },
                 new Chair
                {
                    ImageIcon = FontAwesomeIcons.Chair,
                    Name = "21",
                    ColorNumber = System.Drawing.Color.Blue,
                    ColorChair = System.Drawing.Color.Blue
                },
                 new Chair
                {
                    ImageIcon = FontAwesomeIcons.Chair,
                    Name = "22",
                    ColorNumber = System.Drawing.Color.Blue,
                    ColorChair = System.Drawing.Color.Blue
                },
                new Chair
                {
                    ImageIcon = "",
                    Name = "",
                },
                new Chair
                {
                    ImageIcon = FontAwesomeIcons.Chair,
                    Name = "23",
                    ColorNumber = System.Drawing.Color.Green,
                    ColorChair = System.Drawing.Color.LightGreen
                },
                 new Chair
                {
                    ImageIcon = FontAwesomeIcons.Chair,
                    Name = "24",
                    ColorNumber = System.Drawing.Color.Green,
                    ColorChair = System.Drawing.Color.LightGreen
                },
                 new Chair
                {
                    ImageIcon = FontAwesomeIcons.Chair,
                    Name = "25",
                    ColorNumber = System.Drawing.Color.Blue,
                    ColorChair = System.Drawing.Color.Blue
                },
                 new Chair
                {
                    ImageIcon = FontAwesomeIcons.Chair,
                    Name = "26",
                    ColorNumber = System.Drawing.Color.Blue,
                    ColorChair = System.Drawing.Color.Blue
                },
                new Chair
                {
                    ImageIcon = "",
                    Name = "",
                },
                new Chair
                {
                    ImageIcon = FontAwesomeIcons.Chair,
                    Name = "27",
                    ColorNumber = System.Drawing.Color.Blue,
                    ColorChair = System.Drawing.Color.Blue
                },
                 new Chair
                {
                    ImageIcon = FontAwesomeIcons.Chair,
                    Name = "28",
                    ColorNumber = System.Drawing.Color.Blue,
                    ColorChair = System.Drawing.Color.Blue
                },
            });
        }

    }
}
