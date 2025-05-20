using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BattleRobot bot = new BattleRobot();
            bot.TurnOn();
            bot.MoveTo("quot" );
            bot.TakeDamage(10);
        }
    }
}
