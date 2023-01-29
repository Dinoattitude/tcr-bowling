using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingGame.Test
{
    [TestClass]
    public class UnitTest1
    {
        
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
        public void Test3Quilles()
        {
            // ETANT DONNE une partie
            var partie = new Partie();

            // QUAND on fait tomber 2 quilles
            partie.Lancer(3);

            // ALORS le score est de 0
            Assert.AreEqual(0, partie.Score);
        }




        [TestMethod]
        public void Test4Quilles()
        {
            // ETANT DONNE une partie
            var partie = new Partie();

            // QUAND on fait tomber 2 quilles
            partie.Lancer(4);

            // ALORS le score est de 0
            Assert.AreEqual(0, partie.Score);
        }

        [TestMethod]
        public void Test5Quilles()
        {
            // ETANT DONNE une partie
            var partie = new Partie();

            // QUAND on fait tomber 2 quilles
            partie.Lancer(5);

            // ALORS le score est de 0
            Assert.AreEqual(0, partie.Score);
        }

        [TestMethod]
        public void Test6Quilles()
        {
            // ETANT DONNE une partie
            var partie = new Partie();

            // QUAND on fait tomber 2 quilles
            partie.Lancer(6);

            // ALORS le score est de 0
            Assert.AreEqual(0, partie.Score);
        }

        [TestMethod]
        public void Test7Quilles()
        {
            // ETANT DONNE une partie
            var partie = new Partie();

            // QUAND on fait tomber 2 quilles
            partie.Lancer(7);

            // ALORS le score est de 0
            Assert.AreEqual(0, partie.Score);
        }
        
        [TestMethod]
        public void Test8Quilles()
        {
            // ETANT DONNE une partie
            var partie = new Partie();

            // QUAND on fait tomber 2 quilles
            partie.Lancer(8);

            // ALORS le score est de 0
            Assert.AreEqual(0, partie.Score);
        }
        
        [TestMethod]
        public void Test9Quilles()
        {
            // ETANT DONNE une partie
            var partie = new Partie();

            // QUAND on fait tomber 2 quilles
            partie.Lancer(9);

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
        public void TestLancerRat�()
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
        public void Test9Carreau()
        {
            // ETANT DONNE une partie
            var partie = new Partie();

            // QUAND on fait tomber 9 carreau avec 2 Quilles � chaque fois
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

            // QUAND on fait tomber 9 carreau avec 2 Quilles � chaque fois
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

            // QUAND on fait tomber 9 carreau avec 2 Quilles � chaque fois
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

            // QUAND on fait tomber 9 carreau avec 2 Quilles � chaque fois
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

            // QUAND on fait tomber 9 carreau avec 2 Quilles � chaque fois
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
        
        [TestMethod]
        public void Test2Lancers0QuillesTombees()
        {
            // ETANT DONNE une partie
            var partie = new Partie();

            // QUAND on fait tomber 1 quilles deux fois
            partie.Lancer(0);
            partie.Lancer(0);

            // ALORS le score est de 6
            Assert.AreEqual(0, partie.Score);
        }
        
        
        [TestMethod]
        public void Test2Lancers1QuillesTombees()
        {
            // ETANT DONNE une partie
            var partie = new Partie();

            // QUAND on fait tomber 1 quilles deux fois
            partie.Lancer(0);
            partie.Lancer(1);

            // ALORS le score est de 1
            Assert.AreEqual(1, partie.Score);
        }
        
        [TestMethod]
        public void Test2Lancers2QuillesTombees()
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
        public void Test2Lancers3QuillesTombees()
        {
            // ETANT DONNE une partie
            var partie = new Partie();

            // QUAND on fait tomber 1 quilles deux fois
            partie.Lancer(1);
            partie.Lancer(2);

            // ALORS le score est de 3
            Assert.AreEqual(3, partie.Score);
        }
        
        [TestMethod]
        public void Test2Lancers4QuillesTombees()
        {
            // ETANT DONNE une partie
            var partie = new Partie();

            // QUAND on fait tomber 1 quilles deux fois
            partie.Lancer(1);
            partie.Lancer(3);

            // ALORS le score est de 4
            Assert.AreEqual(4, partie.Score);
        }
        
        [TestMethod]
        public void Test2Lancers5QuillesTombees()
        {
            // ETANT DONNE une partie
            var partie = new Partie();

            // QUAND on fait tomber 1 quilles deux fois
            partie.Lancer(1);
            partie.Lancer(4);

            // ALORS le score est de 5
            Assert.AreEqual(5, partie.Score);
        }
        
        [TestMethod]
        public void Test2Lancers6QuillesTombees()
        {
            // ETANT DONNE une partie
            var partie = new Partie();

            // QUAND on fait tomber 1 quilles deux fois
            partie.Lancer(1);
            partie.Lancer(5);

            // ALORS le score est de 6
            Assert.AreEqual(6, partie.Score);
        }
        
        [TestMethod]
        public void Test2Lancers7QuillesTombees()
        {
            // ETANT DONNE une partie
            var partie = new Partie();

            // QUAND on fait tomber 1 quilles deux fois
            partie.Lancer(1);
            partie.Lancer(6);

            // ALORS le score est de 7
            Assert.AreEqual(7, partie.Score);
        }
        
        [TestMethod]
        public void Test2Lancers8QuillesTombees()
        {
            // ETANT DONNE une partie
            var partie = new Partie();

            // QUAND on fait tomber 1 quilles deux fois
            partie.Lancer(1);
            partie.Lancer(7);

            // ALORS le score est de 8
            Assert.AreEqual(8, partie.Score);
        }

        [TestMethod]
        public void Test2Lancers9QuillesTombees()
        {
            // ETANT DONNE une partie
            var partie = new Partie();

            // QUAND on fait tomber 1 quilles deux fois
            partie.Lancer(1);
            partie.Lancer(8);

            // ALORS le score est de 9
            Assert.AreEqual(9, partie.Score);
        }
        
        [TestMethod]
        public void TestSpare()
        {
            // ETANT DONNE une partie
            var partie = new Partie();

            // QUAND on fait tomber 10 quilles en 2 fois
            partie.Lancer(9);
            partie.Lancer(1);
    
            partie.Lancer(1);
            // ALORS le score est de 10
            Assert.AreEqual(11, partie.Score);
        }
    }
}