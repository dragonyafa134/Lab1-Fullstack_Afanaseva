class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Меня зовут Афанасьева ДН");
        Console.WriteLine(DateTime.Now);

        while (true)
        {
            Console.WriteLine("Введите имя");
            string name = Console.ReadLine();
            Console.WriteLine($"Привет, {name}!");

            DayOfWeek today = DateTime.Now.DayOfWeek;
            Console.WriteLine($"Сегодня {today}");

            Console.WriteLine("Хотите продолжить? (y/n)");
            string input = Console.ReadLine();

            if ( input == "y")
            {
                Console.WriteLine("Конец");
                break;
            }
        }
    }
}
