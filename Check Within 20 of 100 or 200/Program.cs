using System;
namespace Check_Within_20_of_100_or_200
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Nhập 1 số nguyên: ");
            int a = int.Parse(Console.ReadLine());
            bool giatri = Math.Abs(100 - a) <= 20 || Math.Abs(200 - a) <= 20;
            if (giatri)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}