using System;
using System.Threading.Tasks;
using Bridge.Commons.Notification.PushNotification.Models;

namespace Bridge.Commons.Notification.PushNotification.Contracts
{
    public interface IPushNotificationService : IDisposable
    {
        void Send(PushNotificationRequest message);
        Task SendAsync(PushNotificationRequest message);
        void Validate(PushNotificationRequest message);
        Task<string> RegisterUserEndpoint(PushNotificationRequest request);
        Task<bool> DeleteUserEndpoint(string endpoint);
    }
}