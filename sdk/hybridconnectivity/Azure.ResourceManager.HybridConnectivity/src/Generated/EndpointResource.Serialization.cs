// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.HybridConnectivity
{
    public partial class EndpointResource : IJsonModel<EndpointResourceData>
    {
        void IJsonModel<EndpointResourceData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<EndpointResourceData>)Data).Write(writer, options);

        EndpointResourceData IJsonModel<EndpointResourceData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<EndpointResourceData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<EndpointResourceData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        EndpointResourceData IPersistableModel<EndpointResourceData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<EndpointResourceData>(data, options);

        string IPersistableModel<EndpointResourceData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<EndpointResourceData>)Data).GetFormatFromOptions(options);
    }
}
