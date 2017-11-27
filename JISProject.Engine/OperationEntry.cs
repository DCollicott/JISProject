using System;


namespace JISProject.Engine
{
    public class OperationEntry : EntryBase
    {
        public OperationEntry(EntryTypeOptions EntryType) : base(EntryTypeOptions.Operation)
        {
        }


        public override float Process()
        {
            throw new NotImplementedException();
        }
    }
}
