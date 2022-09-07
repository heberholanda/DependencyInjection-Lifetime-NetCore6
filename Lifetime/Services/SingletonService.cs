using Lifetime.Interfaces;

namespace Lifetime.Services
{
    public class SingletonService : ISingletonService
    {
        private int _randomNumber;
        public SingletonService()
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
