namespace OHCE.Domaine;

public class MomentDeLaJournée
{
    private readonly string _displayName;

    public static MomentDeLaJournée Inconnu { get; } = new (nameof(Inconnu));
    public static MomentDeLaJournée Matin { get; } = new (nameof(Matin));
    public static MomentDeLaJournée AprèsMidi { get; } = new (nameof(AprèsMidi));
    public static MomentDeLaJournée Soir { get; } = new (nameof(Soir));
    public static MomentDeLaJournée Nuit { get; } = new (nameof(Nuit));

    private MomentDeLaJournée(string displayName)
    {
        _displayName = displayName;
    }

    /// <inheritdoc />
    public override string ToString() => _displayName;

    public static MomentDeLaJournée FromHeure(int heure)
        => heure switch
           {
               < 6  => Nuit,
               < 12 => Matin,
               < 18 => AprèsMidi,
               < 21 => Soir,
               _    => Nuit
           };
}