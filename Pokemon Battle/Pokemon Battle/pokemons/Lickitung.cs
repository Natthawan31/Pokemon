using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Battle.pokemons
{
    internal class Lickitung : character
    {
        public Lickitung()
        {
            this.name = "Lickitung";
            Random random = new Random();
            this._image = Properties.Resources._108;
        }
    }
}
