using System;


namespace JISProject.Engine
{
    public abstract class EntryBase
    {
        public EntryTypeOptions EntryType { get; private set; }

        public abstract float Process();


        public EntryBase(EntryTypeOptions EntryType)
        {
            this.EntryType = EntryType;
        }
    }
}
