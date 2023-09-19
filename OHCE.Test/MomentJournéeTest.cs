using OHCE.Domaine;

namespace OHCE.Test;

public class MomentJournéeTest
{
    [Fact]
    public void AvantSixHeuresCEstLaNuit()
    {
        // ETANT DONNE une heure avant 6h
        const int heure = 4;

        // QUAND on demande le moment de la journée correspondant
        var moment = MomentDeLaJournée.FromHeure(heure);

        // ALORS on obtient la nuit
        Assert.Equal(MomentDeLaJournée.Nuit, moment);
    }
}