/* 
 * CyberSource Flex API
 *
 * Simple PAN tokenization service
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
    /// Ptsv2paymentsOrderInformationAmountDetailsTaxDetails
    /// </summary>
    [DataContract]
    public partial class Ptsv2paymentsOrderInformationAmountDetailsTaxDetails :  IEquatable<Ptsv2paymentsOrderInformationAmountDetailsTaxDetails>, IValidatableObject
    {
        /// <summary>
        /// This is used to determine what type of tax related data should be inclued under _taxDetails_ object. 
        /// </summary>
        /// <value>This is used to determine what type of tax related data should be inclued under _taxDetails_ object. </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Alternate for "alternate"
            /// </summary>
            [EnumMember(Value = "alternate")]
            Alternate,
            
            /// <summary>
            /// Enum Local for "local"
            /// </summary>
            [EnumMember(Value = "local")]
            Local,
            
            /// <summary>
            /// Enum National for "national"
            /// </summary>
            [EnumMember(Value = "national")]
            National,
            
            /// <summary>
            /// Enum Vat for "vat"
            /// </summary>
            [EnumMember(Value = "vat")]
            Vat
        }

        /// <summary>
        /// This is used to determine what type of tax related data should be inclued under _taxDetails_ object. 
        /// </summary>
        /// <value>This is used to determine what type of tax related data should be inclued under _taxDetails_ object. </value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Ptsv2paymentsOrderInformationAmountDetailsTaxDetails" /> class.
        /// </summary>
        /// <param name="Type">This is used to determine what type of tax related data should be inclued under _taxDetails_ object. .</param>
        /// <param name="Amount">Please see below table for related decription based on above _type_ field.  | type      | amount description | |- -- -- -- -- --|- -- -- -- -- -- -- -- -- -- -| | alternate | Total amount of alternate tax for the order. | | local     | Sales tax for the order. | | national  | National tax for the order. | | vat       | Total amount of VAT or other tax included in the order. | .</param>
        /// <param name="Rate">Rate of VAT or other tax for the order.  Example 0.040 (&#x3D;4%)  Valid range: 0.01 to 0.99 (1% to 99%, with only whole percentage values accepted; values with additional decimal places will be truncated) .</param>
        /// <param name="Code">Type of tax being applied to the item. Possible values:  Below values are used by **RBS WorldPay Atlanta**, **FDC Nashville Global**, **Litle**   - 0000: unknown tax type  - 0001: federal/national sales tax  - 0002: state sales tax  - 0003: city sales tax  - 0004: local sales tax  - 0005: municipal sales tax  - 0006: other tax  - 0010: value-added tax  - 0011: goods and services tax  - 0012: provincial sales tax  - 0013: harmonized sales tax  - 0014: Quebec sales tax (QST)  - 0020: room tax  - 0021: occupancy tax  - 0022: energy tax  - Blank: Tax not supported on line item. .</param>
        /// <param name="TaxId">Your tax ID number to use for the alternate tax amount. Required if you set alternate tax amount to any value, including zero. You may send this field without sending alternate tax amount. .</param>
        /// <param name="Applied">The tax is applied. Valid value is &#x60;true&#x60; or &#x60;false&#x60;..</param>
        public Ptsv2paymentsOrderInformationAmountDetailsTaxDetails(TypeEnum? Type = default(TypeEnum?), string Amount = default(string), string Rate = default(string), string Code = default(string), string TaxId = default(string), bool? Applied = default(bool?))
        {
            this.Type = Type;
            this.Amount = Amount;
            this.Rate = Rate;
            this.Code = Code;
            this.TaxId = TaxId;
            this.Applied = Applied;
        }
        

        /// <summary>
        /// Please see below table for related decription based on above _type_ field.  | type      | amount description | |- -- -- -- -- --|- -- -- -- -- -- -- -- -- -- -| | alternate | Total amount of alternate tax for the order. | | local     | Sales tax for the order. | | national  | National tax for the order. | | vat       | Total amount of VAT or other tax included in the order. | 
        /// </summary>
        /// <value>Please see below table for related decription based on above _type_ field.  | type      | amount description | |- -- -- -- -- --|- -- -- -- -- -- -- -- -- -- -| | alternate | Total amount of alternate tax for the order. | | local     | Sales tax for the order. | | national  | National tax for the order. | | vat       | Total amount of VAT or other tax included in the order. | </value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public string Amount { get; set; }

        /// <summary>
        /// Rate of VAT or other tax for the order.  Example 0.040 (&#x3D;4%)  Valid range: 0.01 to 0.99 (1% to 99%, with only whole percentage values accepted; values with additional decimal places will be truncated) 
        /// </summary>
        /// <value>Rate of VAT or other tax for the order.  Example 0.040 (&#x3D;4%)  Valid range: 0.01 to 0.99 (1% to 99%, with only whole percentage values accepted; values with additional decimal places will be truncated) </value>
        [DataMember(Name="rate", EmitDefaultValue=false)]
        public string Rate { get; set; }

        /// <summary>
        /// Type of tax being applied to the item. Possible values:  Below values are used by **RBS WorldPay Atlanta**, **FDC Nashville Global**, **Litle**   - 0000: unknown tax type  - 0001: federal/national sales tax  - 0002: state sales tax  - 0003: city sales tax  - 0004: local sales tax  - 0005: municipal sales tax  - 0006: other tax  - 0010: value-added tax  - 0011: goods and services tax  - 0012: provincial sales tax  - 0013: harmonized sales tax  - 0014: Quebec sales tax (QST)  - 0020: room tax  - 0021: occupancy tax  - 0022: energy tax  - Blank: Tax not supported on line item. 
        /// </summary>
        /// <value>Type of tax being applied to the item. Possible values:  Below values are used by **RBS WorldPay Atlanta**, **FDC Nashville Global**, **Litle**   - 0000: unknown tax type  - 0001: federal/national sales tax  - 0002: state sales tax  - 0003: city sales tax  - 0004: local sales tax  - 0005: municipal sales tax  - 0006: other tax  - 0010: value-added tax  - 0011: goods and services tax  - 0012: provincial sales tax  - 0013: harmonized sales tax  - 0014: Quebec sales tax (QST)  - 0020: room tax  - 0021: occupancy tax  - 0022: energy tax  - Blank: Tax not supported on line item. </value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// Your tax ID number to use for the alternate tax amount. Required if you set alternate tax amount to any value, including zero. You may send this field without sending alternate tax amount. 
        /// </summary>
        /// <value>Your tax ID number to use for the alternate tax amount. Required if you set alternate tax amount to any value, including zero. You may send this field without sending alternate tax amount. </value>
        [DataMember(Name="taxId", EmitDefaultValue=false)]
        public string TaxId { get; set; }

        /// <summary>
        /// The tax is applied. Valid value is &#x60;true&#x60; or &#x60;false&#x60;.
        /// </summary>
        /// <value>The tax is applied. Valid value is &#x60;true&#x60; or &#x60;false&#x60;.</value>
        [DataMember(Name="applied", EmitDefaultValue=false)]
        public bool? Applied { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ptsv2paymentsOrderInformationAmountDetailsTaxDetails {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Rate: ").Append(Rate).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  TaxId: ").Append(TaxId).Append("\n");
            sb.Append("  Applied: ").Append(Applied).Append("\n");
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
            return this.Equals(obj as Ptsv2paymentsOrderInformationAmountDetailsTaxDetails);
        }

        /// <summary>
        /// Returns true if Ptsv2paymentsOrderInformationAmountDetailsTaxDetails instances are equal
        /// </summary>
        /// <param name="other">Instance of Ptsv2paymentsOrderInformationAmountDetailsTaxDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ptsv2paymentsOrderInformationAmountDetailsTaxDetails other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Amount == other.Amount ||
                    this.Amount != null &&
                    this.Amount.Equals(other.Amount)
                ) && 
                (
                    this.Rate == other.Rate ||
                    this.Rate != null &&
                    this.Rate.Equals(other.Rate)
                ) && 
                (
                    this.Code == other.Code ||
                    this.Code != null &&
                    this.Code.Equals(other.Code)
                ) && 
                (
                    this.TaxId == other.TaxId ||
                    this.TaxId != null &&
                    this.TaxId.Equals(other.TaxId)
                ) && 
                (
                    this.Applied == other.Applied ||
                    this.Applied != null &&
                    this.Applied.Equals(other.Applied)
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
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Amount != null)
                    hash = hash * 59 + this.Amount.GetHashCode();
                if (this.Rate != null)
                    hash = hash * 59 + this.Rate.GetHashCode();
                if (this.Code != null)
                    hash = hash * 59 + this.Code.GetHashCode();
                if (this.TaxId != null)
                    hash = hash * 59 + this.TaxId.GetHashCode();
                if (this.Applied != null)
                    hash = hash * 59 + this.Applied.GetHashCode();
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
            // Amount (string) maxLength
            if(this.Amount != null && this.Amount.Length > 13)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Amount, length must be less than 13.", new [] { "Amount" });
            }

            // Rate (string) maxLength
            if(this.Rate != null && this.Rate.Length > 6)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Rate, length must be less than 6.", new [] { "Rate" });
            }

            // Code (string) maxLength
            if(this.Code != null && this.Code.Length > 4)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Code, length must be less than 4.", new [] { "Code" });
            }

            // TaxId (string) maxLength
            if(this.TaxId != null && this.TaxId.Length > 15)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TaxId, length must be less than 15.", new [] { "TaxId" });
            }

            yield break;
        }
    }

}