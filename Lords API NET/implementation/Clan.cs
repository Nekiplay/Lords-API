using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lords_API.implementation
{
    public class Clan
    {
        private VAMemory memory;
        private Pointers pointers;
        public Clan(VAMemory memory, Pointers pointers)
        {
            this.memory = memory;
            this.pointers = pointers;
        }

        public int Gifts
        {
            get
            {
                return memory.ReadInt16(pointers.clan.giftCountAdress);
            }
        }
    }
}
