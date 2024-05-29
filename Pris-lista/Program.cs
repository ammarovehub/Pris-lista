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

            // Läs användarens val
            string choice = Console.ReadLine();
            // Switch-sats för att hantera menyval
            switch (choice)
            {
                case "0":
                    keepRunning = false;
                    break;
                case "1":
                    CheckAge();
                    break;
                case "2":
                    CalculateGroupPrice();
                    break;
                case "3":
                    RepeatText();
                    break;
                case "4":
                    GetThirdWord();
                    break;
                default:
                    Console.WriteLine("Felaktig input, försök igen.");
                    break;
            }

        }
}