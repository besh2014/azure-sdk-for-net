﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azure.Analytics.Defender.Easm.Models;
using Azure.Core.TestFramework;
using Newtonsoft.Json;
using NUnit.Framework;

namespace Azure.Analytics.Defender.Easm.Tests.Samples
{
    public partial class ManagingExternalIdsSample : SamplesBase<EasmClientTestEnvironment>
    {
        [Test]
        [SyncOnly]
        public void ManagingExternalIdsScenario()
        {
            #region Snippet:Sample5_ExternalIds_Create_Client
#if SNIPPET
            string endpoint = "https://<region>.easm.defender.microsoft.com";
            EasmClient client = new EasmClient(new System.Uri(endpoint),
                            "<Your_Subscription_Id>",
                            "<Your_Resource_Group_Name>",
                            "<Your_Workspace_Name>",
                            new DefaultAzureCredential());
#else
            string endpoint = $"https://{TestEnvironment.Region}.easm.defender.microsoft.com";
            EasmClient client = new EasmClient(new System.Uri(endpoint),
                            TestEnvironment.SubscriptionId,
                            TestEnvironment.ResourceGroupName,
                            TestEnvironment.WorkspaceName,
                            TestEnvironment.Credential);
#endif
            #endregion

            #region Snippet:Sample5_ExternalIds_Initialize_Mapping
#if SNIPPET
            Dictionary<string, string> asset1 = new Dictionary<string, string> {
                {"name", "example.com" },
                {"kind", "host" },
                {"external_id", "EXT040" } };
            Dictionary<string, string> asset2 = new Dictionary<string, string> {
                {"name", "example.com" },
                {"kind", "domain" },
                {"external_id", "EXT041" } };
            List<Dictionary<string, string>> mapping = new List<Dictionary<string, string>> {
                asset1, asset2
            };
#else
            string mappingJson = TestEnvironment.Mapping;
            List<Dictionary<string, string>> mapping = JsonConvert.DeserializeObject<List<Dictionary<string, string>>>(mappingJson);
#endif
            #endregion

            #region Snippet:Sample5_ExternalIds_Update_Assets
            List<String> updateIds = new List<String>();
            List<String> externalIds = new List<String>();
            mapping.ForEach(asset =>
                {
                    externalIds.Add(asset["external_id"]);
                    AssetUpdateData assetUpdateRequest = new AssetUpdateData();
                    assetUpdateRequest.ExternalId = asset["external_id"];
                    string filter = $"kind = {asset["kind"]} AND name = {asset["name"]}";
                    Response<TaskResource> taskResponse = client.UpdateAssets(filter, assetUpdateRequest);
                    updateIds.Add(taskResponse.Value.Id);
                });
            #endregion

            #region Snippet:Sample5_ExternalIds_View_Update_Progress
            updateIds.ForEach(id =>
            {
                Response<TaskResource> taskResponse = client.GetTask(id);
                Console.WriteLine($"{taskResponse.Value.Id}: {taskResponse.Value.State}");
            });
            #endregion

            #region Snippet:Sample5_ExternalIds_View_Updates
            string assetFilter = $"External ID in (\"{string.Join("\", \"", externalIds)}\")";

            Response<AssetPageResult> assetPageResponse = client.GetAssetResources(assetFilter);
            foreach (AssetResource assetResponse in assetPageResponse.Value.Value)
            {
                Console.WriteLine($"{assetResponse.ExternalId}, {assetResponse.Name}");
            }
            #endregion
        }
    }
}
