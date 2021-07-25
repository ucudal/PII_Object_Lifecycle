//-------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------
using System;

namespace ObjectLifecycle
{
    /// <summary>
    /// Clase que contiene el punto de entrada al programa.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// El punto de entrada al programa.
        /// </summary>
        public static void Main()
        {
            AssignVariableWithObject();
            AssignTwoVariablesWithObject();
            CompareDifferentObjects();
            CompareEqualObjects();
            CreateObject();
        }

        /// <summary>
        /// Ejemplo que muestra la asignación de un objeto a una variable.
        /// </summary>
        public static void AssignVariableWithObject()
        {
            Person lucho;
            lucho = new Person("Luis", "Suárez");
            Console.WriteLine(lucho.FullName);
        }

        /// <summary>
        /// Ejemplo que muestra la asignación del mismo objeto a dos variables.
        /// </summary>
        public static void AssignTwoVariablesWithObject()
        {
            Person lavandina;
            lavandina = new Person("Gonzalo", "Bergesio");
            Console.WriteLine(lavandina.FullName);
            
            Person goleador;
            goleador = lavandina;
            Console.WriteLine(goleador.FullName);
            
            Console.WriteLine($"¿Las dos variables apuntan al mismo objeto? {lavandina==goleador}");
        }

        /// <summary>
        /// Ejemplo que muestra la comparación de dos objetos diferentes asignados a dos variables diferentes.
        /// </summary>
        public static void CompareDifferentObjects()
        {
            Person chino;
            chino = new Person("Álvaro", "Recoba");
            Console.WriteLine(chino.FullName);

            Person cacique;
            cacique = new Person("Alexander", "Medina");
            Console.WriteLine(cacique.FullName);

            Console.WriteLine($"¿Las dos variables apuntan al mismo objeto? {chino == cacique}");
        }

        /// <summary>
        /// Ejemplo que muestra la comparación de dos objetos ¿iguales? asignados a dos variables diferentes.
        /// </summary>
        public static void CompareEqualObjects()
        {
            Person chino;
            chino = new Person("Sergio", "Rochet");
            Console.WriteLine(chino.FullName);

            Person arquero;
            arquero = new Person("Sergio", "Rochet");
            Console.WriteLine(arquero.FullName);

            Console.WriteLine($"¿Las dos variables apuntan al mismo objeto? {chino == arquero}");
            Console.WriteLine($"¿Los dos objetos son iguales? {chino.Equals(arquero)}");
        }

        /// <summary>
        /// Ejemplo que muestra el pasaje como parámetro de un objeto
        /// </summary>
        public static void CreateObject()
        {
            Person artillero = new Person("Luis", "Artime");
            Console.WriteLine($"Antes de cambiar el nombre: {artillero.FullName}");
            UseObject(artillero);
            Console.WriteLine($"Después de cambiar el nombre: {artillero.FullName}");
        }

        /// <summary>
        /// Ejemplo que muestra cómo modificar un objeto que se recibe como parámetro.
        /// </summary>
        /// <param name="person">El objeto a modificar.</param>
        public static void UseObject(Person person)
        {
            person.FamilyName = "Ganador de Copas";
        }
    }
}