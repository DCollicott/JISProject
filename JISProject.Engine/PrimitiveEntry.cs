using System;


namespace JISProject.Engine
{
    public class PrimitiveEntry : EntryBase
    {
        public PrimitiveEntry() : base(EntryTypeOptions.Primitive)
        {
        }


        public PrimitiveEntry(float Value) : base(EntryTypeOptions.Primitive)
        {
            this.Value = Value;
        }


        public float Value { get; set; }


        public override float Process()
        {
            return Value;
        }
    }
}
