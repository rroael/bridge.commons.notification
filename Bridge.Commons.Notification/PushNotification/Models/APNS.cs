using System.Dynamic;
using Newtonsoft.Json;

namespace Bridge.Commons.Notification.PushNotification.Models
{
    /// <summary>
    ///     IOS
    /// </summary>
    public class APNS
    {
        public Aps aps { get; set; }

        public ExpandoObject data { get; set; }
    }

    public class Aps
    {
        public Alert alert { get; set; }

        [JsonProperty(PropertyName = "content-available")]
        public int contentAvailable { get; set; }

        public int badge { get; set; } = 0;
    }

    public class Alert
    {
        public string title { get; set; }
        public string body { get; set; }
    }
}