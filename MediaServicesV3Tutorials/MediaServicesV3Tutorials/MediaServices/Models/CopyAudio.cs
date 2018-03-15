// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// </auto-generated>

namespace Microsoft.Media.Encoding.Rest.ArmClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// An object to represent an audio copy codec.
    /// </summary>
    [Newtonsoft.Json.JsonObject("#Microsoft.Media.CopyAudio")]
    public partial class CopyAudio : Codec
    {
        /// <summary>
        /// Initializes a new instance of the CopyAudio class.
        /// </summary>
        public CopyAudio()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CopyAudio class.
        /// </summary>
        /// <param name="label">Gets or sets the codec label.</param>
        public CopyAudio(string label = default(string))
            : base(label)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

    }
}
