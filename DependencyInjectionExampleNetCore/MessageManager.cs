namespace DependencyInjectionExampleNetCore
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class MessageManager
    {
        private IMessage message;

        public MessageManager(IMessage message)
        {
            this.message = message;
        }

        public void Process(string text)
        {
            this.message.Send(text);
        }
    }
}
