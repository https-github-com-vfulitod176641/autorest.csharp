// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace CognitiveSearch.Models
{
    public partial class SuggestResult
    {
        internal static SuggestResult DeserializeSuggestResult(JsonElement element)
        {
            string searchtext = default;
            IDictionary<string, object> additionalProperties = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("@search.text"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    searchtext = property.Value.GetString();
                    continue;
                }
                additionalProperties.Add(property.Name, property.Value.GetObject());
            }
            return new SuggestResult(searchtext, additionalProperties);
        }
    }
}
