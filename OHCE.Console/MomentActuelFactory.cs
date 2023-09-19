using OHCE.Domaine;

namespace OHCE.Console;

internal static class MomentActuelFactory
{
    public static MomentDeLaJournée Factory()
    {
        var currentDateTime = DateTime.Now;
        var hour = currentDateTime.Hour;

        return MomentDeLaJournée.FromHeure(hour);
    }
}