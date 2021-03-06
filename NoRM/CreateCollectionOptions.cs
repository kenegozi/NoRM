
namespace NoRM
{
    /// <summary>
    /// The create collection options.
    /// </summary>
    public class CreateCollectionOptions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCollectionOptions"/> class.
        /// </summary>
        public CreateCollectionOptions()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCollectionOptions"/> class.
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        public CreateCollectionOptions(string name)
        {
            this.Name = name;
            this.Capped = true;
            this.Size = 100000;
            this.AutoIndexId = false;
        }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether Capped.
        /// </summary>
        public bool Capped { get; set; }

        /// <summary>
        /// Gets or sets Size.
        /// </summary>
        public int Size { get; set; }

        /// <summary>
        /// Gets or sets Max.
        /// </summary>
        public long? Max { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether AutoIndexId.
        /// </summary>
        public bool AutoIndexId { get; set; }

        /// <summary>
        /// Gets or sets Create.
        /// </summary>
        public string Create { get; set; }
    }
}