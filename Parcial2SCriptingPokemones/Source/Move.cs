using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2SCriptingPokemones.Source
{
    internal class Move
    {
        public string Name { get; set; }
        public int BasePower { get; set; } = 100;
        public int Speed { get; set; } = 1;
        public PokemonType Type { get; set; }
        public MoveType MoveType { get; set; }

        public Move(string name, int basePower, PokemonType type, MoveType moveType)
        {
            Name = name;
            BasePower = basePower;
            Type = type;
            MoveType = moveType;
        }
    }
}
