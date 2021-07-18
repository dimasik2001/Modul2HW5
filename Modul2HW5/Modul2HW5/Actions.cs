using System;

namespace Modul2HW5
{
    public class Actions
    {
        private readonly Logger _logger;

        public Actions(Logger logger)
        {
            _logger = logger;
        }

        public bool FirstMethod()
        {
            _logger.WriteInfo($"Start {nameof(FirstMethod)}:");
            return true;
        }

        public void SecondMethod()
        {
            throw new BusinessException($"Skipped logic in {nameof(SecondMethod)}:");
        }

        public void ThirdMethod()
        {
            throw new Exception($"I broke a logic in {nameof(ThirdMethod)}");
        }
    }
}
