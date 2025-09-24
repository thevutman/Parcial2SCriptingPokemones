using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2SCriptingPokemones.Source
{
    internal static class DamageCalculator
    {
        public static int Calculate(Pokemon attacker, Pokemon defender, Move move, double mod)
        {
            double finalDamage;
            double levelComponent = (2.0 * (attacker.Level / 5.0)) + 2.0;

            if (move.MoveType == MoveType.Physical)
            {
                double attackDefenseComponent = (double)move.BasePower * ((double)attacker.Attack / defender.Defense);
                finalDamage = ((levelComponent * attackDefenseComponent) / 50.0) + 2.0;
            }
            else // Special
            {
                double specialComponent = (double)move.BasePower * ((double)attacker.SpecialAttack / defender.SpecialDefense);
                finalDamage = ((levelComponent * specialComponent) / 50.0) + 2.0;
            }

            finalDamage *= mod;

            // Redondear el resultado
            return (int)Math.Floor(finalDamage);
        }
    }
}
