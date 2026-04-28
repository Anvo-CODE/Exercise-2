using System;

namespace Absolute_Difference_or_Double_It
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Nhập 2 số nguyên: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            bool lớn = a > b;
            if (lớn)
            {
                Console.WriteLine("kết quả là " + (Math.Abs(a - b) * 2));
            }
            else
            {
                Console.WriteLine("kết quả là " + Math.Abs(a - b));
            }
        }
    }
}