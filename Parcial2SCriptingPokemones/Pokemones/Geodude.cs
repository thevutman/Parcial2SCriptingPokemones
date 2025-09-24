using Parcial2SCriptingPokemones.Source;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2SCriptingPokemones.Pokemones
{
    internal class Geodude : Pokemon
    {
        public Geodude() : base("Geodude")
        {
            Types = new List<PokemonType> { PokemonType.Rock, PokemonType.Ground };
        }
    }
}
