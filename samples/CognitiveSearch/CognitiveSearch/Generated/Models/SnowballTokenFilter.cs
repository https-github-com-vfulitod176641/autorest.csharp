// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace CognitiveSearch.Models
{
    /// <summary> A filter that stems words using a Snowball-generated stemmer. This token filter is implemented using Apache Lucene. </summary>
    public partial class SnowballTokenFilter : TokenFilter
    {
        /// <summary> Initializes a new instance of SnowballTokenFilter. </summary>
        public SnowballTokenFilter()
        {
            OdataType = "#Microsoft.Azure.Search.SnowballTokenFilter";
        }

        /// <summary> Initializes a new instance of SnowballTokenFilter. </summary>
        /// <param name="language"> The language to use. </param>
        /// <param name="odataType"> . </param>
        /// <param name="name"> The name of the token filter. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. </param>
        internal SnowballTokenFilter(SnowballTokenFilterLanguage language, string odataType, string name) : base(odataType ?? "#Microsoft.Azure.Search.SnowballTokenFilter", name)
        {
            Language = language;
        }

        /// <summary> The language to use. </summary>
        public SnowballTokenFilterLanguage Language { get; set; }
    }
}
