using OHCE.Domaine;

namespace OHCE.Console;

internal static class MomentActuelFactory
{
    public static MomentDeLaJournée Factory()
    {
        var currentDateTime = DateTime.Now;
        var hour = currentDateTime.Hour;

        return hour switch
               {
                   < 6  => MomentDeLaJournée.Nuit,
                   < 12 => MomentDeLaJournée.Matin,
                   < 18 => MomentDeLaJournée.AprèsMidi,
                   < 21 => MomentDeLaJournée.Soir,
                   _    => MomentDeLaJournée.Nuit
               };
    }
}