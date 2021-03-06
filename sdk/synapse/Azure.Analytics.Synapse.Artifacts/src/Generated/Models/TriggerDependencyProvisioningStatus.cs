// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Defines the response of a provision trigger dependency operation. </summary>
    internal partial class TriggerDependencyProvisioningStatus
    {
        /// <summary> Initializes a new instance of TriggerDependencyProvisioningStatus. </summary>
        /// <param name="triggerName"> Trigger name. </param>
        /// <param name="provisioningStatus"> Provisioning status. </param>
        internal TriggerDependencyProvisioningStatus(string triggerName, string provisioningStatus)
        {
            if (triggerName == null)
            {
                throw new ArgumentNullException(nameof(triggerName));
            }
            if (provisioningStatus == null)
            {
                throw new ArgumentNullException(nameof(provisioningStatus));
            }

            TriggerName = triggerName;
            ProvisioningStatus = provisioningStatus;
        }

        /// <summary> Trigger name. </summary>
        public string TriggerName { get; }
        /// <summary> Provisioning status. </summary>
        public string ProvisioningStatus { get; }
    }
}
