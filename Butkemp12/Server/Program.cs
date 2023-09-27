namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Это наш клиент");
            OurServer server = new OurServer();
        }
    }
}