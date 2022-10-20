using System.Text;

namespace BowlingGame
{
    public class Partie
    {
        private readonly List<int> _historique = new();

        public void Lancer(int nombreQuillesTombées)
        {
            _historique.Add(nombreQuillesTombées);

            if (EstUnStrike() && !EstLaDerniereFrame() && !EstLeCoupFinal()) _historique.Add(0);
            if ((EstUnStrike() || EstUnSpare()) && (EstLaDerniereFrame() || !EstLeCoupFinal())) TroisiemeCoup = true;
            
            if(EstLeCoupFinal() && TroisiemeCoup.Equals(true))
            {
                Score = _historique.Last();
                Console.WriteLine(Score);
                ScoreFinal += Score;
            }

            if (TermineUneFrame() && !EstLeCoupFinal())
            {
                Score = DeuxDerniersLancers.Sum();
                ScoreFinal += Score;
                nbFrame++;
            }
        }

        private IEnumerable<int> DeuxDerniersLancers => _historique.AsEnumerable().Reverse().Take(2);
        private bool TermineUneFrame() => _historique.Count % 2 == 0;
        private bool TermineUnePartie() => nbFrame == 10;
        private bool EstUnSpare() => DeuxDerniersLancers.Sum() == 10;
        private bool EstUnStrike() => _historique.Last() == 10;
        private bool EstLaDerniereFrame() => nbFrame == 9 ? true : false;
        private bool EstLeCoupFinal() => nbFrame == 10 ? true : false;

        public int Score { get; private set; }
        public int ScoreFinal { get; private set; }
        public int nbFrame { get; private set; } = 0;
        public bool TroisiemeCoup { get; private set; } = false;
    }
}
