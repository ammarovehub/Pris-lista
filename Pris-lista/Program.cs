using System;

class Program
{
    static void Main(string[] args)
    {
        bool keepRunning = true;

        while (keepRunning)
        {
            // Visa huvudmenyn
            Console.WriteLine("\nVälkommen till huvudmenyn!");
            Console.WriteLine("1. Ungdom eller pensionär");
            Console.WriteLine("2. Gruppbiljett");
            Console.WriteLine("3. Upprepa text tio gånger");
            Console.WriteLine("4. Det tredje ordet");
            Console.WriteLine("0. Avsluta");
            Console.Write("Ange ditt val: ");
        }


    }
}