using System.Text;
using OHCE.Domaine.Langue;

namespace OHCE.Domaine;

public class Palindrome
{
    public Palindrome(LangueFrançaise langueFrançaise)
    {
    }

    public string Interpréter(string chaîne)
    {
        var miroir = new string(chaîne.Reverse().ToArray());
        var estUnPalindrome = miroir.Equals(chaîne, StringComparison.OrdinalIgnoreCase);

        var builder = new StringBuilder();

        builder.AppendLine(Expressions.Bonjour);
        builder.AppendLine(miroir);
        if (estUnPalindrome)
            builder.AppendLine(Expressions.BienDit);
        builder.Append(Expressions.AuRevoir);

        return builder.ToString();
    }
}