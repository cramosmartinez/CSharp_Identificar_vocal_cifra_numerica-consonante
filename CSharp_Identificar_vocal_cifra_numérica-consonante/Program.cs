using System;

class CharacterIdentifier
{
    static void Main()
    {
        Console.Write("Ingrese una letra o número: ");
        char input = Console.ReadLine()[0];

        if (IsNumber(input))
        {
            Console.WriteLine("Es un número.");
        }
        else if (IsVowel(input))
        {
            Console.WriteLine("Es una vocal.");
        }
        else if (IsConsonant(input))
        {
            Console.WriteLine("Es una consonante.");
        }
        else
        {
            Console.WriteLine("Carácter no identificado.");
        }
    }

    static bool IsNumber(char c) => char.IsDigit(c);
    static bool IsVowel(char c) => "aeiouAEIOU".IndexOf(c) >= 0;
    static bool IsConsonant(char c) => char.IsLetter(c) && !IsVowel(c);
}
