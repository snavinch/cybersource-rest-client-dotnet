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
    /// TokenizeResult
    /// </summary>
    [DataContract]
    public partial class TokenizeResult :  IEquatable<TokenizeResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TokenizeResult" /> class.
        /// </summary>
        /// <param name="KeyId">The Key ID..</param>
        /// <param name="Token">The generated token. The token replaces card data and is used as the Subscription ID in the CyberSource Simple Order API or SCMP API..</param>
        /// <param name="MaskedPan">The masked card number displaying the first 6 digits and the last 4 digits..</param>
        /// <param name="CardType">The card type..</param>
        /// <param name="Timestamp">The UTC date and time in milliseconds at which the signature was generated..</param>
        /// <param name="SignedFields">Indicates which fields from the response make up the data that is used when verifying the response signature. See the [sample code] (https://github.com/CyberSource/cybersource-flex-samples/blob/master/java/spring-boot/src/main/java/com/cybersource/flex/application/CheckoutController.java) on how to verify the signature..</param>
        /// <param name="Signature">Flex-generated digital signature. To ensure the values have not been tampered with while passing through the client, verify this server-side using the public key generated from the /keys resource..</param>
        /// <param name="DiscoverableServices">DiscoverableServices.</param>
        public TokenizeResult(string KeyId = default(string), string Token = default(string), string MaskedPan = default(string), string CardType = default(string), long? Timestamp = default(long?), string SignedFields = default(string), string Signature = default(string), Dictionary<string, Object> DiscoverableServices = default(Dictionary<string, Object>))
        {
            this.KeyId = KeyId;
            this.Token = Token;
            this.MaskedPan = MaskedPan;
            this.CardType = CardType;
            this.Timestamp = Timestamp;
            this.SignedFields = SignedFields;
            this.Signature = Signature;
            this.DiscoverableServices = DiscoverableServices;
        }
        
        /// <summary>
        /// The Key ID.
        /// </summary>
        /// <value>The Key ID.</value>
        [DataMember(Name="keyId", EmitDefaultValue=false)]
        public string KeyId { get; set; }

        /// <summary>
        /// The generated token. The token replaces card data and is used as the Subscription ID in the CyberSource Simple Order API or SCMP API.
        /// </summary>
        /// <value>The generated token. The token replaces card data and is used as the Subscription ID in the CyberSource Simple Order API or SCMP API.</value>
        [DataMember(Name="token", EmitDefaultValue=false)]
        public string Token { get; set; }

        /// <summary>
        /// The masked card number displaying the first 6 digits and the last 4 digits.
        /// </summary>
        /// <value>The masked card number displaying the first 6 digits and the last 4 digits.</value>
        [DataMember(Name="maskedPan", EmitDefaultValue=false)]
        public string MaskedPan { get; set; }

        /// <summary>
        /// The card type.
        /// </summary>
        /// <value>The card type.</value>
        [DataMember(Name="cardType", EmitDefaultValue=false)]
        public string CardType { get; set; }

        /// <summary>
        /// The UTC date and time in milliseconds at which the signature was generated.
        /// </summary>
        /// <value>The UTC date and time in milliseconds at which the signature was generated.</value>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public long? Timestamp { get; set; }

        /// <summary>
        /// Indicates which fields from the response make up the data that is used when verifying the response signature. See the [sample code] (https://github.com/CyberSource/cybersource-flex-samples/blob/master/java/spring-boot/src/main/java/com/cybersource/flex/application/CheckoutController.java) on how to verify the signature.
        /// </summary>
        /// <value>Indicates which fields from the response make up the data that is used when verifying the response signature. See the [sample code] (https://github.com/CyberSource/cybersource-flex-samples/blob/master/java/spring-boot/src/main/java/com/cybersource/flex/application/CheckoutController.java) on how to verify the signature.</value>
        [DataMember(Name="signedFields", EmitDefaultValue=false)]
        public string SignedFields { get; set; }

        /// <summary>
        /// Flex-generated digital signature. To ensure the values have not been tampered with while passing through the client, verify this server-side using the public key generated from the /keys resource.
        /// </summary>
        /// <value>Flex-generated digital signature. To ensure the values have not been tampered with while passing through the client, verify this server-side using the public key generated from the /keys resource.</value>
        [DataMember(Name="signature", EmitDefaultValue=false)]
        public string Signature { get; set; }

        /// <summary>
        /// Gets or Sets DiscoverableServices
        /// </summary>
        [DataMember(Name="discoverableServices", EmitDefaultValue=false)]
        public Dictionary<string, Object> DiscoverableServices { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TokenizeResult {\n");
            sb.Append("  KeyId: ").Append(KeyId).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  MaskedPan: ").Append(MaskedPan).Append("\n");
            sb.Append("  CardType: ").Append(CardType).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  SignedFields: ").Append(SignedFields).Append("\n");
            sb.Append("  Signature: ").Append(Signature).Append("\n");
            sb.Append("  DiscoverableServices: ").Append(DiscoverableServices).Append("\n");
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
            return this.Equals(obj as TokenizeResult);
        }

        /// <summary>
        /// Returns true if TokenizeResult instances are equal
        /// </summary>
        /// <param name="other">Instance of TokenizeResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TokenizeResult other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.KeyId == other.KeyId ||
                    this.KeyId != null &&
                    this.KeyId.Equals(other.KeyId)
                ) && 
                (
                    this.Token == other.Token ||
                    this.Token != null &&
                    this.Token.Equals(other.Token)
                ) && 
                (
                    this.MaskedPan == other.MaskedPan ||
                    this.MaskedPan != null &&
                    this.MaskedPan.Equals(other.MaskedPan)
                ) && 
                (
                    this.CardType == other.CardType ||
                    this.CardType != null &&
                    this.CardType.Equals(other.CardType)
                ) && 
                (
                    this.Timestamp == other.Timestamp ||
                    this.Timestamp != null &&
                    this.Timestamp.Equals(other.Timestamp)
                ) && 
                (
                    this.SignedFields == other.SignedFields ||
                    this.SignedFields != null &&
                    this.SignedFields.Equals(other.SignedFields)
                ) && 
                (
                    this.Signature == other.Signature ||
                    this.Signature != null &&
                    this.Signature.Equals(other.Signature)
                ) && 
                (
                    this.DiscoverableServices == other.DiscoverableServices ||
                    this.DiscoverableServices != null &&
                    this.DiscoverableServices.SequenceEqual(other.DiscoverableServices)
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
                if (this.KeyId != null)
                    hash = hash * 59 + this.KeyId.GetHashCode();
                if (this.Token != null)
                    hash = hash * 59 + this.Token.GetHashCode();
                if (this.MaskedPan != null)
                    hash = hash * 59 + this.MaskedPan.GetHashCode();
                if (this.CardType != null)
                    hash = hash * 59 + this.CardType.GetHashCode();
                if (this.Timestamp != null)
                    hash = hash * 59 + this.Timestamp.GetHashCode();
                if (this.SignedFields != null)
                    hash = hash * 59 + this.SignedFields.GetHashCode();
                if (this.Signature != null)
                    hash = hash * 59 + this.Signature.GetHashCode();
                if (this.DiscoverableServices != null)
                    hash = hash * 59 + this.DiscoverableServices.GetHashCode();
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
