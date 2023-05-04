﻿namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Number guessing game
            var r = new Random();
            var favNumber = r.Next(0, 1001); 

            Console.WriteLine("Pick a number from 1 - 1000");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput < favNumber)
            {
                Console.WriteLine($"{userInput} is too low");
            }
            else if(userInput > favNumber)
            {
                Console.WriteLine($"{userInput} is too high");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}
