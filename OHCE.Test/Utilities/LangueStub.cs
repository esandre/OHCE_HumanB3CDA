using OHCE.Domaine.Langue;

namespace OHCE.Test.Utilities;

internal class LangueStub : ILangue
{
    /// <inheritdoc />
    public string Saluer() => string.Empty;

    /// <inheritdoc />
    public string Acquitter() => string.Empty;

    /// <inheritdoc />
    public virtual string Féliciter() => string.Empty;
}