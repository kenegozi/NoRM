﻿using NoRM.BSON;

namespace NoRM.Commands.Qualifiers
{
    /// <summary>
    /// The greater than qualifier.
    /// </summary>
    public class GreaterThanQualifier : QualifierCommand
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GreaterThanQualifier"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        internal GreaterThanQualifier(double value) : base("$gt", value)
        {
        }
    }
}