using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FloatingEntry
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void txtName_Focused(object sender, FocusEventArgs e)
        {
            bottomBarName.Color = Color.FromHex("#FF4081");
            lblName.TextColor = Color.FromHex("#FF4081");
            if (string.IsNullOrEmpty(txtName.Text))
            {
                await Task.WhenAll(
                     lblName.ScaleTo(0.7, 200),
                     lblName.TranslateTo(-6, -20, 200)
                    );
            }
        }

        private async void txtName_Unfocused(object sender, FocusEventArgs e)
        {
            bottomBarName.Color = Color.Black;
            lblName.TextColor = Color.DimGray;
            if (string.IsNullOrEmpty(txtName.Text))
            {
                await Task.WhenAll(
                     lblName.ScaleTo(1, 200),
                     lblName.TranslateTo(0, 0, 200)
                    );
            }
        }

        private async void txtDetail_Focused(object sender, FocusEventArgs e)
        {
            bottomBarDetail.Color = Color.FromHex("#FF4081");
            lblDetail.TextColor = Color.FromHex("#FF4081");
            if (string.IsNullOrEmpty(txtDetail.Text))
            {
                await Task.WhenAll(
                     lblDetail.ScaleTo(0.7, 200),
                     lblDetail.TranslateTo(-6, -20, 200)
                    );
            }
        }

        private async void txtDetail_Unfocused(object sender, FocusEventArgs e)
        {
            bottomBarDetail.Color = Color.Black;
            lblDetail.TextColor = Color.DimGray;
            if (string.IsNullOrEmpty(txtDetail.Text))
            {
                await Task.WhenAll(
                     lblDetail.ScaleTo(1, 200),
                     lblDetail.TranslateTo(0, 0, 200)
                    );
            }
        }
    }
}
