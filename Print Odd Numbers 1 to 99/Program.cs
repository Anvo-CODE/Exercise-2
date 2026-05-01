using System;
namespace Print_Odd_Numbers_1_to_99;
class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
       for (int i=0; i<99; i++)
        {
            Console.WriteLine("kết quả: " + (i + 1));
        }    
    }
}