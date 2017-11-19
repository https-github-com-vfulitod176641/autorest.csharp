// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Fixtures.Azure.Fluent.AcceptanceTestsAzureSpecials
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using Newtonsoft.Json;

    /// <summary>
    /// Test Infrastructure for AutoRest
    /// </summary>
    public partial interface IAutoRestAzureSpecialParametersTestClient : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Credentials needed for the client to connect to Azure.
        /// </summary>
        ServiceClientCredentials Credentials { get; }

        /// <summary>
        /// The subscription id, which appears in the path, always modeled in
        /// credentials. The value is always '1234-5678-9012-3456'
        /// </summary>
        string SubscriptionId { get; set; }

        /// <summary>
        /// The api version, which appears in the query, the value is always
        /// '2015-07-01-preview'
        /// </summary>
        string ApiVersion { get; }

        /// <summary>
        /// Gets or sets the preferred language for the response.
        /// </summary>
        string AcceptLanguage { get; set; }

        /// <summary>
        /// Gets or sets the retry timeout in seconds for Long Running
        /// Operations. Default value is 30.
        /// </summary>
        int? LongRunningOperationRetryTimeout { get; set; }

        /// <summary>
        /// When set to true a unique x-ms-client-request-id value is generated
        /// and included in each request. Default is true.
        /// </summary>
        bool? GenerateClientRequestId { get; set; }


        /// <summary>
        /// Gets the IXMsClientRequestIdOperations.
        /// </summary>
        IXMsClientRequestIdOperations XMsClientRequestId { get; }

        /// <summary>
        /// Gets the ISubscriptionInCredentialsOperations.
        /// </summary>
        ISubscriptionInCredentialsOperations SubscriptionInCredentials { get; }

        /// <summary>
        /// Gets the ISubscriptionInMethodOperations.
        /// </summary>
        ISubscriptionInMethodOperations SubscriptionInMethod { get; }

        /// <summary>
        /// Gets the IApiVersionDefaultOperations.
        /// </summary>
        IApiVersionDefaultOperations ApiVersionDefault { get; }

        /// <summary>
        /// Gets the IApiVersionLocalOperations.
        /// </summary>
        IApiVersionLocalOperations ApiVersionLocal { get; }

        /// <summary>
        /// Gets the ISkipUrlEncodingOperations.
        /// </summary>
        ISkipUrlEncodingOperations SkipUrlEncoding { get; }

        /// <summary>
        /// Gets the IOdataOperations.
        /// </summary>
        IOdataOperations Odata { get; }

        /// <summary>
        /// Gets the IHeaderOperations.
        /// </summary>
        IHeaderOperations Header { get; }

    }
}