using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lords_API.implementation
{
    public class Guild
    {
        private VAMemory memory;
        private Pointers pointers;
        public Guild(VAMemory memory, Pointers pointers)
        {
            this.memory = memory;
            this.pointers = pointers;
        }

        public int Help
        {
            get
            {
                return memory.ReadInt32(pointers.clan.helpAdress);
            }
        }
        public int Money
        {
            get
            {
                return memory.ReadInt32(pointers.clan.moneyAdress);
            }
        }
        public int Gifts
        {
            get
            {
                return memory.ReadInt16(pointers.clan.giftAdress);
            }
        }
    }
}
