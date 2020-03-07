// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Network.Management.Interface.Models
{
    /// <summary> Response for the ListNetworkInterface API service call. </summary>
    public partial class NetworkInterfaceListResult
    {
        /// <summary> A list of network interfaces in a resource group. </summary>
        public ICollection<NetworkInterface> Value { get; set; }
        /// <summary> The URL to get the next set of results. </summary>
        public string NextLink { get; internal set; }
    }
}