// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace CognitiveServices.TextAnalytics.Models
{
    public partial class SentenceSentiment
    {
        internal static SentenceSentiment DeserializeSentenceSentiment(JsonElement element)
        {
            SentenceSentimentValue sentiment = default;
            SentimentConfidenceScorePerLabel sentenceScores = new SentimentConfidenceScorePerLabel();
            int offset = default;
            int length = default;
            IList<string> warnings = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sentiment"))
                {
                    sentiment = property.Value.GetString().ToSentenceSentimentValue();
                    continue;
                }
                if (property.NameEquals("sentenceScores"))
                {
                    sentenceScores = SentimentConfidenceScorePerLabel.DeserializeSentimentConfidenceScorePerLabel(property.Value);
                    continue;
                }
                if (property.NameEquals("offset"))
                {
                    offset = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("length"))
                {
                    length = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("warnings"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    warnings = array;
                    continue;
                }
            }
            return new SentenceSentiment(sentiment, sentenceScores, offset, length, warnings);
        }
    }
}
