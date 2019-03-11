﻿using Foundation;
using TechStoreXO.iOS;
using UIKit;

[assembly: Xamarin.Forms.Dependency(typeof(MessageIOS))]
namespace TechStoreXO.iOS
{
    public class MessageIOS : IMessage
    {
        const double LONG_DELAY = 3.5;
        const double SHORT_DELAY = 2.0;

        NSTimer alertDelay;
        UIAlertController alert;

        public void LongAlert(string message) => ShowAlert(message, LONG_DELAY);

        public void ShortAlert(string message) => ShowAlert(message, SHORT_DELAY);

        void ShowAlert(string message, double seconds)
        {
            alertDelay = NSTimer.CreateScheduledTimer(seconds, (obj) =>
            {
                DismissMessage();
            });
            alert = UIAlertController.Create(null, message, UIAlertControllerStyle.Alert);
            UIApplication.SharedApplication.KeyWindow.RootViewController.PresentViewController(alert, true, null);
        }

        void DismissMessage()
        {
            if (alert != null) alert.DismissViewController(true, null);
            if (alertDelay != null) alertDelay.Dispose();
        }
    }
}
