using NUnit.Framework;
using ObjectLifecycle;

namespace ObjectLifecycle.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestProperties()
        {
            const string name = "Nombre";
            const string familyName = "Apellido";

            Person person = new Person(name, familyName);

            Assert.AreEqual(name, person.Name);
            Assert.AreEqual(familyName, person.FamilyName);

            const string anotherName = "John";
            const string anotherFamilyName = "Doe";

            person.Name = anotherName;
            person.FamilyName = anotherFamilyName;

            Assert.AreEqual(anotherName, person.Name);
            Assert.AreEqual(anotherFamilyName, person.FamilyName);
        }

        [Test]
        public void TestFullName()
        {
            const string name = "Nombre";
            const string familyName = "Apellido";
            const string fullName = name + " " + familyName;

            Person person = new Person(name, familyName);

            Assert.AreEqual(fullName, person.FullName);
        }        
    }
}