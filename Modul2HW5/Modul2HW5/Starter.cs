using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2HW5
{
    public class Starter
    {
        private readonly Actions _actions;
        private readonly Logger _logger;
        private readonly Random _rnd;
        public Starter(Actions actions, Logger logger)
        {
            _actions = actions;
            _logger = logger;
            _rnd = new Random();
        }

        public void Run()
        {
            for (var i = 0; i < 100; i++)
            {
                try
                {
                    CallRandomMethod();
                }
                catch (BusinessException ex)
                {
                    _logger.WriteWarning($"Action got this custom Exception : {ex.Message}");
                }
                catch (Exception ex)
                {
                    _logger.WriteError($"Action failed by reason: {ex}");
                }
            }
        }

        private void CallRandomMethod()
        {
            var num = _rnd.Next(3);

            switch (num)
            {
                case 0:
                    _actions.FirstMethod();
                    break;
                case 1:
                    _actions.SecondMethod();
                    break;
                case 2:
                    _actions.ThirdMethod();
                    break;
            }
        }
    }
}
