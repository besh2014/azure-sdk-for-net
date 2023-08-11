// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.Analytics.Defender.Easm.Models
{
    public partial class AssociatedCve
    {
        internal static AssociatedCve DeserializeCve(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<string> cweId = default;
            Optional<float> cvssScore = default;
            Optional<CVSS3Summary> cvss3Summary = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cweId"u8))
                {
                    cweId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cvssScore"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cvssScore = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("cvss3Summary"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cvss3Summary = CVSS3Summary.DeserializeCVSS3Summary(property.Value);
                    continue;
                }
            }
            return new AssociatedCve(name.Value, cweId.Value, Optional.ToNullable(cvssScore), cvss3Summary.Value);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static AssociatedCve FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeCve(document.RootElement);
        }
    }
}
