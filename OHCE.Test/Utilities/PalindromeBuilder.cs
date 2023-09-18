using OHCE.Domaine;
using OHCE.Domaine.Langue;

namespace OHCE.Test.Utilities;

internal class PalindromeBuilder
{
    public static Palindrome Default => new PalindromeBuilder().Build();

    public Palindrome Build()
    {
        return new Palindrome(new LangueFrançaise());
    }
}