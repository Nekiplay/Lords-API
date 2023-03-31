using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lords_API.implementation
{
    public class Barrack
    {
        private VAMemory memory;
        private Pointers pointers;
        public Barrack(VAMemory memory, Pointers pointers)
        {
            this.memory = memory;
            this.pointers = pointers;
        }

        public int Army
        {
            get
            {
                return memory.ReadInt32(pointers.barrack.armyCountAdress);
            }
        }
    }
}
