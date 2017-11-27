using System;


namespace JISProject.Engine
{
    public class PrimitiveEntry : EntryBase
    {
        public PrimitiveEntry(EntryTypeOptions EntryType) : base(EntryTypeOptions.Primitive)
        {
        }


        public override float Process()
        {
            throw new NotImplementedException();
        }
    }
}
