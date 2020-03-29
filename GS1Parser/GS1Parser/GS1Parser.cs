using System;
using System.Collections.Generic;
using System.Linq;

namespace GS1Parser
{
    public static class GS1Parser
    {
        private const char GroupSeparator = (char) 29;
        private const string EAN128StartCode = "]C1";
        private static readonly SortedDictionary<string, Entity> AIDict;
        private static readonly int MinLengthOfAI;
        private static readonly int MaxLengthOfAI;

        static GS1Parser()
        {
            AIDict = EntityRepository.GetEntities();
            MinLengthOfAI = AIDict.Values.Min(el => el.LengthOfAI);
            MaxLengthOfAI = AIDict.Values.Max(el => el.LengthOfAI);
        }

        /// <summary>
        /// Parse the ean128 code
        /// </summary>
        /// <param name="data">The raw scanner data</param>
        /// <param name="hasCheckSum">Need to cut off the check sum</param>
        /// <param name="throwException">If an exception will be thrown if an AI cannot be found</param>
        /// <returns>The different parts of the ean128 code</returns>
        public static Dictionary<string, string> Parse(string data, bool hasCheckSum = true, bool throwException = false)
        {
            // cut off the EAN128 start code 
            if (data.StartsWith(EAN128StartCode))
                data = data.Substring(EAN128StartCode.Length);
            // cut off the check sum
            if (hasCheckSum)
                data = data.Substring(0, data.Length - 2);

            var result = new Dictionary<string, string>();
            var index = 0;
            // walkk through the EAN128 code
            while (index < data.Length)
            {
                // try to get the AI at the current position
                var ai = GetAI(data, ref index);
                if (ai == null)
                {
                    if (throwException)
                        throw new InvalidOperationException("AI not found");
                    return result;
                }

                // get the data to the current AI
                var code = GetCode(data, ai, ref index);
                result[ai.AI] = code;
            }

            return result;
        }

        /// <summary>
        /// Try to get the AI at the current position
        /// </summary>
        /// <param name="data">The row data from the scanner</param>
        /// <param name="index">The refrence of the current position</param>
        /// <param name="usePlaceHolder">Sets if the last character of the AI should replaced with a placehoder ("d")</param>
        /// <returns>The current AI or null if no match was found</returns>
        private static Entity GetAI(string data, ref int index, bool usePlaceHolder = false)
        {
            Entity result = null;
            // Step through the different lenghts of the AIs
            for (var i = MinLengthOfAI; i <= MaxLengthOfAI; i++)
            {
                // get the AI sub string
                var ai = data.Substring(index, i);
                if (usePlaceHolder)
                    ai = ai.Remove(ai.Length - 1) + "d";
                // try to get the ai from the dictionary
                if (AIDict.TryGetValue(ai, out result))
                {
                    // Shift the index to the next
                    index += i;
                    return result;
                }

                // if no AI found, try it with the next lenght
            }

            // if no AI found here, than try it with placeholders. Assumed that is the first sep where usePlaceHolder is false
            if (!usePlaceHolder)
                result = GetAI(data, ref index, true);
            return result;
        }

        /// <summary>
        /// Get the current code to the AI
        /// </summary>
        /// <param name="data">The row data from the scanner</param>
        /// <param name="ai">The current AI</param>
        /// <param name="index">The refrence of the current position</param>
        /// <returns>the data to the current AI</returns>
        private static string GetCode(string data, Entity ai, ref int index)
        {
            // get the max lenght to read.
            var lengthToRead = Math.Min(ai.LengthOfData, data.Length - index);
            // get the data of the current AI
            var result = data.Substring(index, lengthToRead);
            // check if the AI support a group seperator
            if (ai.FNC1)
            {
                // try to find the index of the group seperator
                var indexOfGroupTermination = result.IndexOf(GroupSeparator);
                if (indexOfGroupTermination >= 0)
                    lengthToRead = indexOfGroupTermination + 1;
                // get the data of the current AI till the gorup seperator
                result = data.Substring(index, lengthToRead);
            }

            // Shift the index to the next
            index += lengthToRead;
            return result;
        }
    }
}