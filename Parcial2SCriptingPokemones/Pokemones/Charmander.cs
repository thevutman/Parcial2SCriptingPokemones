using Parcial2SCriptingPokemones.Source;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2SCriptingPokemones.Pokemones
{
    internal class Charmander : Pokemon
    {
        public Charmander() : base("Charmander")
        {
            Types = new List<PokemonType> { PokemonType.Fire };
        }
    }
}
