using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lords_API.pointers
{
    public class BarrackPointers
    {
        public IntPtr armyCountAdress;
        public BarrackPointers(Process game, VAMemory memory, Modules modules)
        {
            armyCountAdress = LordsAPI.PointRead(memory, modules.gameAssembly, new int[] { Pointers.colisium, 0xB8, 0x0, 0x24 });
        }
    }
}
