namespace Bridge.Commons.Notification.PushNotification.Models
{
    public class PushNotificationPush
    {
        public PushNotificationPush()
        {
            @default = "Default Notification.";
        }

        public string @default { get; set; }

        public string APNS_SANDBOX { get; set; }

        public string APNS { get; set; }

        public string GCM { get; set; }
    }
}