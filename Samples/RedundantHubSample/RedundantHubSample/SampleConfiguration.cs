// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.

namespace RedundantHubSample
{
    public class SampleConfiguration
    {
        public string PrimaryConnectionString { get; set; }
        public string BackupConnectionString { get; set; }
        public string HubName { get; set; }
    }
}
