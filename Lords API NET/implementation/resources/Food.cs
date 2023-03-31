using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lords_API.implementation.resources
{
    public class Food
    {
        private VAMemory memory;
        private Pointers pointers;
        public Food(VAMemory memory, Pointers pointers)
        {
            this.memory = memory;
            this.pointers = pointers;
        }

        public double Current
        {
            get
            {
                return memory.ReadDouble(pointers.resources.foodAdress);
            }
        }
        public int Maximum
        {
            get
            {
                return memory.ReadInt32(IntPtr.Add(pointers.resources.foodAdress, 0x8));
            }
        }
        public int PerHour
        {
            get
            {
                return memory.ReadInt32(IntPtr.Add(pointers.resources.foodAdress, 0x10));
            }
        }
    }
}
