using Xamarin.Forms;

using ZXing.Net.Mobile.Forms;

namespace TechStoreXO
{
    public partial class MainPage : ContentPage
    {
        public string UserID { get; set; }
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
                    // TODO: process barcode
                });
            };
            // Navigate to Scanner Page
            await Navigation.PushAsync(scanPage);
        }

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
