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


        public override Decimal? Process()
        {
            Decimal? ResultA = EntryA.Process();
            Decimal? ResultB = EntryB.Process();
            Decimal? Result = null;

            if (ResultA == null || ResultB == null)
                Result = null;
            else
                switch (Operation)
                {
                    case OperationTypeOptions.Addition:
                        Result = ResultA + ResultB;
                        break;

                    case OperationTypeOptions.Subtraction:
                        Result = ResultA - ResultB;
                        break;

                    case OperationTypeOptions.Multiplication:
                        Result = ResultA * ResultB;
                        break;

                    case OperationTypeOptions.Division:
                        if (ResultB == 0)
                            Result = null;
                        else
                            Result = ResultA / ResultB;
                        break;

                    default:
                        throw new Exception(string.Format("Invalid OperationTypeOption value: {0}", Operation));
                }

            return Result;
        }
    }
}
