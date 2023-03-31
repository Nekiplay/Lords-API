using Lords_API.implementation.resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lords_API.implementation
{
    public class Resources
    {
        private VAMemory memory;
        private Pointers pointers;

        public Food food;
        public Ore ore;
        public Stone stone;
        public Wood wood;
        public Gold gold;

        public Resources(VAMemory memory, Pointers pointers)
        {
            this.memory = memory;
            this.pointers = pointers;
            food = new Food(memory, pointers);
            ore = new Ore(memory, pointers);
            stone = new Stone(memory, pointers);
            wood = new Wood(memory, pointers);
            gold = new Gold(memory, pointers);
        }
    }
}
