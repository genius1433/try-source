using System;
public static class Kata
{
    public static string AlphabetPosition(string text)
    {
        string alphabet = "abcdefghijklmnopqrstuvwxyz";
        string k = "";
        text = text.ToLower();
        for (int i = 0; i < text.Length; i++)
        {
            if (Char.IsLetter(text[i]))
            {
                int number = alphabet.IndexOf(text[i]) + 1;
                k += number + " ";
            }
        }
        text = k;
        return text;
    }
}
class Program
{
    static void Main(string[] args)
    {
        string text = "The sunset sets at twelve o' clock";
        Console.WriteLine(Kata.AlphabetPosition(text));
        Console.ReadLine();
    }
}