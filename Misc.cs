using System;

namespace WarriorWarsRecreation
{
    static class Misc
    {
        public static void ColouredWriteLine(string text, ConsoleColor colour)
        {
            Console.ForegroundColor = colour;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}
