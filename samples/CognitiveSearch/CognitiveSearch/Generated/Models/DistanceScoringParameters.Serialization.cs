// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace CognitiveSearch.Models
{
    public partial class DistanceScoringParameters : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("referencePointParameter");
            writer.WriteStringValue(ReferencePointParameter);
            writer.WritePropertyName("boostingDistance");
            writer.WriteNumberValue(BoostingDistance);
            writer.WriteEndObject();
        }

        internal static DistanceScoringParameters DeserializeDistanceScoringParameters(JsonElement element)
        {
            string referencePointParameter = default;
            double boostingDistance = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("referencePointParameter"))
                {
                    referencePointParameter = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("boostingDistance"))
                {
                    boostingDistance = property.Value.GetDouble();
                    continue;
                }
            }
            return new DistanceScoringParameters(referencePointParameter, boostingDistance);
        }
    }
}
