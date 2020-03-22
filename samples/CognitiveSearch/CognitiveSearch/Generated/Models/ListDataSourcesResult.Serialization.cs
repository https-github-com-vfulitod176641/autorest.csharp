// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace CognitiveSearch.Models
{
    public partial class ListDataSourcesResult
    {
        internal static ListDataSourcesResult DeserializeListDataSourcesResult(JsonElement element)
        {
            IList<DataSource> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataSource> array = new List<DataSource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataSource.DeserializeDataSource(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new ListDataSourcesResult(value);
        }
    }
}
