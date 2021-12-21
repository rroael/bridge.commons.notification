using System;
using System.Net.Mail;

namespace Bridge.Commons.Notification.Mail.Contracts
{
    public interface IMailService : IDisposable
    {
        void SendAsync(MailMessage mailMessage);
        void Send(MailMessage mailMessage);
        void SendAsyncCancel();
    }
}