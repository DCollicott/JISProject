using System;


namespace JISProject.Engine
{
    public abstract class EntryBase
    {
        protected enum EntryTypeOptions
        {
            Primitive,
            Operation
        }


        protected EntryTypeOptions EntryType { get; private set; }



        protected EntryBase(EntryTypeOptions EntryType)
        {
            this.EntryType = EntryType;
        }


        public EntryBase()
        {
        }


        public abstract Decimal? Process();


        public abstract override string ToString();
    }
}
