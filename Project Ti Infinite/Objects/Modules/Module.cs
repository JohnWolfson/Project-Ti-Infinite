using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Ti_Infinite.Objects.Modules
{
    public abstract class Module
    {
        private protected Module_Type type;

        public Module(Module_Type type)
        {
            this.type = type;
        }
    }
}
