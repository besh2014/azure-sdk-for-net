// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    public partial class SparkProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(DefaultStorageUriString))
            {
                writer.WritePropertyName("defaultStorageUrl"u8);
                writer.WriteStringValue(DefaultStorageUriString);
            }
            if (Optional.IsDefined(MetastoreSpec))
            {
                writer.WritePropertyName("metastoreSpec"u8);
                writer.WriteObjectValue(MetastoreSpec);
            }
            if (Optional.IsDefined(UserPluginsSpec))
            {
                writer.WritePropertyName("userPluginsSpec"u8);
                writer.WriteObjectValue(UserPluginsSpec);
            }
            writer.WriteEndObject();
        }

        internal static SparkProfile DeserializeSparkProfile(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> defaultStorageUrl = default;
            Optional<SparkMetastoreSpec> metastoreSpec = default;
            Optional<SparkUserPlugins> userPluginsSpec = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("defaultStorageUrl"u8))
                {
                    defaultStorageUrl = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("metastoreSpec"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    metastoreSpec = SparkMetastoreSpec.DeserializeSparkMetastoreSpec(property.Value);
                    continue;
                }
                if (property.NameEquals("userPluginsSpec"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    userPluginsSpec = SparkUserPlugins.DeserializeSparkUserPlugins(property.Value);
                    continue;
                }
            }
            return new SparkProfile(defaultStorageUrl.Value, metastoreSpec.Value, userPluginsSpec.Value);
        }
    }
}
