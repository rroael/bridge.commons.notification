namespace Bridge.Commons.Notification.Mail.Settings
{
    public class SmtpSettings
    {
        public bool EnableSsl { get; set; } = true;
        public string Host { get; set; }
        public string Password { get; set; }
        public int Port { get; set; }
        public int Timeout { get; set; } = 100000;
        public bool UseDefaultCredentials { get; set; } = false;
        public string UserName { get; set; }
    }
}