//-----------------------------------------------------------------------------
// <copyright file="PersonTests.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------
using NUnit.Framework;
using ObjectLifecycle;

namespace ObjectLifecycle.Tests
{
    /// <summary>
    /// Tests para la clase <see cref="Person"/>.
    /// </summary>
    public class PersonTests
    {
        /// <summary>
        /// Prueba getters y setters de la clase <see cref="Person"/>.
        /// </summary>
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

        /// <summary>
        /// Prueba el método <see cref="Person.FullName"/>.
        /// </summary>
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