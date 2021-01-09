using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    public interface IMessageSender
    {
        public void Send(string cellphone, string message);
    }
}
