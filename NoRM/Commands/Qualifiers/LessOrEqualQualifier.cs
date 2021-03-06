﻿using NoRM.BSON;

namespace NoRM.Commands.Qualifiers
{
    /// <summary>
    /// The less or equal qualifier.
    /// </summary>
    public class LessOrEqualQualifier : QualifierCommand
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LessOrEqualQualifier"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        internal LessOrEqualQualifier(double value) : base("$lte", value)
        {
        }
    }
}