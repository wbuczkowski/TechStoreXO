﻿using Android.App;
using Android.Widget;
using TechStoreXO.Droid;

[assembly: Xamarin.Forms.Dependency(typeof(MessageAndroid))]
namespace TechStoreXO.Droid
{
    public class MessageAndroid : IMessage
    {
        public void LongAlert(string message) => Toast.MakeText(Application.Context, message, ToastLength.Long).Show();

        public void ShortAlert(string message) => Toast.MakeText(Application.Context, message, ToastLength.Short).Show();
    }
}
