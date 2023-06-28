namespace TestTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            if (name == "Вячеслав") Console.WriteLine("Привет, Вячеслав");
            else Console.WriteLine("Нет такого имени");
            Console.ReadLine();
        }
    }
}