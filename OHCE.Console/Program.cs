using OHCE.Console;
using OHCE.Domaine;

var palindrome = new Palindrome(
    new LangueSystèmeAdapter(), 
    MomentActuelFactory.Factory());

Console.WriteLine(palindrome.Interpréter(Console.ReadLine() ?? string.Empty));