// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Bicep.Core.RegistryClient.Models
{
    /// <summary> A list of unstructured historical data for v1 compatibility. </summary>
    internal partial class History
    {
        /// <summary> Initializes a new instance of History. </summary>
        internal History()
        {
        }

        /// <summary> Initializes a new instance of History. </summary>
        /// <param name="v1Compatibility"> The raw v1 compatibility information. </param>
        internal History(string v1Compatibility)
        {
            V1Compatibility = v1Compatibility;
        }

        /// <summary> The raw v1 compatibility information. </summary>
        public string V1Compatibility { get; }
    }
}
