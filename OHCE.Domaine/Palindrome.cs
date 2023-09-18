using System.Text;

namespace OHCE.Domaine;

public static class Palindrome
{
    public static string Interpréter(string chaîne)
    {
        var builder = new StringBuilder();

        builder.AppendLine(Expressions.Bonjour);
        builder.AppendLine(new string(chaîne.Reverse().ToArray()));
        builder.Append(Expressions.AuRevoir);

        return builder.ToString();
    }
}