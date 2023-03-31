using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lords_API.implementation
{
    public class Colisium
    {
        private VAMemory memory;
        private Pointers pointers;
        public Colisium(VAMemory memory, Pointers pointers)
        {
            this.memory = memory;
            this.pointers = pointers;
        }

        public int Power
        {
            get
            {
                return memory.ReadInt32(pointers.colisium.powerAdress);
            }
        }
    }
}
