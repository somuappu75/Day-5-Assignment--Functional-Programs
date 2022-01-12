//-----------------------------------------------------------------------
// <copyright file="Utility.cs" company="Bridgelabz">
// <creator name="somanth havinal"/>
// -----------------------------------------------------------------------
namespace Basic_Core_Programs
{
    using System;
    using System.Collections.Generic;                       // used two packages.

    /// <summary>
    /// This is Utility Class.
    /// </summary>
    class Inherit
    {
        /// <summary>
        /// Power of two.
        /// </summary>
        /// <param name="power">The power of 2</param>
        /// <returns>returns a Power of two value</returns>
        public double PowerOfTwo(int power)
        {
            return Math.Pow(2, power);              // Math.pow function gives power of first position
        }

    }
}
