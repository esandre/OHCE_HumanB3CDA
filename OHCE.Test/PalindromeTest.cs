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

    [Fact]
    public void BonjourTest()
    {
        // ETANT DONNE une chaîne ET un utilisateur parlant français
        const string chaîne = "";
        var langueFrançaise = new LangueFrançaise();

        var palindrome = new PalindromeBuilder()
            .AyantPourLangue(langueFrançaise)
            .Build();

        // QUAND on l'envoie à Palindrome
        var obtenu = palindrome.Interpréter(chaîne);

        // ALORS "Bonjour" s'affiche en premier
        Assert.StartsWith(Expressions.Bonjour, obtenu);
    }

    [Fact]
    public void HelloTest()
    {
        // ETANT DONNE une chaîne ET un utilisateur parlant anglais
        const string chaîne = "";
        var langue = new LangueAnglaise();

        var palindrome = new PalindromeBuilder()
            .AyantPourLangue(langue)
            .Build();

        // QUAND on l'envoie à Palindrome
        var obtenu = palindrome.Interpréter(chaîne);

        // ALORS "Hello" s'affiche en premier
        Assert.StartsWith(Expressions.Hello, obtenu);
    }

    [Fact]
    public void AuRevoirTest()
    {
        // ETANT DONNE une chaîne
        const string chaîne = "test";

        // QUAND on l'envoie à Palindrome
        var obtenu = PalindromeBuilder.Default.Interpréter(chaîne);

        // ALORS "Au revoir" s'affiche en dernier après un saut de ligne
        Assert.EndsWith(Environment.NewLine + Expressions.AuRevoir, obtenu);
    }

    [Theory]
    [InlineData("radar")]
    [InlineData("Radar")]
    public void BienDitTest(string palindrome)
    {
        // ETANT DONNE un palindrome
        // QUAND on l'envoie à Palindrome
        var obtenu = PalindromeBuilder.Default.Interpréter(palindrome);
        var miroir = new string(palindrome.Reverse().ToArray());

        // ALORS "Bien dit" s'affiche immédiatement après la réponse et un saut de ligne
        Assert.Contains(miroir + Environment.NewLine + Expressions.BienDit, obtenu);
    }

    [Fact]
    public void BienDitAbsentTest()
    {
        // ETANT DONNE une chaîne n'étant pas un palindrome
        const string nonPalindrome = "paslindrome";

        // QUAND on l'envoie à Palindrome
        var obtenu = PalindromeBuilder.Default.Interpréter(nonPalindrome);

        // ALORS "Bien dit" ne s'affiche nulle part
        Assert.DoesNotContain(Expressions.BienDit, obtenu);
    }
}