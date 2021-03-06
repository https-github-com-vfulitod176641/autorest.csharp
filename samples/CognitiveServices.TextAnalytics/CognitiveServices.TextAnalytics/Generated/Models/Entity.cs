// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace CognitiveServices.TextAnalytics.Models
{
    /// <summary> The Entity. </summary>
    public partial class Entity
    {
        /// <summary> Initializes a new instance of Entity. </summary>
        /// <param name="text"> Entity text as appears in the request. </param>
        /// <param name="type"> Entity type, such as Person/Location/Org/SSN etc. </param>
        /// <param name="offset"> Start position (in Unicode characters) for the entity text. </param>
        /// <param name="length"> Length (in Unicode characters) for the entity text. </param>
        /// <param name="score"> Confidence score between 0 and 1 of the extracted entity. </param>
        internal Entity(string text, string type, int offset, int length, double score)
        {
            if (text == null)
            {
                throw new ArgumentNullException(nameof(text));
            }
            if (type == null)
            {
                throw new ArgumentNullException(nameof(type));
            }

            Text = text;
            Type = type;
            Offset = offset;
            Length = length;
            Score = score;
        }

        /// <summary> Initializes a new instance of Entity. </summary>
        /// <param name="text"> Entity text as appears in the request. </param>
        /// <param name="type"> Entity type, such as Person/Location/Org/SSN etc. </param>
        /// <param name="subtype"> Entity sub type, such as Age/Year/TimeRange etc. </param>
        /// <param name="offset"> Start position (in Unicode characters) for the entity text. </param>
        /// <param name="length"> Length (in Unicode characters) for the entity text. </param>
        /// <param name="score"> Confidence score between 0 and 1 of the extracted entity. </param>
        internal Entity(string text, string type, string subtype, int offset, int length, double score)
        {
            Text = text;
            Type = type;
            Subtype = subtype;
            Offset = offset;
            Length = length;
            Score = score;
        }

        /// <summary> Entity text as appears in the request. </summary>
        public string Text { get; }
        /// <summary> Entity type, such as Person/Location/Org/SSN etc. </summary>
        public string Type { get; }
        /// <summary> Entity sub type, such as Age/Year/TimeRange etc. </summary>
        public string Subtype { get; }
        /// <summary> Start position (in Unicode characters) for the entity text. </summary>
        public int Offset { get; }
        /// <summary> Length (in Unicode characters) for the entity text. </summary>
        public int Length { get; }
        /// <summary> Confidence score between 0 and 1 of the extracted entity. </summary>
        public double Score { get; }
    }
}
