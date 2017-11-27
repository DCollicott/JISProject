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
            throw new NotImplementedException();
        }


        [Test]
        public void MultiplyTwoNumbers()
        {
            throw new NotImplementedException();
        }


        [Test]
        public void DivideTwoNumbers()
        {
            throw new NotImplementedException();
        }


        [Test]
        public void InvalidValueTest()
        {
            throw new NotImplementedException();
        }
    }
}
