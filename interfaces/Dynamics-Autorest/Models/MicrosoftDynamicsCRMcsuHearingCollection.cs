// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Pssg.Css.Interfaces.DynamicsAutorest.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Collection of csu_hearing
    /// </summary>
    /// <remarks>
    /// Microsoft.Dynamics.CRM.csu_hearingCollection
    /// </remarks>
    public partial class MicrosoftDynamicsCRMcsuHearingCollection
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMcsuHearingCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMcsuHearingCollection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMcsuHearingCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMcsuHearingCollection(IList<MicrosoftDynamicsCRMcsuHearing> value = default(IList<MicrosoftDynamicsCRMcsuHearing>))
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
        public IList<MicrosoftDynamicsCRMcsuHearing> Value { get; set; }

    }
}