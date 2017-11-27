using System;
using NUnit.Framework;
using JISProject.Engine;


namespace JISProject.Test.EngineTests
{
    [TestFixture]
    [Category("EngineTests.EntryTests")]
    public class EntryTests
    {
        [Test]
        public void CreatePrimitiveEntry()
        {
            PrimitiveEntry ent = new PrimitiveEntry();

            Assert.That(ent, Is.InstanceOf(typeof(EntryBase)));
        }


        [Test]
        public void CreatePrimitiveEntryWithParameters()
        {
            PrimitiveEntry ent = new PrimitiveEntry(23.45F);

            Assert.That(ent.Value, Is.EqualTo(23.45F));
        }


        [Test]
        public void CreateOperationEntry()
        {
            OperationEntry ent = new OperationEntry();

            Assert.That(ent, Is.InstanceOf(typeof(EntryBase)));
        }


        [Test]
        public void CreateOperationEntryWithParameters()
        {
            var A = new PrimitiveEntry(23.45F);
            var B = new PrimitiveEntry(45.67F);

            OperationEntry ent = new OperationEntry(A, OperationTypeOptions.Addition, B);

            Assert.That(ent.EntryA, Is.SameAs(A));
            Assert.That(((PrimitiveEntry)ent.EntryA).Value, Is.EqualTo(23.45F));

            Assert.That(ent.Operation, Is.EqualTo(OperationTypeOptions.Addition));

            Assert.That(ent.EntryB, Is.SameAs(B));
            Assert.That(((PrimitiveEntry)ent.EntryB).Value, Is.EqualTo(45.67F));
        }
    }
}
