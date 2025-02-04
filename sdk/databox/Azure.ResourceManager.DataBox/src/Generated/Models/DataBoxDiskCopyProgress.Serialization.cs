// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class DataBoxDiskCopyProgress
    {
        internal static DataBoxDiskCopyProgress DeserializeDataBoxDiskCopyProgress(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> serialNumber = default;
            Optional<long> bytesCopied = default;
            Optional<int> percentComplete = default;
            Optional<DataBoxCopyStatus> status = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("serialNumber"u8))
                {
                    serialNumber = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("bytesCopied"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    bytesCopied = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("percentComplete"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    percentComplete = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new DataBoxCopyStatus(property.Value.GetString());
                    continue;
                }
            }
            return new DataBoxDiskCopyProgress(serialNumber.Value, Optional.ToNullable(bytesCopied), Optional.ToNullable(percentComplete), Optional.ToNullable(status));
        }
    }
}
