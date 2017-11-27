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
            var ent = new PrimitiveEntry();

            Assert.That(ent, Is.InstanceOf(typeof(EntryBase)));
        }


        [Test]
        public void CreatePrimitiveEntryWithParameters()
        {
            var ent = new PrimitiveEntry(23.45m);

            Assert.That(ent.Value, Is.EqualTo(23.45m));
        }


        [Test]
        public void CreateOperationEntry()
        {
            var ent = new OperationEntry();

            Assert.That(ent, Is.InstanceOf(typeof(EntryBase)));
        }


        [Test]
        public void CreateOperationEntryWithParameters()
        {
            var A = new PrimitiveEntry(23.45m);
            var B = new PrimitiveEntry(34.56m);

            var ent = new OperationEntry(A, OperationTypeOptions.Addition, B);

            Assert.That(ent.EntryA, Is.SameAs(A));
            Assert.That(((PrimitiveEntry)ent.EntryA).Value, Is.EqualTo(23.45F));

            Assert.That(ent.Operation, Is.EqualTo(OperationTypeOptions.Addition));

            Assert.That(ent.EntryB, Is.SameAs(B));
            Assert.That(((PrimitiveEntry)ent.EntryB).Value, Is.EqualTo(34.56F));
        }


        [Test]
        public void CreateOperationEntryWithNestesEntries()
        {
            var AA = new PrimitiveEntry(23.45m);
            var AB = new PrimitiveEntry(34.56m);
            var A = new OperationEntry(AA, OperationTypeOptions.Subtraction, AB);
            var B = new PrimitiveEntry(45.67m);

            var ent = new OperationEntry(A, OperationTypeOptions.Subtraction, B);

            Assert.That(ent.EntryA, Is.InstanceOf(typeof(OperationEntry)));
            Assert.That(ent.EntryA, Is.SameAs(A));

            Assert.That(ent.EntryB, Is.InstanceOf(typeof(PrimitiveEntry)));
            Assert.That(ent.EntryB, Is.SameAs(B));

            Assert.That(((OperationEntry)ent.EntryA).EntryA, Is.SameAs(AA));
            Assert.That(((OperationEntry)ent.EntryA).EntryB, Is.SameAs(AB));

            Assert.That(((PrimitiveEntry)(((OperationEntry)ent.EntryA).EntryA)).Value, Is.EqualTo(23.45m));
            Assert.That(((PrimitiveEntry)(((OperationEntry)ent.EntryA).EntryB)).Value, Is.EqualTo(34.56m));
        }

    }
}
