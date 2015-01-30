namespace CelticEgyptianRatscrewKata
{
    public class Shuffler
    {
        private readonly IRandomNumberGenerator m_RandomNumberGenerator;

        public Shuffler() : this(new RandomNumberGenerator())
        {
        }

        public Shuffler(IRandomNumberGenerator randomNumberGenerator)
        {
            m_RandomNumberGenerator = randomNumberGenerator;
        }

        public Cards Shuffle(Cards deck)
        {
            return Cards.With(deck);
        }
    }
}