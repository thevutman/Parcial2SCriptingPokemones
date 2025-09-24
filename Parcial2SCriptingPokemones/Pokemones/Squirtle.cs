using Parcial2SCriptingPokemones.Source;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2SCriptingPokemones.Pokemones
{
    internal class Squirtle : Pokemon
    {
        public Squirtle() : base("Squirtle")
        {
            Types = new List<PokemonType> { PokemonType.Water };
        }
    }
}
