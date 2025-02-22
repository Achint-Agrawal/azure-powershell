// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.CognitiveServices.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The object being used to update tags and sku of a resource, in general
    /// used for PATCH operations.
    /// </summary>
    public partial class PatchResourceTagsAndSku : PatchResourceTags
    {
        /// <summary>
        /// Initializes a new instance of the PatchResourceTagsAndSku class.
        /// </summary>
        public PatchResourceTagsAndSku()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PatchResourceTagsAndSku class.
        /// </summary>
        /// <param name="tags">Resource tags.</param>
        public PatchResourceTagsAndSku(IDictionary<string, string> tags = default(IDictionary<string, string>), Sku sku = default(Sku))
            : base(tags)
        {
            Sku = sku;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public Sku Sku { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Sku != null)
            {
                Sku.Validate();
            }
        }
    }
}
