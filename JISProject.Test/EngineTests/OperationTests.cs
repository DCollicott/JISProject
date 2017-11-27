using System;
using NUnit.Framework;
using JISProject.Engine;


namespace JISProject.Test.EngineTests
{
    [TestFixture]
    [Category("EngineTests.OperationTests")]
    public class OperationTests
    {
        [Test]
        public void AddTwoNumbers()
        {
            var A = new PrimitiveEntry(23.45m);
            var B = new PrimitiveEntry(34.56m);
            var Z = new OperationEntry(A, OperationTypeOptions.Addition, B);

            var Rslt = Z.Process();

            Assert.That(Rslt, Is.EqualTo(58.01m));
        }


        [Test]
        public void SubtractionTwoNumbers()
        {
            var A = new PrimitiveEntry(23.45m);
            var B = new PrimitiveEntry(34.56m);
            var Z = new OperationEntry(A, OperationTypeOptions.Subtraction, B);

            var Rslt = Z.Process();

            Assert.That(Rslt, Is.EqualTo(-11.11m));
        }


        [Test]
        public void MultiplyTwoNumbers()
        {
            var A = new PrimitiveEntry(23.45m);
            var B = new PrimitiveEntry(34.56m);
            var Z = new OperationEntry(A, OperationTypeOptions.Multiplication, B);

            var Rslt = Z.Process();

            Assert.That(Rslt, Is.EqualTo(810.432m));
        }


        [Test]
        public void DivideTwoNumbers()
        {
            var A = new PrimitiveEntry(23.45m);
            var B = new PrimitiveEntry(34.56m);
            var Z = new OperationEntry(A, OperationTypeOptions.Division, B);

            var Rslt = Z.Process();

            Assert.That(Rslt, Is.EqualTo(A.Value / B.Value));
        }


        [Test]
        public void DivideByZero()
        {
            var A = new PrimitiveEntry(23.45m);
            var B = new PrimitiveEntry(0m);
            var Z = new OperationEntry(A, OperationTypeOptions.Division, B);

            var Rslt = Z.Process();

            Assert.That(Rslt, Is.EqualTo(null));
        }
    }
}
