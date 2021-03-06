﻿using System.Collections.Generic;

namespace NoRM
{

    /// <summary>
    /// Generic collection interface
    /// </summary>
    /// <typeparam name="T">The type of collection</typeparam>
    public interface IMongoCollection<T> : IMongoCollection
    {
        /// <summary>
        /// Finds the specified document.
        /// </summary>
        /// <typeparam name="U">Type of document</typeparam>
        /// <param name="template">The template.</param>
        /// <returns></returns>
        IEnumerable<T> Find<U>(U template);
        /// <summary>
        /// Finds all documents.
        /// </summary>
        /// <returns></returns>
        IEnumerable<T> Find();
        /// <summary>
        /// Finds the specified document with a limited result set.
        /// </summary>
        /// <typeparam name="U">Type of document</typeparam>
        /// <param name="template">The template.</param>
        /// <param name="limit">The limit.</param>
        /// <param name="fullyQualifiedName">Name of the fully qualified.</param>
        /// <returns></returns>
        IEnumerable<T> Find<U>(U template, int limit, string fullyQualifiedName);
        /// <summary>
        /// Finds the specified document with a limited result set.
        /// </summary>
        /// <typeparam name="U">Type of document</typeparam>
        /// <param name="template">The template.</param>
        /// <param name="limit">The limit.</param>
        /// <returns></returns>
        IEnumerable<T> Find<U>(U template, int limit);
        /// <summary>
        /// Finds one document.
        /// </summary>
        /// <typeparam name="U">Type to find</typeparam>
        /// <param name="template">The template.</param>
        /// <returns></returns>
        T FindOne<U>(U template);
        MongoCollection<U> GetChildCollection<U>(string collectionName) where U : class, new();
        /// <summary>
        /// Updates the specified document.
        /// </summary>
        /// <typeparam name="X">Document to match</typeparam>
        /// <typeparam name="U">Document to update</typeparam>
        /// <param name="matchDocument">The match document.</param>
        /// <param name="valueDocument">The value document.</param>
        /// <param name="updateMultiple">if set to <c>true</c> update all matching documents.</param>
        /// <param name="upsert">if set to <c>true</c> upsert.</param>
        void Update<X, U>(X matchDocument, U valueDocument, bool updateMultiple, bool upsert);
        /// <summary>
        /// Gets a value indicating whether this <see cref="IMongoCollection&lt;T&gt;"/> is updateable.
        /// </summary>
        /// <value><c>true</c> if updateable; otherwise, <c>false</c>.</value>
        bool Updateable { get; }
        /// <summary>
        /// Updates multiple documents.
        /// </summary>
        /// <typeparam name="X">Document to match</typeparam>
        /// <typeparam name="U">Document to update</typeparam>
        /// <param name="matchDocument">The match document.</param>
        /// <param name="valueDocument">The value document.</param>
        void UpdateMultiple<X, U>(X matchDocument, U valueDocument);
        /// <summary>
        /// Updates one document.
        /// </summary>
        /// <typeparam name="X">Document to match</typeparam>
        /// <typeparam name="U">Document to update</typeparam>
        /// <param name="matchDocument">The match document.</param>
        /// <param name="valueDocument">The value document.</param>
        void UpdateOne<X, U>(X matchDocument, U valueDocument);
    }
}
