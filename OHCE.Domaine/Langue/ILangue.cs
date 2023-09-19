namespace OHCE.Domaine.Langue;

public interface ILangue
{
    string Saluer(MomentDeLaJournée momentDeLaJournée);
    string Acquitter(MomentDeLaJournée momentDeLaJournée);
    string Féliciter();
}