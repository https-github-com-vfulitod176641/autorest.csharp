// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;
using Azure.Core;

namespace lro
{
    internal class LROsDeleteProvisioning202Accepted200SucceededHeaders
    {
        private readonly Response _response;
        public LROsDeleteProvisioning202Accepted200SucceededHeaders(Response response)
        {
            _response = response;
        }
        public string Location => _response.Headers.TryGetValue("Location", out string value) ? value : null;
        public int? RetryAfter => _response.Headers.TryGetValue("Retry-After", out int? value) ? value : null;
    }
}
