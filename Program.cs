namespace calcul
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first;
            int second;
            int final = 0;
            char znak;


            Console.WriteLine("Введите первое число");
            first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите знак действия(+, -,,)");
            znak = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ответ ");

            if (znak == '/')
            {
                final = first / second;
            }

            Console.WriteLine(final);




        }
    }
}
