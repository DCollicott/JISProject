using System;


namespace JISProject.Engine
{
    public class PrimitiveEntry : EntryBase
    {
        public PrimitiveEntry() : base(EntryTypeOptions.Primitive)
        {
        }


        public PrimitiveEntry(Decimal? Value) : base(EntryTypeOptions.Primitive)
        {
            this.Value = Value;
        }


        public Decimal? Value { get; set; }


        public override Decimal? Process()
        {
            return Value;
        }
    }
}
