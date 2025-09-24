using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2SCriptingPokemones.Source
{
    internal static class TypeCalculator
    {
        private static readonly Dictionary<PokemonType, Dictionary<PokemonType, double>> TypeChart =
        new Dictionary<PokemonType, Dictionary<PokemonType, double>>
        {
                // Llena este diccionario con todos los valores de la tabla
                { PokemonType.Water, new Dictionary<PokemonType, double>
                    {
                        { PokemonType.Fire, 2.0 },
                        { PokemonType.Ground, 2.0 },
                        { PokemonType.Water, 0.5 },
                        // ... el resto de las combinaciones
                    }
                },
            // ... el resto de los tipos atacantes
        };
        public static double CalculateMod(PokemonType attackingType, List<PokemonType> defendingTypes)
        {
            double mod = 1.0;
            foreach (var defendingType in defendingTypes)
            {
                if (TypeChart.ContainsKey(attackingType) && TypeChart[attackingType].ContainsKey(defendingType))
                {
                    mod *= TypeChart[attackingType][defendingType];
                }
            }
            return mod;
        }
    }
}
