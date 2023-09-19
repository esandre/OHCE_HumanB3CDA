using System.Text;
using OHCE.Domaine.Langue;

namespace OHCE.Domaine;

public class Palindrome
{
    private readonly ILangue _langue;

    public Palindrome(ILangue langue)
    {
        _langue = langue;
    }

    public string Interpréter(string chaîne)
    {
        var miroir = new string(chaîne.Reverse().ToArray());
        var estUnPalindrome = miroir.Equals(chaîne, StringComparison.OrdinalIgnoreCase);

        var builder = new StringBuilder();

        builder.AppendLine(_langue.Saluer());
        builder.AppendLine(miroir);
        if (estUnPalindrome)
            builder.AppendLine(_langue.Féliciter());
        builder.Append(_langue.Acquitter());

        return builder.ToString();
    }
}