// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.SecurityInsights
{
    public partial class SecurityInsightsAlertRuleResource : IJsonModel<SecurityInsightsAlertRuleData>
    {
        void IJsonModel<SecurityInsightsAlertRuleData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<SecurityInsightsAlertRuleData>)Data).Write(writer, options);

        SecurityInsightsAlertRuleData IJsonModel<SecurityInsightsAlertRuleData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<SecurityInsightsAlertRuleData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<SecurityInsightsAlertRuleData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        SecurityInsightsAlertRuleData IPersistableModel<SecurityInsightsAlertRuleData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<SecurityInsightsAlertRuleData>(data, options);

        string IPersistableModel<SecurityInsightsAlertRuleData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<SecurityInsightsAlertRuleData>)Data).GetFormatFromOptions(options);
    }
}
