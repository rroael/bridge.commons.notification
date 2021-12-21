using System.Dynamic;

namespace Bridge.Commons.Notification.PushNotification.Models
{
    public class PushNotificationRequest
    {
        public string Message { get; set; }
        public string Title { get; set; }
        public bool IosDevice { get; set; } = false;
        public string DeviceToken { get; set; }
        public string PlatformEndpointForAndroid { get; set; }
        public string PlatformEndpointForIos { get; set; }
        public string EndpointArn { get; set; }
        public bool IsSilentPush { get; set; } = false;
        public ExpandoObject ExtraData { get; set; }
    }
}