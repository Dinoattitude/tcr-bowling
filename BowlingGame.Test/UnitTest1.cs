using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingGame.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test2Quilles()
        {
            // ETANT DONNE une partie
            var partie = new Partie();

            // QUAND on fait tomber 2 quilles
            partie.Lancer(2);

            // ALORS le score est de 0
            Assert.AreEqual(0, partie.Score);
        }





        [TestMethod]
        public void Test2Lancers1Quille()
        {
            // ETANT DONNE une partie
            var partie = new Partie();

            // QUAND on fait tomber 1 quilles deux fois
            partie.Lancer(1);
            partie.Lancer(1);

            // ALORS le score est de 2
            Assert.AreEqual(2, partie.Score);
        }

        [TestMethod]
        public void Test1Quille()
        {
            // ETANT DONNE une partie
            var partie = new Partie();

            // QUAND on fait tomber une quille
            partie.Lancer(1);

            // ALORS le score est de 0 car 1 seul lancer
            Assert.AreEqual(0, partie.Score);
        }

        [TestMethod]
        public void TestLancerRaté()
        {
            // ETANT DONNE une partie
            var partie = new Partie();

            // QUAND on fait tomber 0 quilles
            partie.Lancer(0);

            // ALORS le score est de 0
            Assert.AreEqual(0, partie.Score);
        }

        [TestMethod]
        public void TestStrike()
        {
            // ETANT DONNE une partie
            var partie = new Partie();

            // QUAND on fait tomber 10 quilles
            partie.Lancer(10);

            // ALORS le score est de 10
            Assert.AreEqual(10, partie.Score);
        }

        [TestMethod]
        public void TestSpare()
        {
            // ETANT DONNE une partie
            var partie = new Partie();

            // QUAND on fait tomber 10 quilles en 2 fois
            partie.Lancer(9);
            partie.Lancer(1);

            // ALORS le score est de 10
            Assert.AreEqual(10, partie.Score);
        }

        [TestMethod]
        public void Test9Carreau()
        {
            // ETANT DONNE une partie
            var partie = new Partie();

            // QUAND on fait tomber 9 carreau avec 2 Quilles à chaque fois
            int i = 1;
            do
            {
                i++;
                partie.Lancer(1);
                partie.Lancer(1);
            } while (i < 10);

            // ALORS le score est de 0
            Assert.AreEqual(18, partie.ScoreFinal);
        }

        [TestMethod]
        public void Test10CarreauStrike()
        {
            // ETANT DONNE une partie
            var partie = new Partie();

            // QUAND on fait tomber 9 carreau avec 2 Quilles à chaque fois
            int i = 1;
            do
            {
                i++;
                partie.Lancer(1);
                partie.Lancer(1);
            } while (i < 10);

            partie.Lancer(10);
            partie.Lancer(3);
            partie.Lancer(2);

            // ALORS le score est de 33
            Assert.AreEqual(33, partie.ScoreFinal);
        }

        [TestMethod]
        public void Test10CarreauSpare()
        {
            // ETANT DONNE une partie
            var partie = new Partie();

            // QUAND on fait tomber 9 carreau avec 2 Quilles à chaque fois
            int i = 1;
            do
            {
                i++;
                partie.Lancer(1);
                partie.Lancer(1);
            } while (i < 10);

            partie.Lancer(5);
            partie.Lancer(5);
            partie.Lancer(5);
    
            // ALORS le score est de 33
            Assert.AreEqual(33, partie.ScoreFinal);
        }

        [TestMethod]
        public void Test10Carreau3Strikes()
        {
            // ETANT DONNE une partie
            var partie = new Partie();

            // QUAND on fait tomber 9 carreau avec 2 Quilles à chaque fois
            int i = 1;
            do
            {
                i++;
                partie.Lancer(1);
                partie.Lancer(1);
            } while (i < 10);

            partie.Lancer(10);
            partie.Lancer(10);
            partie.Lancer(10);

            // ALORS le score est de 48
            Assert.AreEqual(48, partie.ScoreFinal);
        }

        [TestMethod]
        public void Test10CarreauWithoutLastRound()
        {
            // ETANT DONNE une partie
            var partie = new Partie();

            // QUAND on fait tomber 9 carreau avec 2 Quilles à chaque fois
            int i = 1;
            do
            {
                i++;
                partie.Lancer(1);
                partie.Lancer(1);
            } while (i < 10);

            partie.Lancer(7);
            partie.Lancer(1);

            //Ce lancer n'est pas pris en compte car pas de strike ou de spare avant
            partie.Lancer(10);

            // ALORS le score est de 26
            Assert.AreEqual(26, partie.ScoreFinal);
        }
    }
}