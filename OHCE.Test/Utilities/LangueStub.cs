using OHCE.Domaine;
using OHCE.Domaine.Langue;

namespace OHCE.Test.Utilities;

internal class LangueStub : ILangue
{
    /// <param name="_"></param>
    /// <inheritdoc />
    public string Saluer(MomentDeLaJournée _) => string.Empty;

    /// <param name="_"></param>
    /// <inheritdoc />
    public string Acquitter(MomentDeLaJournée _) => string.Empty;

    /// <inheritdoc />
    public virtual string Féliciter() => string.Empty;
}