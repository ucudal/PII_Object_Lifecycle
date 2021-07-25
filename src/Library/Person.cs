//-------------------------------------------------------------------------
// <copyright file="Person.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------
using System;

namespace ObjectLifecycle
{
    /// <summary>
    /// Una persona.
    /// </summary>
    public class Person
    {
        // Para uso interno de la propiedad Name.
        private string name;

        // Para uso interno de la propiedad FamilyName.
        private string familyName;

        /// <summary>
        /// Crea una nueva persona con el nombre y apellidos recibids como argumento.
        /// </summary>
        /// <param name="name">El nombre de la persona.</param>
        /// <param name="familyName">El apellido de la persona.</param>
        public Person(string name, string familyName)
        {
            this.Name = name;
            this.familyName = familyName;
        }

        /// <summary>
        /// Obtiene o establece el nombre de la persona. El texto no tiene espacios al comienzo ni al final -los espacios
        /// son removidos al asignar el texto-.
        /// </summary>
        /// <value>El nombre de la persona</value>
        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value;
            }
        }

        /// <summary>
        /// Obtiene o establece el apellido de la persona. El texto no tiene espacios al comienzo ni al final -los
        /// espaciosson removidos al asignar el texto-.
        /// </summary>
        /// <value>El apellido de la persona</value>
        public string FamilyName
        {
            get
            {
                return this.familyName;
            }

            set
            {
                this.familyName = value;
            }
        }        

        /// <summary>
        ///  Obtiene el nombre completo de la persona concatenando el nombre y el apellido.
        /// </summary>
        public string FullName
        {   
            get
            {
                return String.Format($"{this.name} {this.familyName}");
            }
        }

    // #region Comparación        

    //     /// <summary>
    //     /// Compara dos objetos para determinar si son iguales.
    //     /// </summary>
    //     /// <param name="a">Uno de los objetos a comparar.</param>
    //     /// <param name="b">El otro objeto a comparar.</param>
    //     /// <returns><c>True</c> si el primer objeto es igual al segundo; <c>False</c> en caso contrario.</returns>
    //     public static bool operator == (Person a, Person b)
    //     {
    //         return a.Equals(b);
    //     }

    //     /// <summary>
    //     /// Compara dos objetos para determinar si son diferentes.
    //     /// </summary>
    //     /// <param name="a">Uno de los objetos a comparar.</param>
    //     /// <param name="b">El otro objeto a comparar.</param>
    //     /// <returns><c>True</c> si el primer objeto no es igual al segundo; <c>False</c> en caso contrario.</returns>
    //     public static bool operator != (Person a, Person b)
    //     {
    //         return !a.Equals(b);
    //     }

    //     /// <summary>
    //     /// Determina cuándo esta persona es igual a otra que se recibe como parámetro.
    //     /// </summary>
    //     /// <param name="obj">El objeto a comparar.</param>
    //     /// <returns><c>True</c> si este objeto es igual al que se recibe como parámetro; <c>False</c> en caso
    //     /// contrario.</returns>
    //     public override bool Equals(object obj)
    //     {
    //         // Si el otro objeto es null no puede ser igual a este objeto que no es null; retornar False
    //         if (obj == null)
    //         {
    //             return false;
    //         }
    //         // Si el otro objeto no es del mismo tipo que este objeto no pueden ser iguales; retornar False
    //         else if  (!this.GetType().Equals(obj.GetType()))
    //         {
    //             return false;
    //         }
    //         // Retornar True si el otro objeto tiene el mismo texto que este objeto; y False en caso contrario
    //         else
    //         {
    //             return this.FullName.Equals(((Person)obj).FullName);
    //         }
    //     }

    //     /// <summary>
    //     /// Genera un código hash para este objeto.
    //     /// </summary>
    //     /// <returns>El código hash generado.</returns>
    //     public override int GetHashCode()
    //     {
    //         return this.FullName.GetHashCode();
    //     }
    // #endregion
    
    }
}
