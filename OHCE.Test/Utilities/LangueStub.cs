using OHCE.Domaine.Langue;

namespace OHCE.Test.Utilities;

internal class LangueStub : ILangue
{
    /// <inheritdoc />
    public string Saluer() => string.Empty;
}