namespace OHCE.Domaine;

public class MomentDeLaJournée
{
    public static MomentDeLaJournée Inconnu { get; } = new ();
    public static MomentDeLaJournée Matin { get; } = new ();

    private MomentDeLaJournée(){}
}