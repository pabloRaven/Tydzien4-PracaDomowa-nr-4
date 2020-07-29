using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tydzien4ZadanieDodatkoweNr4
{
    class Program
    {
        public static string NoPolishSigns(string value)
        {
            value = value.Replace("ó", "o")
            .Replace("ą", "a")
            .Replace("ę", "e")
            .Replace("ł", "l")
            .Replace("ż", "z")
            .Replace("ź", "z")
            .Replace("ć", "c")
            .Replace("ś", "s")
            .Replace("ń", "n");

            return value;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Podaj zdanie zawierające polskie znaki : ");
            string value = Console.ReadLine();
            Console.WriteLine($"Zdanie  bez polskich znaków  : {NoPolishSigns(value)}");

        }
    }
}
