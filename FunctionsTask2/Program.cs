using System;

namespace FunctionsTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int minPrecentValue = 0;
            int maxPrecentValue = 101;
            int maxValue = 10;
            int divider = 10;
            int positionX = 0;
            int positionY = 0;
            char fillSymbol = '#';

            DrawBar(positionX, positionY, maxValue, fillSymbol, random, minPrecentValue, maxPrecentValue, divider, text: $"Healthbar");

            positionY = 1;
            DrawBar(positionX, positionY, maxValue, fillSymbol, random, minPrecentValue, maxPrecentValue, divider, ConsoleColor.Blue, "Manabar");
        }

        static void DrawBar(int positionX, int positionY, int maxValue, char fillSymbol, Random random, int minPrecentValue, int maxPrecentValue, int divider, ConsoleColor color = ConsoleColor.Red, string text = "")
        {
            int precentValue = random.Next(minPrecentValue, maxPrecentValue) / divider;
            int precent = precentValue * divider;
            ConsoleColor currentColor = Console.BackgroundColor;

            Console.ForegroundColor = color;
            Console.SetCursorPosition(positionX, positionY);
            Console.Write('[');
            for (int i = 0; i < maxValue; i++)
            {
                if (i < precentValue)
                {
                    Console.Write(fillSymbol);
                }
                else
                {
                    Console.Write('_');
                }
            }
            Console.Write(']' + text + $" {precent}%");
            Console.ForegroundColor = currentColor;
        }
    }
}
