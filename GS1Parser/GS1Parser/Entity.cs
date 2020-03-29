namespace GS1Parser
{
    /// <summary>
    /// Information Class for an Application Identifier (AI)
    /// </summary>
    public class Entity
    {
        public Entity(string ai, string description, int lengthOfAI, DataType dataType, int lengthOfData, bool fnc1)
        {
            AI = ai;
            Description = description;
            LengthOfAI = lengthOfAI;
            DataType = dataType;
            LengthOfData = lengthOfData;
            FNC1 = fnc1;
        }

        /// <summary>
        /// Application Identifier
        /// </summary>
        public string AI { get; set; }

        /// <summary>
        /// AI description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Length of AI
        /// </summary>
        public int LengthOfAI { get; set; }

        /// <summary>
        /// The type of the content
        /// </summary>
        public DataType DataType { get; set; }

        /// <summary>
        /// The max lenght of the content
        /// </summary>
        public int LengthOfData { get; set; }

        /// <summary>
        /// Supports group separator
        /// </summary>
        public bool FNC1 { get; set; }

        /// <inheritdoc />
        public override string ToString()
        {
            return $"{AI} [{Description}]";
        }
    }
}