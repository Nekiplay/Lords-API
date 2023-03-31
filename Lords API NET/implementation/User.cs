namespace Lords_API.implementation
{
    public class User
    {
        private VAMemory memory;
        private Pointers pointers;
        public User(VAMemory memory, Pointers pointers) {
            this.memory = memory;
            this.pointers = pointers;
        }
        //public int Attacks
        //{
        //    get
        //    {
        //        return memory.ReadInt32(pointers.user.attacksAdress);
        //    }
        //}
        //public bool isAttacked
        //{
        //    get
        //    {
        //        return Attacks > 0;
        //    }
        //}
        public int Power
        {
            get
            {
                return memory.ReadInt32(pointers.user.powerAdress);
            }
        }
        public int Stamina
        {
            get
            {
                return memory.ReadInt32(pointers.user.staminaAdress);
            }
        }

        public int Gems
        {
            get
            {
                return memory.ReadInt32(pointers.user.gemsAdress);
            }
        }
    }
}
