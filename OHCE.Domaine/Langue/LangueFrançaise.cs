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

    /// <param name="momentDeLaJournée"></param>
    /// <inheritdoc />
    public string Acquitter(MomentDeLaJournée momentDeLaJournée)
    {
        if (momentDeLaJournée == MomentDeLaJournée.Matin)
            return Expressions.BonneJournée;
        if (momentDeLaJournée == MomentDeLaJournée.AprèsMidi)
            return Expressions.BonAprèsMidi;
        if (momentDeLaJournée == MomentDeLaJournée.Soir)
            return Expressions.BonneSoirée;
        if (momentDeLaJournée == MomentDeLaJournée.Nuit)
            return Expressions.BonneNuit;

        return Expressions.AuRevoir;
    }

    /// <inheritdoc />
    public string Féliciter() => Expressions.BienDit;
}