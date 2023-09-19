namespace OHCE.Domaine.Langue;

public class LangueFrançaise : ILangue
{
    /// <param name="momentDeLaJournée"></param>
    /// <inheritdoc />
    public string Saluer(MomentDeLaJournée momentDeLaJournée)
    {
        if (momentDeLaJournée == MomentDeLaJournée.Soir 
            || momentDeLaJournée == MomentDeLaJournée.Nuit)
            return Expressions.Bonsoir;
        return Expressions.Bonjour;
    }

    /// <inheritdoc />
    public string Acquitter() => Expressions.AuRevoir;

    /// <inheritdoc />
    public string Féliciter() => Expressions.BienDit;
}