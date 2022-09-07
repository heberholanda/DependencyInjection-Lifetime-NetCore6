using Lifetime.Interfaces;

namespace Lifetime.Services
{
    public class ScopedService : IScopedService
    {
        private int _randomNumber;
        public ScopedService()
        {
            Random rnd = new Random();
            _randomNumber = rnd.Next(1, 1000);
        }

        public int GetRandomNumber()
        {
            return _randomNumber;
        }
    }
}
