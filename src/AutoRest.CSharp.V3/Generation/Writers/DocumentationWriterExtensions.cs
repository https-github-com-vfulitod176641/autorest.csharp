// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;

namespace AutoRest.CSharp.V3.Generation.Writers
{
    internal static class DocumentationWriterExtensions
    {
        private static readonly char[] _newLineChars = {'\r', '\n'};

        public static CodeWriter WriteXmlDocumentationInheritDoc(this CodeWriter writer)
        {
            return writer.Line($"/// <inheritdoc />");
        }

        public static CodeWriter WriteXmlDocumentationSummary(this CodeWriter writer, string? text)
        {
            return writer.WriteXmlDocumentation("summary", text);
        }

        public static CodeWriter WriteXmlDocumentation(this CodeWriter writer, string tag, string? text)
        {
            return writer.WriteDocumentationLines($"<{tag}>", $"</{tag}>", text);
        }

        public static CodeWriter WriteXmlDocumentationParameter(this CodeWriter writer, string name, string? text)
        {
            return writer.WriteDocumentationLines($"<param name=\"{name}\">", "</param>", text, skipWhenEmpty: false);
        }

        public static CodeWriter WriteXmlDocumentationException(this CodeWriter writer, Type exception, string? description)
        {
            return writer.WriteDocumentationLines($"<exception cref=\"{exception.FullName}\">", "</exception>", description, skipWhenEmpty: false);
        }

        private static CodeWriter WriteDocumentationLines(this CodeWriter writer, string prefix, string suffix, string? text, bool skipWhenEmpty = true)
        {
            if (string.IsNullOrEmpty(text))
            {
                if (skipWhenEmpty)
                {
                    return writer;
                }

                text = string.Empty;
            }

            var splitLines = SplitDocLines(text);
            if (splitLines.Length == 1)
            {
                writer.Line($"/// {prefix} {splitLines[0]} {suffix}");
            }
            else
            {
                writer.Line($"/// {prefix}");
                foreach (string line in splitLines)
                {
                    writer.Line($"/// {line}");
                }
                writer.Line($"/// {suffix}");
            }

            return writer;
        }

        private static string[] SplitDocLines(string text)
        {
            var lines = text.Split(_newLineChars);
            for (int i = 0; i < lines.Length; i++)
            {
                lines[i] = lines[i].TrimEnd();
            }

            if (lines.Length > 0 && !lines[^1].EndsWith("."))
            {
                lines[^1] = lines[^1] + ".";
            }

            return lines;
        }
    }
}
