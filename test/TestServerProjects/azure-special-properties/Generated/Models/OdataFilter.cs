// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace azure_special_properties.Models
{
    /// <summary> The OdataFilter. </summary>
    internal partial class OdataFilter
    {
        /// <summary> Initializes a new instance of OdataFilter. </summary>
        internal OdataFilter()
        {
        }

        /// <summary> Initializes a new instance of OdataFilter. </summary>
        /// <param name="id"> . </param>
        /// <param name="name"> . </param>
        internal OdataFilter(int? id, string name)
        {
            Id = id;
            Name = name;
        }

        public int? Id { get; }
        public string Name { get; }
    }
}
