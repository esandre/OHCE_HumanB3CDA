using System.Text;

namespace OHCE.Domaine;

public static class Palindrome
{
    public static string Interpréter(string chaîne)
    {
        var miroir = new string(chaîne.Reverse().ToArray());
        var estUnPalindrome = miroir.Equals(chaîne, StringComparison.OrdinalIgnoreCase);

        var builder = new StringBuilder();

        builder.AppendLine(Expressions.Bonjour);
        builder.AppendLine(miroir);
        if(estUnPalindrome) 
            builder.AppendLine(Expressions.BienDit);
        builder.Append(Expressions.AuRevoir);

        return builder.ToString();
    }
}