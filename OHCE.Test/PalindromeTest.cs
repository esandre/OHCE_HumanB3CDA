using OHCE.Domaine;

namespace OHCE.Test
{
    public class PalindromeTest
    {
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
        }
    }
}