﻿using NoRM.BSON;


namespace NoRM.Commands.Qualifiers
{
    /// <summary>
    /// The not equal qualifier.
    /// </summary>
    public class NotEqualQualifier : QualifierCommand
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotEqualQualifier"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        internal NotEqualQualifier(object value) : base("$ne", value)
        {
        }
    }
}