﻿using System;

class Program
{ 
    static void Main(string[] args)
    {
        bool keepRunning = true;

        while (keepRunning)
        {
            // Visa huvudmenyn
            Console.WriteLine("\nVälkommen till huvudmenyn!");
            Console.WriteLine("1. Enkel biljett");
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
                    Enkel();
                    break;
                case "2":
                    Grupp();
                    break;
                case "3":
                    Upprepa();
                    break;
                case "4":
                    Tredje();
                    break;
                default:
                    Console.WriteLine("Felaktig input, försök igen.");
                    break;
            }

        }
    }

    static void Enkel()
    {
        // Frågar efter ålder
        Console.Write("Ange din ålder: ");
        string input = Console.ReadLine();
        if (int.TryParse(input, out int age))
        {
            if (age < 5 || age > 100)
            {
                Console.WriteLine("Gratis inträde.");
            }
            else if (age < 20)
            {
                Console.WriteLine("Ungdomspris: 80kr");
            }
            else if (age > 64)
            {
                Console.WriteLine("Pensionärspris: 90kr");
            }
            else
            {
                Console.WriteLine("Standardpris: 120kr");
            }
        }
        else
        {
            Console.WriteLine("Felaktig input. Vänligen ange en siffra.");
        }
    }

    static void Grupp()
    {
        // Frågar hur många personer
        Console.Write("Hur många är ni i sällskapet? ");
        string input = Console.ReadLine();
        if (int.TryParse(input, out int numberOfPeople))
        {
            int totalCost = 0;

            for (int i = 0; i < numberOfPeople; i++)
            {
                Console.Write($"Ange ålder för person {i + 1}: ");
                input = Console.ReadLine();

                if (int.TryParse(input, out int age))
                {
                    if (age < 5 || age > 100)
                    {
                        // Gratis inträde
                        continue;
                    }
                    else if (age < 20)
                    {
                        totalCost += 80;
                    }
                    else if (age > 64)
                    {
                        totalCost += 90;
                    }
                    else
                    {
                        totalCost += 120;
                    }
                }
                else
                {
                    Console.WriteLine("Felaktig input. Vänligen ange en siffra.");
                    i--; // Repetera denna iteration för att få korrekt input
                }
            }
            Console.WriteLine($"Antal personer: {numberOfPeople}");
            Console.WriteLine($"Totalkostnad för hela sällskapet: {totalCost}kr");
        }
        {
            Console.WriteLine("Felaktig input. Vänligen ange en siffra.");
        }
    }

    static void Upprepa()
    {
        // Frågar efter text
        Console.Write("Ange en text att upprepa: ");
        string input = Console.ReadLine();

        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"{i}. {input}");
            if (i < 10)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
    }

    static void Tredje()
    {
        // Frågar efter en mening
        Console.Write("Ange en mening med minst 3 ord: ");
        string input = Console.ReadLine();
        string[] words = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        if (words.Length >= 3)
        {
            Console.WriteLine($"Det tredje ordet är: {words[2]}");
        }
        else
        {
            Console.WriteLine("Felaktig input. Vänligen ange en mening med minst 3 ord.");
        }
    }
}