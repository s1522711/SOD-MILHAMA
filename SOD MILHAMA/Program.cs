using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Time: ");
            int time = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 1; i <= time; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    Console.Write(i+"\t");
                }
                Console.WriteLine();
                if (i.ToString().Contains("69") || i % 69 == 0)
                {
                    MakeBeep();
                    count++;
                }
                Thread.Sleep(10);
            }
            MakeBeep();
            Console.WriteLine(count + " impostoraw");
        }

        static void MakeBeep()
        {
            for (int i = 0; i < 7; i++)
            {
                Thread.Sleep(200);
                Console.Beep();
            }
        }
    }
}