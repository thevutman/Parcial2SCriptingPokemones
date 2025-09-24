using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2SCriptingPokemones.Source
{
    internal class Pokemon
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int SpecialAttack { get; set; }
        public int SpecialDefense { get; set; }
        public List<PokemonType> Types { get; set; }

        public Pokemon(string name, params PokemonType[] types)
        {
            Name = name;
            Types = types.ToList();
            // Valores por defecto
            Level = 1;
            Attack = 10;
            Defense = 10;
            SpecialAttack = 10;
            SpecialDefense = 10;
        }
    }
}
