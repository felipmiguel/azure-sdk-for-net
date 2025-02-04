// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.ServiceFabricManagedClusters
{
    internal class ServiceFabricManagedNodeTypeOperationSource : IOperationSource<ServiceFabricManagedNodeTypeResource>
    {
        private readonly ArmClient _client;

        internal ServiceFabricManagedNodeTypeOperationSource(ArmClient client)
        {
            _client = client;
        }

        ServiceFabricManagedNodeTypeResource IOperationSource<ServiceFabricManagedNodeTypeResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = ServiceFabricManagedNodeTypeData.DeserializeServiceFabricManagedNodeTypeData(document.RootElement);
            return new ServiceFabricManagedNodeTypeResource(_client, data);
        }

        async ValueTask<ServiceFabricManagedNodeTypeResource> IOperationSource<ServiceFabricManagedNodeTypeResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = ServiceFabricManagedNodeTypeData.DeserializeServiceFabricManagedNodeTypeData(document.RootElement);
            return new ServiceFabricManagedNodeTypeResource(_client, data);
        }
    }
}
