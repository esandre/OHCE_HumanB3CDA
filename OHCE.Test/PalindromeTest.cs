using OHCE.Domaine;
using Xunit.Abstractions;

namespace OHCE.Test
{
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
            var obtenu = Palindrome.Interpréter(chaîne);

            // ALORS on obtient son miroir
            var miroir = new string(chaîne.Reverse().ToArray());

            Assert.Contains(Environment.NewLine + miroir, obtenu);
            _testOutputHelper.WriteLine(obtenu);
        }

        [Fact]
        public void BonjourTest()
        {
            // ETANT DONNE une chaîne
            const string chaîne = "";

            // QUAND on l'envoie à Palindrome
            var obtenu = Palindrome.Interpréter(chaîne);

            // ALORS "Bonjour" s'affiche en premier
            Assert.StartsWith(Expressions.Bonjour, obtenu);
        }

        [Fact]
        public void AuRevoirTest()
        {
            // ETANT DONNE une chaîne
            const string chaîne = "test";

            // QUAND on l'envoie à Palindrome
            var obtenu = Palindrome.Interpréter(chaîne);

            // ALORS "Au revoir" s'affiche en dernier après un saut de ligne
            Assert.EndsWith(Environment.NewLine + Expressions.AuRevoir, obtenu);
        }
    }
}