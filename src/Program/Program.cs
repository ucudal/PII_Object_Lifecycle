//-------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------
using System;

namespace WordsPhrases
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
            CompareObjects();
        }

        /// <summary>
        /// Ejemplo que muestra la asignación de un objeto a una variable.
        /// </summary>
        public static void AssignVariableWithObject()
        {
            Word localWord;
            localWord = new Word("Hello");
            Console.WriteLine(localWord.Text);
            localWord.ToUpper();
            Console.WriteLine(localWord.Text);
        }

        /// <summary>
        /// Ejemplo que muestra la asignación del mismo objeto a dos variables.
        /// </summary>
        public static void AssignTwoVariablesWithObject()
        {
            Word localWord;
            localWord = new Word("Hello");
            Console.WriteLine(localWord.Text);
            Word sameWord;
            sameWord = localWord;
            localWord.ToUpper();
            Console.WriteLine(sameWord.Text);
            Console.WriteLine(localWord==sameWord);
        }

        /// <summary>
        /// Ejemplo que muestra la comparación de dos objetos asignados a dos variables diferentes.
        /// </summary>
        public static void CompareObjects()
        {
            Word oneWord;
            oneWord = new Word("Hello");
            Word anotherWord;
            anotherWord = new Word("Hello");
            Console.WriteLine(oneWord == anotherWord);
        }
    }
}