using System.Dynamic;

namespace Bridge.Commons.Notification.PushNotification.Models
{
    /// <summary>
    ///     Android
    /// </summary>
    public class GCMNotification
    {
        public GCM notification { get; set; }

        public string priority { get; set; } = "high";
        public ExpandoObject data { get; set; }
    }

    public class GCMData
    {
        public GCM data { get; set; }
    }

    public class GCM
    {
        public string body { get; set; }

        public string title { get; set; }
    }
}