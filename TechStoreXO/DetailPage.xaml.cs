using System;
using Xamarin.Forms;
using TechStoreXO.Models;

namespace TechStoreXO
{
    public partial class DetailPage : ContentPage
    {
        public DetailPage()
        {
            InitializeComponent();
        }

        void Save_Clicked(object sender, EventArgs e)
        {
            var record = (Record)BindingContext;
        }

        void Switch_Clicked(object sender, EventArgs e)
        {
            // TODO: switch
        }
    }
}