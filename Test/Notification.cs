using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    public class Notification
    {
        private readonly IMessageSender messageSender;
        public Notification(IMessageSender messageSender)
        {
            this.messageSender = messageSender;
        }
        public void SendMessage(string cellphone, string message)
        {
            //调用SmsSender或者InboxSend的Send方法
            this.messageSender.Send(cellphone, message);
        }
    }
}
