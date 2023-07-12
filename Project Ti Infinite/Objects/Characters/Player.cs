using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Ti_Infinite.Objects.Characters
{
    public class Player : Character
    {
        public Player(string name) : base(name)
        {
            this.name = name;
        }
    }
}
