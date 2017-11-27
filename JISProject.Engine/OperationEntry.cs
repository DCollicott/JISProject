using System;


namespace JISProject.Engine
{
    public class OperationEntry : EntryBase
    {
        public OperationEntry() : base(EntryTypeOptions.Operation)
        {
        }


        public OperationEntry(EntryBase EntryA, OperationTypeOptions Operation, EntryBase EntryB) : base(EntryTypeOptions.Operation)
        {
            this.EntryA = EntryA;
            this.Operation = Operation;
            this.EntryB = EntryB;
        }


        public EntryBase EntryA { get; set; }

        public OperationTypeOptions Operation { get; set; }

        public EntryBase EntryB { get; set; }


        public override float Process()
        {
            throw new NotImplementedException();
        }
    }
}
