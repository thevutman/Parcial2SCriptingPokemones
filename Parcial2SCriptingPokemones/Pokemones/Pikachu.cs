using Parcial2SCriptingPokemones.Source;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2SCriptingPokemones.Pokemones
{
    internal class Pikachu : Pokemon
    {
        public Pikachu() : base("Pikachu")
        {
            Types = new List<PokemonType> { PokemonType.Electric };
        }
    }
}
