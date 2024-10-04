namespace FinalizableObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Test();
            GC.Collect();
            Console.Read();
        }

        static void Test()
        {
            Person? tom = null;
            try
            {
                tom = new Person("Tom");
            }
            finally
            {
                tom?.Dispose();
            }
        }
    }
}
