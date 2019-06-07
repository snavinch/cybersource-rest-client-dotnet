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
    /// RiskV1DecisionsPost201ResponseRiskInformationTravelFirstDestination
    /// </summary>
    [DataContract]
    public partial class RiskV1DecisionsPost201ResponseRiskInformationTravelFirstDestination :  IEquatable<RiskV1DecisionsPost201ResponseRiskInformationTravelFirstDestination>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RiskV1DecisionsPost201ResponseRiskInformationTravelFirstDestination" /> class.
        /// </summary>
        /// <param name="Country">Country of first destination on the route..</param>
        /// <param name="Locality">City of first destination on the route..</param>
        /// <param name="Latitude">Latitude of first destination on the route..</param>
        /// <param name="Longitude">Longitude of first destination on the route..</param>
        public RiskV1DecisionsPost201ResponseRiskInformationTravelFirstDestination(string Country = default(string), string Locality = default(string), string Latitude = default(string), string Longitude = default(string))
        {
            this.Country = Country;
            this.Locality = Locality;
            this.Latitude = Latitude;
            this.Longitude = Longitude;
        }
        
        /// <summary>
        /// Country of first destination on the route.
        /// </summary>
        /// <value>Country of first destination on the route.</value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// City of first destination on the route.
        /// </summary>
        /// <value>City of first destination on the route.</value>
        [DataMember(Name="locality", EmitDefaultValue=false)]
        public string Locality { get; set; }

        /// <summary>
        /// Latitude of first destination on the route.
        /// </summary>
        /// <value>Latitude of first destination on the route.</value>
        [DataMember(Name="latitude", EmitDefaultValue=false)]
        public string Latitude { get; set; }

        /// <summary>
        /// Longitude of first destination on the route.
        /// </summary>
        /// <value>Longitude of first destination on the route.</value>
        [DataMember(Name="longitude", EmitDefaultValue=false)]
        public string Longitude { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RiskV1DecisionsPost201ResponseRiskInformationTravelFirstDestination {\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Locality: ").Append(Locality).Append("\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
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
            return this.Equals(obj as RiskV1DecisionsPost201ResponseRiskInformationTravelFirstDestination);
        }

        /// <summary>
        /// Returns true if RiskV1DecisionsPost201ResponseRiskInformationTravelFirstDestination instances are equal
        /// </summary>
        /// <param name="other">Instance of RiskV1DecisionsPost201ResponseRiskInformationTravelFirstDestination to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RiskV1DecisionsPost201ResponseRiskInformationTravelFirstDestination other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Country == other.Country ||
                    this.Country != null &&
                    this.Country.Equals(other.Country)
                ) && 
                (
                    this.Locality == other.Locality ||
                    this.Locality != null &&
                    this.Locality.Equals(other.Locality)
                ) && 
                (
                    this.Latitude == other.Latitude ||
                    this.Latitude != null &&
                    this.Latitude.Equals(other.Latitude)
                ) && 
                (
                    this.Longitude == other.Longitude ||
                    this.Longitude != null &&
                    this.Longitude.Equals(other.Longitude)
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
                if (this.Country != null)
                    hash = hash * 59 + this.Country.GetHashCode();
                if (this.Locality != null)
                    hash = hash * 59 + this.Locality.GetHashCode();
                if (this.Latitude != null)
                    hash = hash * 59 + this.Latitude.GetHashCode();
                if (this.Longitude != null)
                    hash = hash * 59 + this.Longitude.GetHashCode();
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
            // Country (string) maxLength
            if(this.Country != null && this.Country.Length > 90)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Country, length must be less than 90.", new [] { "Country" });
            }

            // Locality (string) maxLength
            if(this.Locality != null && this.Locality.Length > 90)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Locality, length must be less than 90.", new [] { "Locality" });
            }

            // Latitude (string) maxLength
            if(this.Latitude != null && this.Latitude.Length > 10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Latitude, length must be less than 10.", new [] { "Latitude" });
            }

            // Longitude (string) maxLength
            if(this.Longitude != null && this.Longitude.Length > 10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Longitude, length must be less than 10.", new [] { "Longitude" });
            }

            yield break;
        }
    }

}
