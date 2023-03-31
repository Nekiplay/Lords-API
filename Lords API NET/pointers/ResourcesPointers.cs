using System;
using System.Collections.Generic;
using System.Diagnostics;   
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lords_API.pointers
{
    public class ResourcesPointers
    {
        public IntPtr foodAdress;
        public IntPtr woodAdress;
        public IntPtr stoneAdress;
        public IntPtr oreAdress;
        public IntPtr goldAdress;
        public ResourcesPointers(Process game, VAMemory memory, Modules modules)
        {
            // 140
            foodAdress = LordsAPI.PointRead(memory, modules.gameAssembly, new int[] { Pointers.resouces, 0x210, 0x1F0 });
            stoneAdress = LordsAPI.PointRead(memory, modules.gameAssembly, new int[] { Pointers.resouces, 0x210, 0x1A0 });
            oreAdress = LordsAPI.PointRead(memory, modules.gameAssembly, new int[] { Pointers.resouces, 0x210, 0x100 });
            woodAdress = LordsAPI.PointRead(memory, modules.gameAssembly, new int[] { Pointers.resouces, 0x210, 0x150 });
            goldAdress = LordsAPI.PointRead(memory, modules.gameAssembly, new int[] { Pointers.resouces, 0x210, 0xB0 });
        }
    }
}
