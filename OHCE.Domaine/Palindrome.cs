namespace OHCE.Domaine;

public class Palindrome
{
    public static string Interpréter(string chaîne)
    {
        return new string(chaîne.Reverse().ToArray());
    }
}