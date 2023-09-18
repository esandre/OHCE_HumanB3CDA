using OHCE.Domaine;
using OHCE.Domaine.Langue;

namespace OHCE.Test.Utilities;

internal class PalindromeBuilder
{
    public static Palindrome Default => new PalindromeBuilder().Build();

    private ILangue _langue = new LangueStub();

    public Palindrome Build()
    {
        return new Palindrome(_langue);
    }

    public PalindromeBuilder AyantPourLangue(ILangue langue)
    {
        _langue = langue;
        return this;
    }
}