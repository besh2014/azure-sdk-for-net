// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.CallAutomation
{
    /// <summary> The DialogStateResponse. </summary>
    public partial class DialogStateResponse
    {
        /// <summary> Initializes a new instance of DialogStateResponse. </summary>
        internal DialogStateResponse()
        {
        }

        /// <summary> Initializes a new instance of DialogStateResponse. </summary>
        /// <param name="dialogId"> The dialog ID. </param>
        /// <param name="dialog">
        /// Defines dialog.
        /// Please note <see cref="BaseDialog"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureOpenAIDialog"/> and <see cref="PowerVirtualAgentsDialog"/>.
        /// </param>
        /// <param name="operationContext"> The value to identify context of the operation. </param>
        internal DialogStateResponse(string dialogId, BaseDialog dialog, string operationContext)
        {
            DialogId = dialogId;
            Dialog = dialog;
            OperationContext = operationContext;
        }

        /// <summary> The dialog ID. </summary>
        public string DialogId { get; }
        /// <summary>
        /// Defines dialog.
        /// Please note <see cref="BaseDialog"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureOpenAIDialog"/> and <see cref="PowerVirtualAgentsDialog"/>.
        /// </summary>
        public BaseDialog Dialog { get; }
        /// <summary> The value to identify context of the operation. </summary>
        public string OperationContext { get; }
    }
}
