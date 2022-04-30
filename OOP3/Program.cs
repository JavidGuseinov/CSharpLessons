using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager personalFinanceCreditManager = new PersonalFinanceCreditManager();
            ICreditManager transportCreditManager = new TransportCreditManager();
            ICreditManager housingCreditManager = new HousingCreditManager();
            //ILoggerService NotificationLoggerService = new NotificationLoggerService();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            ApplyManager applyManager = new ApplyManager();
            applyManager.Apply(new BusinessCreditManager(), new List<ILoggerService>{new DatabaseLoggerService(), new SmsLoggerService(), new NotificationLoggerService()});

            List<ICreditManager> credits = new List<ICreditManager>() {personalFinanceCreditManager, transportCreditManager };

            //applyManager.CreditGiveAdvanceNotice(credits);


        }
    }
}
