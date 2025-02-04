// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Maps.Models
{
    /// <summary> Parameters used to update an existing Maps Account. </summary>
    public partial class MapsAccountPatch
    {
        /// <summary> Initializes a new instance of MapsAccountPatch. </summary>
        public MapsAccountPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Gets or sets a list of key value pairs that describe the resource. These tags can be used in viewing and grouping this resource (across resource groups). A maximum of 15 tags can be provided for a resource. Each tag must have a key no greater than 128 characters and value no greater than 256 characters. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Get or Set Kind property. </summary>
        public MapsAccountKind? Kind { get; set; }
        /// <summary> The SKU of this account. </summary>
        public MapsSku Sku { get; set; }
        /// <summary> A unique identifier for the maps account. </summary>
        public Guid? UniqueId { get; }
        /// <summary> Allows toggle functionality on Azure Policy to disable Azure Maps local authentication support. This will disable Shared Keys authentication from any usage. </summary>
        public bool? DisableLocalAuth { get; set; }
        /// <summary> the state of the provisioning. </summary>
        public string ProvisioningState { get; }
    }
}
