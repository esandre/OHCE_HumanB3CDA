namespace OHCE.Domaine.Langue;

public class LangueFrançaise : ILangue
{
    /// <inheritdoc />
    public string Saluer() => Expressions.Bonjour;

    /// <inheritdoc />
    public string Acquitter() => Expressions.AuRevoir;

    /// <inheritdoc />
    public string Féliciter() => Expressions.BienDit;
}