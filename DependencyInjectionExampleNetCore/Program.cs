// See https://aka.ms/new-console-template for more information
using DependencyInjectionExampleNetCore;
using Microsoft.Extensions.DependencyInjection;




Console.WriteLine("Hello, World!");


var collection = new ServiceCollection()
    //Register
    //.AddScoped<IMessage, PrintMessage>()
    .AddScoped<IConsumer, Consumer>()
    .AddScoped<IEmployee, Employee>()
    .AddScoped<IMessage, EmailMessage>()
    .BuildServiceProvider();

//Get 
var message = collection.GetService<IMessage>();
var message1 = collection.GetRequiredService<IMessage>();

IEmployee e = new Employee();
IConsumer c = new Consumer(); ;
IMessage msg = new EmailMessage(e, c);

var printMessage = new MessageManager(msg);
printMessage.Process("Hello Dependency Injection");