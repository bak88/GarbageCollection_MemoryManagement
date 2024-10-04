namespace UsingConstruct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Test();
        }
        static void Test()
        {
            using Person tom = new Person("Tom");
            Console.WriteLine($"Name: {tom.Name}");
            Console.WriteLine("End");
        }
    }
}
