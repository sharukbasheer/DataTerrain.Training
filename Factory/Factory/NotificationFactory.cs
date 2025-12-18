using FactoryMethod.Interface;
using FactoryMethod.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Factory
{
    public static class NotificationFactory
    {
        public static INotification CreateNotification(string channel)
        {
            return channel.ToLower() switch
            {
                "sms" => new SmsNotification(),
                "email" => new EmailNotification(),
                _ => throw new ArgumentException("Invalid channel"),
            };
        }
    }
}
