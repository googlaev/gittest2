using System;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            int a;
           

            try
            {
                a = Convert.ToInt32(Console.ReadLine());
                a = 5 / a;
                Console.WriteLine(a);
            }catch(DivideByZeroException)
            {
                Console.WriteLine("error деление на 0");
            }
            catch(FormatException)
            {
                Console.WriteLine("ввод букв вместо цифр");
            }
            Console.WriteLine("66666666666666666666ыы");
        }   
    }
}
