using System;
using System.Net;
using System.Net.Mail;
using Bridge.Commons.Notification.Mail.Contracts;
using Bridge.Commons.Notification.Mail.Settings;

namespace Bridge.Commons.Notification.Mail
{
    public class SmtpService : IMailService
    {
        private SmtpClient _smtpClient;

        public SmtpService(SmtpSettings settings)
        {
            _smtpClient = new SmtpClient
            {
                Host = settings.Host,
                Port = settings.Port,
                Timeout = settings.Timeout,
                EnableSsl = settings.EnableSsl,
                UseDefaultCredentials = settings.UseDefaultCredentials,
                Credentials = new NetworkCredential(settings.UserName, settings.Password)
            };
        }

        public void Dispose()
        {
            _smtpClient?.Dispose();
        }

        public void SendAsync(MailMessage mailMessage)
        {
            Validate();

            _smtpClient.SendAsync(mailMessage, "");
        }

        public void Send(MailMessage mailMessage)
        {
            Validate();

            _smtpClient.Send(mailMessage);
        }

        public void SendAsyncCancel()
        {
            Validate();

            _smtpClient.SendAsyncCancel();
        }

        private void Validate()
        {
            if (_smtpClient == null)
                throw new NullReferenceException("MailService: SmtpClient is null.");
        }

        ~SmtpService()
        {
            _smtpClient = null;
        }
    }
}