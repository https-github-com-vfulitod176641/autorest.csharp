// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace CognitiveSearch.Models
{
    /// <summary> A character filter that replaces characters in the input string. It uses a regular expression to identify character sequences to preserve and a replacement pattern to identify characters to replace. For example, given the input text &quot;aa bb aa bb&quot;, pattern &quot;(aa)\s+(bb)&quot;, and replacement &quot;$1#$2&quot;, the result would be &quot;aa#bb aa#bb&quot;. This token filter is implemented using Apache Lucene. </summary>
    public partial class PatternReplaceTokenFilter : TokenFilter
    {
        /// <summary> Initializes a new instance of PatternReplaceTokenFilter. </summary>
        public PatternReplaceTokenFilter()
        {
            OdataType = "#Microsoft.Azure.Search.PatternReplaceTokenFilter";
        }

        /// <summary> Initializes a new instance of PatternReplaceTokenFilter. </summary>
        /// <param name="pattern"> A regular expression pattern. </param>
        /// <param name="replacement"> The replacement text. </param>
        /// <param name="odataType"> . </param>
        /// <param name="name"> The name of the token filter. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. </param>
        internal PatternReplaceTokenFilter(string pattern, string replacement, string odataType, string name) : base(odataType ?? "#Microsoft.Azure.Search.PatternReplaceTokenFilter", name)
        {
            Pattern = pattern;
            Replacement = replacement;
        }

        /// <summary> A regular expression pattern. </summary>
        public string Pattern { get; set; }
        /// <summary> The replacement text. </summary>
        public string Replacement { get; set; }
    }
}
