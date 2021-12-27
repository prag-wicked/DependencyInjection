namespace DependencyInjectionExampleNetCore
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IMessage 
    { 
        void Send(string text);  
    }

    public class PrintMessage : IMessage
    {
        public void Send(string text)
        {
            Console.WriteLine(text);
        }
    }

    public class EmailMessage : IMessage
    {
        public EmailMessage(IEmployee employee, IConsumer consumer)
        {

        }

        public void Send(string text)
        {
            Console.WriteLine("Message is emailed");
        }
    }
}
