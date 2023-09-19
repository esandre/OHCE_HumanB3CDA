using OHCE.Domaine;
using OHCE.Domaine.Langue;

namespace OHCE.Test.Utilities;

internal class PalindromeBuilder
{
    public static Palindrome Default => new PalindromeBuilder().Build();

    private ILangue _langue = new LangueStub();
    private MomentDeLaJournée _moment = MomentDeLaJournée.Inconnu;

    public Palindrome Build()
    {
        return new Palindrome(_langue, _moment);
    }

    public PalindromeBuilder AyantPourLangue(ILangue langue)
    {
        _langue = langue;
        return this;
    }

    public PalindromeBuilder AyantPourMomentDeLaJournée(MomentDeLaJournée moment)
    {
        _moment = moment;
        return this;
    }
}