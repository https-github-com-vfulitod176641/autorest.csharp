﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using AutoRest.CSharp.V3.Generation.Types;
using AutoRest.CSharp.V3.Generation.Writers;

namespace AutoRest.CSharp.V3.Output.Models.Serialization.Json
{
    internal class SerializationData
    {
        public SerializationData(CodeWriterDelegate write, CSharpType type)
        {
            Write = write;
            Type = type;
        }

        public CodeWriterDelegate Write { get; }
        public CSharpType Type { get; }
    }
}
