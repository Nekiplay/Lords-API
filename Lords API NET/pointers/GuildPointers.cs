using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lords_API.pointers
{
    public class GuildPointers
    {
        public IntPtr giftAdress;
        public IntPtr helpAdress;
        public IntPtr moneyAdress;
        public GuildPointers(Process game, VAMemory memory, Modules modules)
        {
            giftAdress = LordsAPI.PointRead(memory, modules.gameAssembly, new int[] { 0x02DF1DB8, 0xA98 });
            helpAdress = LordsAPI.PointRead(memory, modules.gameAssembly, new int[] { 0x02DFDCE8, 0xC28 });
            moneyAdress = LordsAPI.PointRead(memory, modules.gameAssembly, new int[] { 0x02DF3878, 0x9F0 });
        }
    }
}
