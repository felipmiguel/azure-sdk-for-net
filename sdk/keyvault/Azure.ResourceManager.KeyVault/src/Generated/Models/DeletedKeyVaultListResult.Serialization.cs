// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.KeyVault;

namespace Azure.ResourceManager.KeyVault.Models
{
    internal partial class DeletedKeyVaultListResult
    {
        internal static DeletedKeyVaultListResult DeserializeDeletedKeyVaultListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<DeletedKeyVaultData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DeletedKeyVaultData> array = new List<DeletedKeyVaultData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeletedKeyVaultData.DeserializeDeletedKeyVaultData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new DeletedKeyVaultListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
