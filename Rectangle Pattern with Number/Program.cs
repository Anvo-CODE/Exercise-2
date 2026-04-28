using System;
namespace Repeat_Number_in_Rows
{
    public class program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("nhập số muốn tạo hình");
            string số = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(số))
            { 
                Console.WriteLine("Vui lòng nhập số");
        } else {
              for (int i=0; i<5;i++)
            {Console.WriteLine("{0}{0}{0}", số);
        }

}
        }
    }
}