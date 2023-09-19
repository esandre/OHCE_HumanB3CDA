using OHCE.Domaine;
using OHCE.Domaine.Langue;
using OHCE.Test.Utilities;
using Xunit.Abstractions;

namespace OHCE.Test;

public class PalindromeTest
{
    private readonly ITestOutputHelper _testOutputHelper;

    public PalindromeTest(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }

    [Theory]
    [InlineData("")]
    [InlineData("test")]
    [InlineData("toast")]
    [InlineData("Toast")]
    public void MiroirTest(string chaîne)
    {
        // ETANT DONNE une chaîne
        // QUAND on l'envoie à Palindrome
        var obtenu = PalindromeBuilder.Default.Interpréter(chaîne);

        // ALORS on obtient son miroir
        var miroir = new string(chaîne.Reverse().ToArray());

        Assert.Contains(Environment.NewLine + miroir, obtenu);
        _testOutputHelper.WriteLine(obtenu);
    }

    public static IEnumerable<object[]> LanguesEtSalutations = new[]
    {
        new object[] { new LangueAnglaise(), MomentDeLaJournée.Inconnu, Expressions.Hello },
        new object[] { new LangueAnglaise(), MomentDeLaJournée.Matin, Expressions.GoodMorning },
        new object[] { new LangueFrançaise(), MomentDeLaJournée.Inconnu, Expressions.Bonjour }
    };

    [Theory]
    [MemberData(nameof(LanguesEtSalutations))]
    public void SalutationTest(ILangue langue, MomentDeLaJournée moment, string salutationAttendue)
    {
        // ETANT DONNE une chaîne
        // ET un utilisateur parlant <langue>
        // ET que nous sommes le <moment de la journée>
        const string chaîne = "";

        var palindrome = new PalindromeBuilder()
            .AyantPourLangue(langue)
            .AyantPourMomentDeLaJournée(moment)
            .Build();

        // QUAND on l'envoie à Palindrome
        var obtenu = palindrome.Interpréter(chaîne);

        // ALORS les salutations attendues de cette langue à ce moment s'affichent en premier
        Assert.StartsWith(salutationAttendue, obtenu);
    }

    public static IEnumerable<object[]> LanguesEtAcquittances = new[]
    {
        new object[] { new LangueAnglaise(), Expressions.Goodbye },
        new object[] { new LangueFrançaise(), Expressions.AuRevoir }
    };

    [Theory]
    [MemberData(nameof(LanguesEtAcquittances))]
    public void AcquittanceTest(ILangue langue, string acquittanceAttendue)
    {
        // ETANT DONNE une chaîne ET un utilisateur parlant <langue>
        const string chaîne = "test";

        var palindrome = new PalindromeBuilder()
            .AyantPourLangue(langue)
            .Build();

        // QUAND on l'envoie à Palindrome
        var obtenu = palindrome.Interpréter(chaîne);

        // ALORS l'acquittance attendue de la langue s'affiche en dernier après un saut de ligne
        Assert.EndsWith(Environment.NewLine + acquittanceAttendue, obtenu);
    }

    public static IEnumerable<object[]> LanguesEtFélicitations = new[]
    {
        new object[] { new LangueAnglaise(), Expressions.WellSaid, "Radar" },
        new object[] { new LangueAnglaise(), Expressions.WellSaid, "radar" },
        new object[] { new LangueFrançaise(), Expressions.BienDit, "Radar" },
        new object[] { new LangueFrançaise(), Expressions.BienDit, "radar" }
    };

    [Theory]
    [MemberData(nameof(LanguesEtFélicitations))]
    public void BienDitTest(ILangue langue, string félicitationsAttendues, string palindromeTesté)
    {
        // ETANT DONNE un palindrome ET un utilisateur parlant <langue>
        var interpréteur = new PalindromeBuilder()
            .AyantPourLangue(langue)
            .Build();

        // QUAND on l'envoie à Palindrome
        var obtenu = interpréteur.Interpréter(palindromeTesté);
        var miroir = new string(palindromeTesté.Reverse().ToArray());

        // ALORS les félicitations attendues s'affichent immédiatement
        // après la réponse et un saut de ligne
        Assert.Contains(miroir + Environment.NewLine + félicitationsAttendues, obtenu);
    }

    [Fact]
    public void FélicitationsAbsentesTest()
    {
        // ETANT DONNE une chaîne n'étant pas un palindrome
        const string nonPalindrome = "paslindrome";

        // ET un utilisateur parlant n'importe quelle langue
        var langueSpy = new LangueFélicitationsSpy();

        // QUAND on l'envoie à Palindrome
        new PalindromeBuilder()
            .AyantPourLangue(langueSpy)
            .Build()
            .Interpréter(nonPalindrome);

        // ALORS les félicitations de cette langue ne sont jamais consultées
        Assert.False(langueSpy.FélicitationsConsultées);
    }
}