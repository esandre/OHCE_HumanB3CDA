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
            Assert.Equal(miroir, obtenu);
            _testOutputHelper.WriteLine(obtenu);
        }
    }
}