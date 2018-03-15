// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// </auto-generated>

namespace Microsoft.Media.Encoding.Rest.ArmClient
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using Newtonsoft.Json;

    /// <summary>
    /// This Swagger was generated by the API Framework.
    /// </summary>
    public partial interface IAzureMediaServicesClient : System.IDisposable
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
        /// The subscription ID.
        /// </summary>
        string SubscriptionId { get; set; }

        /// <summary>
        /// The resource group name.
        /// </summary>
        string ResourceGroupName { get; set; }

        /// <summary>
        /// The API version.
        /// </summary>
        string ApiVersion { get; }

        /// <summary>
        /// The Media Services account name.
        /// </summary>
        string AccountName { get; set; }

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
        /// Gets the IOperations.
        /// </summary>
        IOperations Operations { get; }

        /// <summary>
        /// Gets the IMediaservicesOperations.
        /// </summary>
        IMediaservicesOperations Mediaservices { get; }

        /// <summary>
        /// Gets the IProvidersOperations.
        /// </summary>
        IProvidersOperations Providers { get; }

        /// <summary>
        /// Gets the IAssetsOperations.
        /// </summary>
        IAssetsOperations Assets { get; }

        /// <summary>
        /// Gets the ITransformsOperations.
        /// </summary>
        ITransformsOperations Transforms { get; }

        /// <summary>
        /// Gets the IJobsOperations.
        /// </summary>
        IJobsOperations Jobs { get; }

    }
}
