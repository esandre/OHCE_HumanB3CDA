using System.Text;

namespace OHCE.Domaine;

public static class Palindrome
{
    public static string Interpréter(string chaîne)
    {
        var builder = new StringBuilder();

        builder.AppendLine(Expressions.Bonjour);
        builder.Append(new string(chaîne.Reverse().ToArray()));

        return builder.ToString();
    }
}