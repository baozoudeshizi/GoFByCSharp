using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            // 使用 Notification
            IMessageSender messageSender = new SmsSender();
            //IMessageSender messageSender = new InboxSender();
            //通过构造函数，在使用通知的时候，传入具体的SmsSender或者IndexSender
            Notification notification = new Notification(messageSender);
            notification.SendMessage("hello", "word");
            Console.WriteLine("Hello World!");
        }
    }
}
