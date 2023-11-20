namespace ConsoleApp1
{
    class Data
    {
        int number = 5;
        string tekst = "apekatt";
        char character = 'Æ';
        long looongnumber = 6969696969;
        float hæ = 64;
        decimal HæIgjen = 2;
        double TALL = 2.0;
        bool ja = true;
        int randomnumber012 = new Random().Next(0, 3);
    }
    class Program
    {
        static void Main(string[] args)
        {
            calculate(args);
            Console.WriteLine("Hei, hva er navnet ditt?");
            second(args);
        }
        static void second(string[] args)
        {
            var num = Console.ReadLine();
            Console.WriteLine($"Hei, {num}!");
            calculate(args);
            //second(args);
        }
        //static void testfunction(string[] args)
        //{
        //    var test = Console.ReadLine();
        //    if(test == "test")
        //    {
        //        Console.WriteLine("Yes");
        //        testfunction(args);
        //    }
        //    else
        //    {
        //        Console.WriteLine("no");
        //        testfunction(args);
        //    }
        //}
        static void calculate(string[] args)
        {
            var Linje1 = Console.ReadLine();
            var Linje2 = Console.ReadLine();
            //NumberAdd(Linje1, Linje2);
            Console.WriteLine(NumberAdd(Linje1, Linje2));
            //var test = int.Parse(line1);
            calculate(args);

            static string NumberAdd(string Linje1, string Linje2)
            {
                int number1 = Convert.ToInt32(Linje1);
                int number2 = Convert.ToInt32(Linje2);
                string returnnumber = $"{number1} + {number2} = {number1 + number2}";
                return returnnumber;
            }
        }
    }
}