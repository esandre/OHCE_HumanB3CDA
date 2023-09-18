namespace OHCE.Domaine.Langue;

public class LangueFrançaise : ILangue
{
    /// <inheritdoc />
    public string Saluer() => Expressions.Bonjour;
}