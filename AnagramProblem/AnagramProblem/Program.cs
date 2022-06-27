// See https://aka.ms/new-console-template for more information
using AnagramProblem;
Console.WriteLine("Welcome to Anagram project!");
Anagram anagram = new Anagram();
Console.WriteLine("Find anagram word.");
Console.Write("Please enter first word: ");
string first = Console.ReadLine();
Console.Write("Please enter second word: ");
string second = Console.ReadLine();
if (anagram.IsAnagram(first, second))
{
    Console.WriteLine("Given word is Anagram");

}
else
{
    Console.WriteLine("Given word is not Anagram");
}

