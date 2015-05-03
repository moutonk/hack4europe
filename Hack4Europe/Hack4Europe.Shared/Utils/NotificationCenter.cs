using System;
using Windows.Networking.PushNotifications;
using Hack4Europe.Data;

namespace Hack4Europe.Utils
{
    public static class NotificationCenter
    {
        public static PushNotificationChannel PushChannel = null;

        //call static constructor
        public static void Start() { }

        private async static void Init()
        {
            try
            {
                PushChannel = await PushNotificationChannelManager.CreatePushNotificationChannelForApplicationAsync();
                PushChannel.PushNotificationReceived += channel_PushNotificationReceived;
                Logs.Output.ShowOutput(PushChannel.Uri);
                Logs.Output.ShowOutput(PushChannel.ExpirationTime.ToString());
            }

            catch (Exception ex)
            {
                Logs.Error.ShowError(ex.Message);
            }
        }

        private static void channel_PushNotificationReceived(PushNotificationChannel sender, PushNotificationReceivedEventArgs args)
        {
            Logs.Output.ShowOutput(args.NotificationType.ToString());
            DataManager.HasToRequestNotifications = true;
        }

        static NotificationCenter()
        {
            Logs.Output.ShowOutput("NotificationCenter constructor begin");
            Init();
            Logs.Output.ShowOutput("NotificationCenter constructor end");
        }
    }
}
