using System;

namespace SnakesAndLadders.Library
{
    public class ConsoleLogger : ILogger
    {
        private IDateTimeProvider m_dateTimeProvider;

        public ConsoleLogger(IDateTimeProvider dateTimeProvider)
        {
            m_dateTimeProvider = dateTimeProvider;
        }

        public void Log(string message)
        {
            Console.WriteLine("{0} : {1}", m_dateTimeProvider.Now, message);
        }
    }
}
