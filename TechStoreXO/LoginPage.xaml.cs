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
                    DisplayAlert("Scanned Barcode", result.Text, "OK");

                    entryUserID.Text = result.Text;
                    Login_Clicked(sender, e);
                });
            };
            // Navigate to Scanner Page
            await Navigation.PushAsync(scanPage);
        }

        async void Login_Clicked(object sender, System.EventArgs e)
        {
            string userid = entryUserID.Text;
            // TODO: validate user id

            // Navigate to Main Page
            await Navigation.PushAsync(new MainPage() { userID = userid });
        }

        public LoginPage()
        {
            InitializeComponent();
        }
    }
}
