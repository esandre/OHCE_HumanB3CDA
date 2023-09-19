namespace OHCE.Domaine.Langue;

public class LangueAnglaise : ILangue
{
    /// <param name="momentDeLaJournée"></param>
    /// <inheritdoc />
    public string Saluer(MomentDeLaJournée momentDeLaJournée)
    {
        if (momentDeLaJournée == MomentDeLaJournée.AprèsMidi) 
            return Expressions.GoodAfternoon;
        if (momentDeLaJournée == MomentDeLaJournée.Matin)
            return Expressions.GoodMorning;
        if (momentDeLaJournée == MomentDeLaJournée.Soir)
            return Expressions.GoodEvening;

        return Expressions.Hello;
    }

    /// <param name="momentDeLaJournée"></param>
    /// <inheritdoc />
    public string Acquitter(MomentDeLaJournée momentDeLaJournée)
    {
        if (momentDeLaJournée == MomentDeLaJournée.Matin)
            return Expressions.HaveANiceDay;
        if (momentDeLaJournée == MomentDeLaJournée.AprèsMidi)
            return Expressions.HaveANiceDay;
        if (momentDeLaJournée == MomentDeLaJournée.Soir)
            return Expressions.HaveANiceEvening;
        if (momentDeLaJournée == MomentDeLaJournée.Nuit)
            return Expressions.GoodNight;
        return Expressions.Goodbye;
    }

    /// <inheritdoc />
    public string Féliciter() => Expressions.WellSaid;
}