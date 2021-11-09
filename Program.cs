using System;

namespace _2222
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] vokaler = "bcdfghjklmnpqrstvwxz".ToCharArray();
            
            string[] text = new string[5]; 

            int count = 0;     
            
            Console.WriteLine("Skriv ord för ord en mening med fem ord");
            
            for (int i = 0; i < text.Length; i++)
            {
                text[i] = Console.ReadLine();
                count++;
                if (vokaler.Length < 2)
                {
                    Console.WriteLine("bruh");
                }
            }
            Console.WriteLine("Här är text baklänges.");

            Array.Reverse(text);

            Console.WriteLine("Antal ord:" + count);

            Console.WriteLine("Svar= " + text[0] + " " + text[1] + " " + text[2] + " " + text[3]+ " " + text[4]);

        }
    }
}
