using System;

namespace Bridge.Commons.Notification.Exceptions
{
    public class SmsTooLongException : Exception
    {
        private const string ExceptionMessage = "The sender and message are larger than 160 characters.";

        public SmsTooLongException() : base(ExceptionMessage)
        {
        }

        public SmsTooLongException(Exception innerException = null)
            : base(ExceptionMessage, innerException)
        {
        }
    }
}