﻿
namespace NoRM
{
    /// <summary>
    /// A class that represents code with scoping - will be serialized to
    /// </summary>
    /// <typeparam name="T">Type of scoped code</typeparam>
    public class ScopedCode<T> : ScopedCode
    {
        /// <summary>
        /// The Scope this this code.
        /// </summary>
        public new T Scope { get; set; }
    }
}
