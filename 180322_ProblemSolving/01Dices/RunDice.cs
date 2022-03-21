using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace _180322_ProblemSolving._01Dices
{
    internal static class RunDice
    {
        //Creating two players
        private static readonly Dice playerOne = new("Red");
        private static readonly Dice playerTwo = new("Green");

        //Creating lists for scorekeeping
        private static readonly List<int> playerOneResult = new();
        private static readonly List<int> playerTwoResult = new();

        //Play game method
        public static void PlayDice()
        {
            RollDices();
            PrintText();
            CheckWinner();
        }

        //Throw each dice five times
        private static void RollDices()
        {
            for (int i = 0; i < 5; i++)
            {
                //The lists add each thrown dice
                playerOneResult.Add(playerOne.ThrowDice());
                playerTwoResult.Add(playerTwo.ThrowDice());
            }
        }

        //Prints out text of each players dice rolls
        private static void PrintText()
        {
            //Prints out player ones rolls
            foreach (int nr in playerOneResult)
            {
                WriteLine(playerOne.DiceColor + " dice: " + nr);
                playerOne.Result += nr;
            }

            WriteLine("\n" + playerOne + "\n");

            //Prints out player twos rolls
            foreach (int nr in playerTwoResult)
            {
                WriteLine(playerTwo.DiceColor + " dice: " + nr);
                playerTwo.Result += nr;
            }

            WriteLine("\n" + playerTwo + "\n");
        }

        //Checks who the winner is
        private static void CheckWinner()
        {
            if (playerOne.Result > playerTwo.Result)
            {
                WriteLine("Winner! " + playerOne.DiceColor);
            }
            else if (playerOne.Result < playerTwo.Result)
            {
                WriteLine("Winner is " + playerTwo.DiceColor + " dice!");
            }
            else
            {
                WriteLine("It's a draw!");
            }
        }
    }
}
