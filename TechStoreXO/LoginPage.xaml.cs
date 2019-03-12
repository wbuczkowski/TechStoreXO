using System.Text.RegularExpressions;

using Xamarin.Forms;

using ZXing.Net.Mobile.Forms;

namespace TechStoreXO
{
    public partial class LoginPage : ContentPage
    {
        async void Scan_Clicked(object sender, System.EventArgs e)
        {
            ZXingScannerPage scanPage = new ZXingScannerPage();
            scanPage.OnScanResult += (result) =>
            {
                scanPage.IsScanning = false;
                Device.BeginInvokeOnMainThread(() =>
                {
                    Navigation.PopAsync();
                    // DisplayAlert("Scanned Barcode", result.Text, "OK");
                    DependencyService.Get<IMessage>().ShortAlert(result.Text);

                    UserID.Text = result.Text;
                    Login_Clicked(sender, e);
                });
            };
            // Navigate to Scanner Page
            await Navigation.PushAsync(scanPage);
        }

        async void Login_Clicked(object sender, System.EventArgs e)
        {
            if (Validate(UserID.Text))
            {
                // Navigate to Main Page
                await Navigation.PushAsync(new MainPage() { UserID = UserID.Text });
            }
            else
            {
                DependencyService.Get<IMessage>().LongAlert("Log in error");
            }
        }

        private bool Validate(string userid)
        {
            if (Regex.IsMatch(userid, "[a-zA-Z]{3}.*"))
            {
                // first three characters are letters
                if (userid == "GETMEOUT")
                {
                    //TODO: quit?
                }
                return true;
            }
            else
                return false;
        }

        public LoginPage()
        {
            InitializeComponent();
        }
    }
}
