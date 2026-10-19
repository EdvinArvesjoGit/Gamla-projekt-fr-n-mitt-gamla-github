// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography;

string your_guess = "";
string word = "mata";
Console.WriteLine("welcome to Hangman!");
Console.WriteLine("youre word has...");

List<string> underscores = new();
for (int i = 0; i < word.Length; i++)
{
    underscores.Add("_ ");
}
while(underscores.Contains("_ "))
// {
//     true;
// })
{
    // hämta gissning
    Console.WriteLine(string.Join("", underscores));
    while(your_guess.Length != 1)
    {
        your_guess = Console.ReadLine();
    }
    Console.WriteLine($"you guessed {your_guess}!");
    your_guess = Console.ReadLine();
    if (your_guess.Length <=0)
    {
        your_guess = your_guess.First().ToString();
    }
    if(word.Contains(your_guess))
    {
    for(int i = 0; i < word.Length; i++)
        {
            Console.WriteLine(word[i]); 
            if(word[i].ToString() == your_guess)
            {
                underscores[i] = your_guess;
            }
        }
    }
}

Console.ReadLine();