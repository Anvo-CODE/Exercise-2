using System;
namespace Add_First_Character_to_Front_and_Back;
   class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("nhập câu muốn đảo: ");
        String câu = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(câu))
        { Console.WriteLine("Vui lòng nhập câu"); }
        else
        {
            string đầu = câu.Substring(0, 1);
            Console.WriteLine($"{đầu}{câu}{đầu}");
        }
    }
}
