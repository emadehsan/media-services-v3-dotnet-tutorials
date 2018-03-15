// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// </auto-generated>

namespace Microsoft.Media.Encoding.Rest.ArmClient.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// MPEG-2 transport stream output.
    /// </summary>
    [Newtonsoft.Json.JsonObject("#Microsoft.Media.TransportStreamFormat")]
    public partial class TransportStreamFormat : MultiBitrateFormat
    {
        /// <summary>
        /// Initializes a new instance of the TransportStreamFormat class.
        /// </summary>
        public TransportStreamFormat()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TransportStreamFormat class.
        /// </summary>
        /// <param name="filenamePattern">Gets or sets the pattern of the
        /// filename to use excluding the extension. REVIEW: List "macros" that
        /// can be used and give examples.</param>
        /// <param name="manifestFilename">Gets or sets the pattern of the
        /// manifest file name to use excluding the extension. REVIEW: List
        /// "macros" that can be used and give examples.</param>
        /// <param name="outputFiles">Gets the list of output files.</param>
        public TransportStreamFormat(string filenamePattern = default(string), string manifestFilename = default(string), IList<OutputFile> outputFiles = default(IList<OutputFile>))
            : base(filenamePattern, manifestFilename, outputFiles)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

    }
}
