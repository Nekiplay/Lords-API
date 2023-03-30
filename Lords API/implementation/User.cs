using Binarysharp.MemoryManagement;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lords_API.implementation
{
    public class User
    {
        private MemorySharp memory;
        private Pointers pointers;
        public User(MemorySharp memory, Pointers pointers) {
            this.memory = memory;
            this.pointers = pointers;
        }

        public int Stamina
        {
            get
            {
                IntPtr address = LordsAPI.PointRead(memory, pointers.gameAssembly, new int[] {});
            }
        }
    }
}
