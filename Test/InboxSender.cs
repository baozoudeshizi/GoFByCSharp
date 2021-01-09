using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    /// <summary>
    /// 站内短信发送类
    /// </summary>
    class InboxSender : IMessageSender
    {
        public void Send(string cellphone, string message)
        {
            throw new NotImplementedException();
        }
    }
}
