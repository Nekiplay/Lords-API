using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lords_API.implementation.resources
{
    public class Stone
    {
        private VAMemory memory;
        private Pointers pointers;
        public Stone(VAMemory memory, Pointers pointers)
        {
            this.memory = memory;
            this.pointers = pointers;
        }

        public double Current
        {
            get
            {
                return memory.ReadDouble(pointers.resources.stoneAdress);
            }
        }
        public int Maximum
        {
            get
            {
                return memory.ReadInt32(IntPtr.Add(pointers.resources.stoneAdress, 0x8));
            }
        }
        public int PerHour
        {
            get
            {
                return memory.ReadInt32(IntPtr.Add(pointers.resources.stoneAdress, 0x10));
            }
        }
    }
}
