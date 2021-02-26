// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Microsoft.Marketplace.Metering.Models
{
    /// <summary> The UsageEventBadRequestResponse. </summary>
    internal partial class UsageEventBadRequestResponse
    {
        /// <summary> Initializes a new instance of UsageEventBadRequestResponse. </summary>
        internal UsageEventBadRequestResponse()
        {
            Details = new ChangeTrackingList<UsageEventBadRequestResponseDetail>();
        }

        public string Code { get; }
        public string Message { get; }
        public string Target { get; }
        public IReadOnlyList<UsageEventBadRequestResponseDetail> Details { get; }
    }
}