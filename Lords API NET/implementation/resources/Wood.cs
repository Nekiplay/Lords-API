using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lords_API.implementation.resources
{
    public class Wood
    {
        private VAMemory memory;
        private Pointers pointers;
        public Wood(VAMemory memory, Pointers pointers)
        {
            this.memory = memory;
            this.pointers = pointers;
        }

        public double Current
        {
            get
            {
                return memory.ReadDouble(pointers.resources.woodAdress);
            }
        }
        public int Maximum
        {
            get
            {
                return memory.ReadInt32(IntPtr.Add(pointers.resources.woodAdress, 0x8));
            }
        }
        public int PerHour
        {
            get
            {
                return memory.ReadInt32(IntPtr.Add(pointers.resources.woodAdress, 0x10));
            }
        }
    }
}
