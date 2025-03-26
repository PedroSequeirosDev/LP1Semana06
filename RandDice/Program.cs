using System;
using System.Collections;

namespace RandDice
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string Dice = args[0];
            int rolls = int.Parse(Dice);

            string seed = args[1];
            int seedConverted = int.Parse(seed);

     