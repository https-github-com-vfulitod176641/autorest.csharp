// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace body_complex.Models
{
    public partial class DurationWrapper : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Field != null)
            {
                writer.WritePropertyName("field");
                writer.WriteStringValue(Field.Value, "P");
            }
            writer.WriteEndObject();
        }

        internal static DurationWrapper DeserializeDurationWrapper(JsonElement element)
        {
            TimeSpan? field = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("field"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    field = property.Value.GetTimeSpan("P");
                    continue;
                }
            }
            return new DurationWrapper(field);
        }
    }
}
