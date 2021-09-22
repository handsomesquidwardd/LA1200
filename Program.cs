using System;



namespace LA_1200_Randomzahl
{
    class Program
    {
        static void Main()
        {



            Random rd = new Random();



            int rand_num = rd.Next(1, 100);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(rand_num);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Random number has been generated");
            Console.WriteLine("Please type in a number between 1 - 100");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            int UserGuesser = Convert.ToInt32(Console.ReadLine());
            int UserAttempt = 1;



            if (UserGuesser > rand_num)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Your number is larger, try typing a smaller one");
                UserAttempt++;
            }
            else if (UserGuesser == rand_num)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("You got it right!");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("It took you" + UserAttempt + " tries ");
            }
            if (UserGuesser < rand_num)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Your number is smaller, try typing a larger one");
                UserAttempt++;
            }



            while (UserGuesser != rand_num)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("No worries! You've got an unlimited amount of tries ");
                Console.ForegroundColor = ConsoleColor.Red;
                UserGuesser = Convert.ToInt32(Console.ReadLine());
                if (UserGuesser > rand_num)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Your Number is larger, try typing a smaller one");
                    UserAttempt++;
                }
                else if (UserGuesser == rand_num)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("You got it right!");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(" It took you " + UserAttempt + " tries ");
                }
                if (UserGuesser < rand_num)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Your number is smaller, try typing a larger one");
                    UserAttempt++;
                }

            }

        }



    }
}