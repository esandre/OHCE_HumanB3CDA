using System.Globalization;
using OHCE.Domaine;
using OHCE.Domaine.Langue;

namespace OHCE.Console;

internal class LangueSystèmeAdapter : ILangue
{
    private readonly ILangue _langueRéelle;

    public LangueSystèmeAdapter()
    {
        var userCulture = CultureInfo.CurrentCulture;
        var locale = userCulture.TwoLetterISOLanguageName;

        if (locale == "fr") _langueRéelle = new LangueFrançaise();
        else _langueRéelle = new LangueAnglaise();
    }

    /// <inheritdoc />
    public string Saluer(MomentDeLaJournée momentDeLaJournée)
    {
        return _langueRéelle.Saluer(momentDeLaJournée);
    }

    /// <inheritdoc />
    public string Acquitter(MomentDeLaJournée momentDeLaJournée)
    {
        return _langueRéelle.Acquitter(momentDeLaJournée);
    }

    /// <inheritdoc />
    public string Féliciter()
    {
        return _langueRéelle.Féliciter();
    }
}