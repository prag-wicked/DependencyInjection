namespace DependencyInjectionExampleNetCore
{
    public interface IConsumer
    {
        public string Type { get; set; }
    }

    public class Consumer : IConsumer
    {
        public string Type { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

    public interface IEmployee
    {
        public string Name { get; set; }
    }

    public class Employee : IEmployee
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}