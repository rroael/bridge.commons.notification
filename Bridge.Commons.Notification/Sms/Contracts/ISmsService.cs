using System;
using System.Threading.Tasks;
using Bridge.Commons.Notification.Sms.Models;

namespace Bridge.Commons.Notification.Sms.Contracts
{
    public interface ISmsService : IDisposable
    {
        void Send(SmsMessage message);
        Task SendAsync(SmsMessage message);
        void Validate(SmsMessage message);
    }
}