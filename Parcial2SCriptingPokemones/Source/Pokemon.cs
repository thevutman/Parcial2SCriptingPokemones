using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2SCriptingPokemones.Source
{
    internal abstract class Pokemon
    {
        public string Name { get; protected set; }
        public int Level { get; set; } = 1;
        public int Attack { get; set; } = 10;
        public int Defense { get; set; } = 10;
        public int SpecialAttack { get; set; } = 10;
        public int SpecialDefense { get; set; } = 10;
        public List<PokemonType> Types { get; protected set; }
        public List<Move> Moves { get; protected set; } = new List<Move>();

        protected Pokemon(string name)
        {
            Name = name;
        }

        // Método para añadir movimientos
        public void AddMove(Move move)
        {
            if (Moves.Count < 4)
            {
                Moves.Add(move);
            }
        }

     
    }
}
