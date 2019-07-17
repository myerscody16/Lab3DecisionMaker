using System;

namespace Lab3DecisonMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input your name and then press enter.");
            string name = Console.ReadLine();
            char answer;
            bool cont = true, cont1 = true;
            while(cont)
            {
                int num = 0;
                Console.WriteLine($"Hi {name}, this will tell you some interesting things about a chosen number.");
                while (cont1)
                {
                    Console.WriteLine($"{name}, please input an integer between 1 and 100 and press enter.");
                    string usrInput = Console.ReadLine();
                    num = int.Parse(usrInput);
                    if (num < 1 || num >100)
                    {
                        Console.WriteLine("The value is not between 1 and 100, please try again.");
                        continue;
                    }
                    else if (num >= 1 && num <= 100)
                    {
                        cont1 = false;
                    }

                    int remain = num % 2;
                    if (remain == 0 && num >= 2 && num < 25)
                    {
                        Console.WriteLine("Even and less than 25.");
                    }
                    else if (remain == 0 && num >= 26 && num < 60)
                    {
                        Console.WriteLine("Even.");
                    }
                    else if (remain == 0 && num >= 60 && num <= 100)
                    {
                        Console.WriteLine("Even.");
                    }
                    else if (remain != 0 && num >= 60 && num < 100)
                    {
                        Console.WriteLine("Odd.");
                    }
                    else if (remain != 0)
                    {
                        Console.WriteLine("Odd.");
                    }

                    Console.WriteLine($"{name}, would you like to continue? (y/n)");
                    string ans = Console.ReadLine().ToLower();
                    answer = char.Parse(ans);
                    if (answer == 'y')
                    {
                        cont1 = true;
                    }
                    else
                    {
                        Console.WriteLine($"Thank you {name}, have a great day");
                        cont1 = false;
                        cont = false;
                    }
                }
            }
        }
    }
}
