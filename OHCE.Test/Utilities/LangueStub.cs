using OHCE.Domaine;
using OHCE.Domaine.Langue;

namespace OHCE.Test.Utilities;

internal class LangueStub : ILangue
{
    /// <param name="momentDeLaJournée"></param>
    /// <inheritdoc />
    public string Saluer(MomentDeLaJournée momentDeLaJournée) => string.Empty;

    /// <inheritdoc />
    public string Acquitter() => string.Empty;

    /// <inheritdoc />
    public virtual string Féliciter() => string.Empty;
}