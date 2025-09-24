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
        public int BasePower { get; set; }
        public int Speed { get; set; }
        public PokemonType Type { get; set; }
        public MoveType MoveType { get; set; }

        public Move(string name, PokemonType type, MoveType moveType)
        {
            Name = name;
            Type = type;
            MoveType = moveType;
            // Valores por defecto
            BasePower = 100;
            Speed = 1;
        }
    }
}
