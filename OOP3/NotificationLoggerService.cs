using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class NotificationLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Notification sent");
        }
    }
}
