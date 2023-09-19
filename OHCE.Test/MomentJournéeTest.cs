using OHCE.Domaine;

namespace OHCE.Test;

public class MomentJournéeTest
{
    [Theory]
    [InlineData(21)]
    [InlineData(22)]
    [InlineData(23)]
    [InlineData(0)]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(3)]
    [InlineData(4)]
    [InlineData(5)]
    public void De21hA6HeuresCEstLaNuit(int heure)
    {
        // ETANT DONNE une heure avant 6h
        // QUAND on demande le moment de la journée correspondant
        var moment = MomentDeLaJournée.FromHeure(heure);

        // ALORS on obtient la nuit
        Assert.Equal(MomentDeLaJournée.Nuit, moment);
    }

    [Theory]
    [InlineData(6)]
    [InlineData(7)]
    [InlineData(8)]
    [InlineData(9)]
    [InlineData(10)]
    [InlineData(11)]
    public void AvantMidiCEstLeMatin(int heure)
    {
        // ETANT DONNE une heure avant 12h
        // QUAND on demande le moment de la journée correspondant
        var moment = MomentDeLaJournée.FromHeure(heure);

        // ALORS on obtient le matin
        Assert.Equal(MomentDeLaJournée.Matin, moment);
    }

    [Theory]
    [InlineData(12)]
    [InlineData(13)]
    [InlineData(14)]
    [InlineData(15)]
    [InlineData(16)]
    [InlineData(17)]
    public void Avant18hCEstLAprèsMidi(int heure)
    {
        // ETANT DONNE une heure avant 18h
        // QUAND on demande le moment de la journée correspondant
        var moment = MomentDeLaJournée.FromHeure(heure);

        // ALORS on obtient l'après-midi
        Assert.Equal(MomentDeLaJournée.AprèsMidi, moment);
    }

    [Theory]
    [InlineData(18)]
    [InlineData(19)]
    [InlineData(20)]
    public void Avant21hCEstLeSoir(int heure)
    {
        // ETANT DONNE une heure avant 21h
        // QUAND on demande le moment de la journée correspondant
        var moment = MomentDeLaJournée.FromHeure(heure);

        // ALORS on obtient le soir
        Assert.Equal(MomentDeLaJournée.Soir, moment);
    }
}