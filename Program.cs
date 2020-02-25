using System;
using System.Collections.Generic;

namespace MorseConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var argument in args)
            {
                foreach (var letter in argument)
                {
                    Console.Write(ConvertLetterToMorseCode(letter));
                }
            }
        }

        static string ConvertLetterToMorseCode(char letter)
        {
            return MorseTable[char.ToLower(letter)] + " ";
        }

        static IDictionary<char, string> MorseTable = new Dictionary<char, string>
        {
            { 'a', ".-" }, { 'b', "-..." }, { 'c', "-.-." }, { 'd', "-.." },
            { 'e', "." }, { 'f', "..-." }, { 'g', "--." }, { 'h', "...." },
            { 'i', ".." }, { 'j', ".---" }, { 'k', "-.-" }, { 'l', ".-.." },
            { 'm', "--" }, { 'n', "-." }, { 'o', "---" }, { 'p', ".--." },
            { 'q', "--.-" }, { 'r', ".-." }, { 's', "..." }, { 't', "-" },
            { 'u', "..-" }, { 'v', "...-" }, { 'w', ".--" }, { 'x', ".--" },
            { 'y', "-.--" }, { 'z', "--.." },
        };
    }
}
