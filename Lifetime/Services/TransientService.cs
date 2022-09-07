using Lifetime.Interfaces;

namespace Lifetime.Services
{
    public class TransientService : ITransientService
    {
        private int _randomNumber;
        public TransientService()
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
