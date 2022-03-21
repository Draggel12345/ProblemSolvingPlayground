using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180322_ProblemSolving._01Dices
{
    internal class Dice
    {
        //Variables
        private int id;
        private string diceColor;
        private int result;

        //Util variables and the diceSize.
        private static int IdCounter = 0;
        private static readonly int[] DiceSize = { 1, 2, 3, 4, 5, 6 };
        private static readonly Random Rnd = new();

        //Props
        //Checks that value is sat only if it's greater than zero.
        public int Id { get => id; private set { if (value is > 0) { id = value; } } }
        //Checks that value is sat only if it's not equal to null. If null, throws new null exception.
        public string DiceColor { get => diceColor ?? throw new ArgumentNullException(nameof(diceColor)); private set { if (value is not null) { diceColor = value; } } }
        public int Result { get => result; set { result = value; } }

        //Constructor
        public Dice(string color)
        {
            Id = ++IdCounter;
            DiceColor = color;
        }

        //Methods
        //Using diceSizes first and last index + 1 in GetRandom... method to set a random value in the returning result.
        public int ThrowDice()
        {
            return GetRandomNumber(DiceSize[0], DiceSize[5] + 1);
        }
        //Using random to return a random value between min and max.
        private static int GetRandomNumber(int min, int max)
        {
            lock (Rnd) //Synchronize
            {
                return Rnd.Next(min, max);
            }
        }

        public override string ToString()
        {
            return $"Player: {Id}.\n{DiceColor} dice, rolled: {Result}";
        }

    }
}
