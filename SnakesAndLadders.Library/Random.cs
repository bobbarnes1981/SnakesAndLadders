namespace SnakesAndLadders.Library
{
    public class Random : IRandom
    {
        private System.Random m_random;

        public Random()
        {
            m_random = new System.Random();
        }

        public int Next(int minValue, int maxValue)
        {
            return m_random.Next(minValue, maxValue);
        }
    }
}
