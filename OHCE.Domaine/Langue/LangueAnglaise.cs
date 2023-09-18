namespace OHCE.Domaine.Langue;

public class LangueAnglaise : ILangue
{
    /// <inheritdoc />
    public string Saluer() => Expressions.Hello;
}