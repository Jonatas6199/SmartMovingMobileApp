using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartMovingMobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        private string time;
        private string tags;
        public HomePage()
        {
            InitializeComponent();
            LoadItems();
        }
        private void LoadItems()
        {
            ChangeTimeButtonColor(btnTime24H);
            ChangeTagsQuantityColor(btnTags1H);
            DoActionTimeButton(btnTime24H);
            DoActionTagsButton(btnTags1H);
        }
        private void ChangeTimeButtonColor(Button button)
        {
            btnTime24H.BackgroundColor = btnTime7D.BackgroundColor = btnTime15D.BackgroundColor =
            btnTime30D.BackgroundColor = btnTime6M.BackgroundColor = Color.LightGray;

            btnTime24H.TextColor = btnTime7D.TextColor = btnTime15D.TextColor =
            btnTime30D.TextColor = btnTime6M.TextColor = Color.Black;

            
            button.BackgroundColor = Color.FromHex("#2196F3");
            button.TextColor = Color.White;
        }
        private void ChangeTagsQuantityColor(Button button)
        {
            btnTags1H.BackgroundColor = btnTags2H.BackgroundColor = btnTags3H.BackgroundColor =
            btnTags24H.BackgroundColor = btnTags30D.BackgroundColor = Color.LightGray;

            btnTags1H.TextColor = btnTags2H.TextColor = btnTags3H.TextColor =
            btnTags24H.TextColor = btnTags30D.TextColor = Color.Black;


            button.BackgroundColor = Color.FromHex("#2196F3");
            button.TextColor = Color.White;
        }
        private void btnTime_Clicked(object sender, EventArgs e)
        {
            ChangeTimeButtonColor(sender as Button);
            DoActionTimeButton(sender as Button );
        }
        private void btnTags_Clicked(object sender, EventArgs e)
        {
            ChangeTagsQuantityColor(sender as Button);
            DoActionTagsButton(sender as Button);
        }
        private void DoActionTagsButton(Button button)
        {
            if (button == btnTags1H)
                tags = "220";
            else if (button == btnTags2H)
                tags = "353";
            else if (button == btnTags3H)
                tags = "345";
            else if (button == btnTags24H)
                tags = "290";
            else //será 30 DIAS
                tags = "215";
            lblTags.Text = tags;
        }
        private void DoActionTimeButton(Button button)
        {
            if (button == btnTime24H)
                time = "47,23 minutos";
            else if (button == btnTime7D)
                time = "1,5 horas";
            else if (button == btnTime15D)
                time = "1,2 horas";
            else if (button == btnTime30D)
                time = "1,3 horas";
            else //será 6 meses
                time = "58 minutos";

            lblTime.Text = time;
        }

    }
}