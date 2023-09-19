namespace OHCE.Domaine.Langue;

public class LangueAnglaise : ILangue
{
    /// <inheritdoc />
    public string Saluer() => Expressions.Hello;

    /// <inheritdoc />
    public string Acquitter() => Expressions.Goodbye;

    /// <inheritdoc />
    public string Féliciter() => Expressions.WellSaid;
}