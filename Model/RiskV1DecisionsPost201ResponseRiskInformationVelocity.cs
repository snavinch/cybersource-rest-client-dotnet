/* 
 * CyberSource Merged Spec
 *
 * All CyberSource API specs merged together. These are available at https://developer.cybersource.com/api/reference/api-reference.html
 *
 * OpenAPI spec version: 0.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = CyberSource.Client.SwaggerDateConverter;

namespace CyberSource.Model
{
    /// <summary>
    /// RiskV1DecisionsPost201ResponseRiskInformationVelocity
    /// </summary>
    [DataContract]
    public partial class RiskV1DecisionsPost201ResponseRiskInformationVelocity :  IEquatable<RiskV1DecisionsPost201ResponseRiskInformationVelocity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RiskV1DecisionsPost201ResponseRiskInformationVelocity" /> class.
        /// </summary>
        /// <param name="Morphing">List of information codes triggered by the order. These information codes were generated when you created the order and product velocity rules and are returned so that you can associate them with the rules.  For all possible values, see the &#x60;decision_velocity_info&#x60; field description in the _Decision Manager Using the SCMP API Developer Guide_ on the [CyberSource Business Center.](https://ebc2.cybersource.com/ebc2/) Click **Decision Manager** &gt; **Documentation** &gt; **Guides** &gt; _Decision Manager Using the SCMP API Developer Guide_ (PDF link). .</param>
        /// <param name="Address">Address.</param>
        public RiskV1DecisionsPost201ResponseRiskInformationVelocity(List<RiskV1DecisionsPost201ResponseRiskInformationVelocityMorphing> Morphing = default(List<RiskV1DecisionsPost201ResponseRiskInformationVelocityMorphing>), List<string> Address = default(List<string>))
        {
            this.Morphing = Morphing;
            this.Address = Address;
        }
        
        /// <summary>
        /// List of information codes triggered by the order. These information codes were generated when you created the order and product velocity rules and are returned so that you can associate them with the rules.  For all possible values, see the &#x60;decision_velocity_info&#x60; field description in the _Decision Manager Using the SCMP API Developer Guide_ on the [CyberSource Business Center.](https://ebc2.cybersource.com/ebc2/) Click **Decision Manager** &gt; **Documentation** &gt; **Guides** &gt; _Decision Manager Using the SCMP API Developer Guide_ (PDF link). 
        /// </summary>
        /// <value>List of information codes triggered by the order. These information codes were generated when you created the order and product velocity rules and are returned so that you can associate them with the rules.  For all possible values, see the &#x60;decision_velocity_info&#x60; field description in the _Decision Manager Using the SCMP API Developer Guide_ on the [CyberSource Business Center.](https://ebc2.cybersource.com/ebc2/) Click **Decision Manager** &gt; **Documentation** &gt; **Guides** &gt; _Decision Manager Using the SCMP API Developer Guide_ (PDF link). </value>
        [DataMember(Name="morphing", EmitDefaultValue=false)]
        public List<RiskV1DecisionsPost201ResponseRiskInformationVelocityMorphing> Morphing { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public List<string> Address { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RiskV1DecisionsPost201ResponseRiskInformationVelocity {\n");
            sb.Append("  Morphing: ").Append(Morphing).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as RiskV1DecisionsPost201ResponseRiskInformationVelocity);
        }

        /// <summary>
        /// Returns true if RiskV1DecisionsPost201ResponseRiskInformationVelocity instances are equal
        /// </summary>
        /// <param name="other">Instance of RiskV1DecisionsPost201ResponseRiskInformationVelocity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RiskV1DecisionsPost201ResponseRiskInformationVelocity other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Morphing == other.Morphing ||
                    this.Morphing != null &&
                    this.Morphing.SequenceEqual(other.Morphing)
                ) && 
                (
                    this.Address == other.Address ||
                    this.Address != null &&
                    this.Address.SequenceEqual(other.Address)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Morphing != null)
                    hash = hash * 59 + this.Morphing.GetHashCode();
                if (this.Address != null)
                    hash = hash * 59 + this.Address.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
