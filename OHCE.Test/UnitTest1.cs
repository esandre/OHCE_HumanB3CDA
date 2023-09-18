using OHCE.Domaine;

namespace OHCE.Test
{
    public class UnitTest1
    {
        [Fact]
        public void MiroirTest()
        {
            // ETANT DONNE une chaîne
            const string chaîne = "test";

            // QUAND on l'envoie à Palindrome
            var obtenu = Palindrome.Interpréter(chaîne);

            // ALORS on obtient son miroir
            var miroir = new string(chaîne.Reverse().ToArray());
            Assert.Equal(miroir, obtenu);
        }
    }
}