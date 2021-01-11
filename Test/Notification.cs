using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    /// <summary>
    /// Notification 类负责消息推送，依赖 MessageSender 类实现推送商品促销(站内信)、验证码（短信）等消息给用户。
    /// </summary>
    public class Notification
    {
        private readonly IMessageSender messageSender;
        public Notification(IMessageSender messageSender) //依赖注入
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
