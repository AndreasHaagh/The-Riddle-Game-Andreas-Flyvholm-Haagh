﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheRiddleGame
{
    class Settings : IMenu
    {
        private string[] settingsOptions = new string[] { "Difficulty", "Custom Difficulty", "Color", "Back" };

        public void Draw()
        {
            Console.Clear();
            for (int i = 0; i < settingsOptions.Length; i++)
            {
                Console.WriteLine("> " + settingsOptions[i]);
            }
        }

        public void TakeInput()
        {
            var input = Console.ReadLine();

            switch (input.ToLower())
            {
                case "difficulty":
                    ChangeDifficulty();
                    break;
                case "custom Difficulty":
                    CreateCustomDifficulty();
                    break;
                case "color":
                    Console.WriteLine("Pick one of these colors 'Green', 'Red' or 'Yellow'. Leave it empty to change it back to 'White'");
                    input = Console.ReadLine();
                    ChangeColor(input);
                    break;
                case "back":
                    Console.WriteLine("Going back");
                    break;
                default:
                    break;
            }
        }

        private void ChangeColor(string color)
        {
            switch (color.ToLower())
            {
                case "green":
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case "red":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case "yellow":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
        }

        private void ChangeDifficulty()
        {
            Console.WriteLine("Changing the difficulty (Work in progress)");
            Console.ReadKey();
        }

        private void CreateCustomDifficulty()
        {
            Console.WriteLine("Changing the difficulty to using custom (Work in progress)");
            Console.ReadKey();
        }
    }
}
