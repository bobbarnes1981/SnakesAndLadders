namespace SnakesAndLadders.Library
{
    public class Dice6 : IDice
    {
        private IRandom m_random;

        public Dice6(IRandom random)
        {
            m_random = random;
        }

        public int Roll()
        {
            return m_random.Next(1, 7);
        }
    }
}
