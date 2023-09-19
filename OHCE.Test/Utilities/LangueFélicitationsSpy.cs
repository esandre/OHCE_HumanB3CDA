namespace OHCE.Test.Utilities;

internal class LangueFélicitationsSpy : LangueStub
{
    public bool FélicitationsConsultées { get; private set; }

    /// <inheritdoc />
    public override string Féliciter()
    {
        FélicitationsConsultées = true;
        return base.Féliciter();
    }
}