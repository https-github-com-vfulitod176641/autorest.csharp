// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.FormRecognizer.Models
{
    public partial class TextLine
    {
        internal static TextLine DeserializeTextLine(JsonElement element)
        {
            string text = default;
            IReadOnlyList<float> boundingBox = default;
            Language? language = default;
            IReadOnlyList<TextWord> words = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("text"))
                {
                    text = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("boundingBox"))
                {
                    List<float> array = new List<float>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetSingle());
                    }
                    boundingBox = array;
                    continue;
                }
                if (property.NameEquals("language"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    language = new Language(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("words"))
                {
                    List<TextWord> array = new List<TextWord>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(TextWord.DeserializeTextWord(item));
                        }
                    }
                    words = array;
                    continue;
                }
            }
            return new TextLine(text, boundingBox, language, words);
        }
    }
}
