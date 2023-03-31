using Lords_API.implementation;
using Lords_API.pointers;
using System;
using System.Diagnostics;

namespace Lords_API
{
    public class Pointers
    {
        public Modules modules;
        public UserPointers user;
        public ColisiumPointers colisium;
        public GuildPointers clan;
        public BarrackPointers barrack;
        public Pointers(Process game, VAMemory memory) 
        {
            modules = new Modules(game, memory);
            user = new UserPointers(memory, modules);
            clan = new GuildPointers(game, memory, modules);
            colisium = new ColisiumPointers(game, memory, modules);
            barrack = new BarrackPointers(game, memory, modules);
        }
    }

}
