// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Jag.Spice.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Collection of appconfigs
    /// </summary>
    public partial class AppconfigsGetResponseModel
    {
        /// <summary>
        /// Initializes a new instance of the AppconfigsGetResponseModel class.
        /// </summary>
        public AppconfigsGetResponseModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AppconfigsGetResponseModel class.
        /// </summary>
        public AppconfigsGetResponseModel(IList<MicrosoftDynamicsCRMappconfig> value = default(IList<MicrosoftDynamicsCRMappconfig>))
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<MicrosoftDynamicsCRMappconfig> Value { get; set; }

    }
}
