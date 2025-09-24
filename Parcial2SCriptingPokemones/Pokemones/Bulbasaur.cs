using Parcial2SCriptingPokemones.Source;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2SCriptingPokemones.Pokemones
{
    internal class Bulbasaur : Pokemon
    {
        public Bulbasaur() : base("Bulbasaur")
        {
            Types = new List<PokemonType> { PokemonType.Grass, PokemonType.Poison };
        }
    }
}
