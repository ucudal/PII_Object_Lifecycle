//-------------------------------------------------------------------------
// <copyright file="Word.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------
using System;

namespace WordsPhrases
{
    /// <summary>
    /// Una palabra que es parte de una <see cref="Phrase"/>.
    /// </summary>
    public class Word
    {
        // Para uso interno de la propiedad Text.
        private string text;

        /// <summary>
        /// Crea una nueva palabra con el texto recibido como argumento.
        /// </summary>
        /// <param name="text">El texto de la palabra.</param>
        public Word(string text)
        {
            this.Text = text;
        }

        /// <summary>
        /// Obtiene o establece el texto de la palabra. El texto no tiene espacios al comienzo ni al final -los espacios
        /// son removidos al asignar el texto-.
        /// </summary>
        /// <value>El texto de la palabra</value>
        public string Text
        {
            get
            {
                return this.text;
            }

            set
            {
                this.text = value;
            }
        }

        /// <summary>
        ///  Convierte el texto de la palabra a mayúsculas.
        /// </summary>
        public void ToUpper()
        {
            this.text = this.text.ToUpper();
        }

        /// <summary>
        /// Compara dos objetos para determinar si son iguales.
        /// </summary>
        /// <param name="a">Uno de los objetos a comparar.</param>
        /// <param name="b">El otro objeto a comparar.</param>
        /// <returns><c>True</c> si el primer objeto es igual al segundo; <c>False</c> en caso contrario.</returns>
        public static bool operator == (Word a, Word b)
        {
            return a.Equals(b);
        }

        /// <summary>
        /// Compara dos objetos para determinar si son diferentes.
        /// </summary>
        /// <param name="a">Uno de los objetos a comparar.</param>
        /// <param name="b">El otro objeto a comparar.</param>
        /// <returns><c>True</c> si el primer objeto no es igual al segundo; <c>False</c> en caso contrario.</returns>
        public static bool operator != (Word a, Word b)
        {
            return !a.Equals(b);
        }

        /// <summary>
        /// Determina cuándo este objeto es igual a otro que se recibe como parámetro.
        /// </summary>
        /// <param name="obj">El objeto a comparar.</param>
        /// <returns><c>True</c> si este objeto es igual al que se recibe como parámetro; <c>False</c> en caso
        /// contrario.</returns>
        public override bool Equals(object obj)
        {
            // Si el otro objeto es null no puede ser igual a este objeto que no es null; retornar False
            if (obj == null)
            {
                return false;
            }
            // Si el otro objeto no es del mismo tipo que este objeto no pueden ser iguales; retornar False
            else if  (!this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            // Retornar True si el otro objeto tiene el mismo texto que este objeto; y False en caso contrario
            else
            {
                return this.Text.Equals(((Word)obj).Text);
            }
        }

        /// <summary>
        /// Genera un código hash para este objeto.
        /// </summary>
        /// <returns>El código hash generado.</returns>
        public override int GetHashCode()
        {
            return this.Text.GetHashCode();
        }
    }
}
