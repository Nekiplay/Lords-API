using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lords_API.pointers
{
    public class ClanPointers
    {
        public IntPtr giftCountAdress;
        public ClanPointers(Process game, VAMemory memory, Modules modules)
        {
            giftCountAdress = LordsAPI.PointRead(memory, modules.gameAssembly, new int[] { 0x02DF1DB8, 0xA98 });
        }
    }
}
