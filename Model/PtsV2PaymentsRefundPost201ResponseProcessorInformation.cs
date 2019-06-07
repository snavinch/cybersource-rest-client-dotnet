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
    /// PtsV2PaymentsRefundPost201ResponseProcessorInformation
    /// </summary>
    [DataContract]
    public partial class PtsV2PaymentsRefundPost201ResponseProcessorInformation :  IEquatable<PtsV2PaymentsRefundPost201ResponseProcessorInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PtsV2PaymentsRefundPost201ResponseProcessorInformation" /> class.
        /// </summary>
        /// <param name="TransactionId">Processor transaction ID.  This value identifies the transaction on a host system. This value is supported only for Moneris. It contains this information:   - Terminal used to process the transaction  - Shift during which the transaction took place  - Batch number  - Transaction number within the batch  You must store this value. If you give the customer a receipt, display this value on the receipt.  Example For the value 66012345001069003:   - Terminal ID &#x3D; 66012345  - Shift number &#x3D; 001  - Batch number &#x3D; 069  - Transaction number &#x3D; 003 .</param>
        /// <param name="ForwardedAcquirerCode">Name of the Japanese acquirer that processed the transaction. Returned only for CCS (CAFIS) and JCN Gateway. Please contact the CyberSource Japan Support Group for more information. .</param>
        /// <param name="MerchantNumber">Identifier that was assigned to you by your acquirer.  This value must be printed on the receipt.  This field is supported only on **American Express Direct**, **FDC Nashville Global**, and **SIX**. .</param>
        /// <param name="ResponseCode">For most processors, this is the error message sent directly from the bank. Returned only when the processor returns this value.  **Important** Do not use this field to evaluate the result of the authorization.  #### AIBMS If this value is &#x60;08&#x60;, you can accept the transaction if the customer provides you with identification.  #### Atos This value is the response code sent from Atos and it might also include the response code from the bank. Format: &#x60;aa,bb&#x60; with the two values separated by a comma and where: - &#x60;aa&#x60; is the two-digit error message from Atos. - &#x60;bb&#x60; is the optional two-digit error message from the bank.  #### Comercio Latino This value is the status code and the error or response code received from the processor separated by a colon. Format: [status code]:E[error code] or [status code]:R[response code] Example &#x60;2:R06&#x60;  #### JCN Gateway Processor-defined detail error code. The associated response category code is in the &#x60;responseCategoryCode&#x60; field. .</param>
        /// <param name="AchVerification">AchVerification.</param>
        public PtsV2PaymentsRefundPost201ResponseProcessorInformation(string TransactionId = default(string), string ForwardedAcquirerCode = default(string), string MerchantNumber = default(string), string ResponseCode = default(string), PtsV2PaymentsPost201ResponseProcessorInformationAchVerification AchVerification = default(PtsV2PaymentsPost201ResponseProcessorInformationAchVerification))
        {
            this.TransactionId = TransactionId;
            this.ForwardedAcquirerCode = ForwardedAcquirerCode;
            this.MerchantNumber = MerchantNumber;
            this.ResponseCode = ResponseCode;
            this.AchVerification = AchVerification;
        }
        
        /// <summary>
        /// Processor transaction ID.  This value identifies the transaction on a host system. This value is supported only for Moneris. It contains this information:   - Terminal used to process the transaction  - Shift during which the transaction took place  - Batch number  - Transaction number within the batch  You must store this value. If you give the customer a receipt, display this value on the receipt.  Example For the value 66012345001069003:   - Terminal ID &#x3D; 66012345  - Shift number &#x3D; 001  - Batch number &#x3D; 069  - Transaction number &#x3D; 003 
        /// </summary>
        /// <value>Processor transaction ID.  This value identifies the transaction on a host system. This value is supported only for Moneris. It contains this information:   - Terminal used to process the transaction  - Shift during which the transaction took place  - Batch number  - Transaction number within the batch  You must store this value. If you give the customer a receipt, display this value on the receipt.  Example For the value 66012345001069003:   - Terminal ID &#x3D; 66012345  - Shift number &#x3D; 001  - Batch number &#x3D; 069  - Transaction number &#x3D; 003 </value>
        [DataMember(Name="transactionId", EmitDefaultValue=false)]
        public string TransactionId { get; set; }

        /// <summary>
        /// Name of the Japanese acquirer that processed the transaction. Returned only for CCS (CAFIS) and JCN Gateway. Please contact the CyberSource Japan Support Group for more information. 
        /// </summary>
        /// <value>Name of the Japanese acquirer that processed the transaction. Returned only for CCS (CAFIS) and JCN Gateway. Please contact the CyberSource Japan Support Group for more information. </value>
        [DataMember(Name="forwardedAcquirerCode", EmitDefaultValue=false)]
        public string ForwardedAcquirerCode { get; set; }

        /// <summary>
        /// Identifier that was assigned to you by your acquirer.  This value must be printed on the receipt.  This field is supported only on **American Express Direct**, **FDC Nashville Global**, and **SIX**. 
        /// </summary>
        /// <value>Identifier that was assigned to you by your acquirer.  This value must be printed on the receipt.  This field is supported only on **American Express Direct**, **FDC Nashville Global**, and **SIX**. </value>
        [DataMember(Name="merchantNumber", EmitDefaultValue=false)]
        public string MerchantNumber { get; set; }

        /// <summary>
        /// For most processors, this is the error message sent directly from the bank. Returned only when the processor returns this value.  **Important** Do not use this field to evaluate the result of the authorization.  #### AIBMS If this value is &#x60;08&#x60;, you can accept the transaction if the customer provides you with identification.  #### Atos This value is the response code sent from Atos and it might also include the response code from the bank. Format: &#x60;aa,bb&#x60; with the two values separated by a comma and where: - &#x60;aa&#x60; is the two-digit error message from Atos. - &#x60;bb&#x60; is the optional two-digit error message from the bank.  #### Comercio Latino This value is the status code and the error or response code received from the processor separated by a colon. Format: [status code]:E[error code] or [status code]:R[response code] Example &#x60;2:R06&#x60;  #### JCN Gateway Processor-defined detail error code. The associated response category code is in the &#x60;responseCategoryCode&#x60; field. 
        /// </summary>
        /// <value>For most processors, this is the error message sent directly from the bank. Returned only when the processor returns this value.  **Important** Do not use this field to evaluate the result of the authorization.  #### AIBMS If this value is &#x60;08&#x60;, you can accept the transaction if the customer provides you with identification.  #### Atos This value is the response code sent from Atos and it might also include the response code from the bank. Format: &#x60;aa,bb&#x60; with the two values separated by a comma and where: - &#x60;aa&#x60; is the two-digit error message from Atos. - &#x60;bb&#x60; is the optional two-digit error message from the bank.  #### Comercio Latino This value is the status code and the error or response code received from the processor separated by a colon. Format: [status code]:E[error code] or [status code]:R[response code] Example &#x60;2:R06&#x60;  #### JCN Gateway Processor-defined detail error code. The associated response category code is in the &#x60;responseCategoryCode&#x60; field. </value>
        [DataMember(Name="responseCode", EmitDefaultValue=false)]
        public string ResponseCode { get; set; }

        /// <summary>
        /// Gets or Sets AchVerification
        /// </summary>
        [DataMember(Name="achVerification", EmitDefaultValue=false)]
        public PtsV2PaymentsPost201ResponseProcessorInformationAchVerification AchVerification { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PtsV2PaymentsRefundPost201ResponseProcessorInformation {\n");
            sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
            sb.Append("  ForwardedAcquirerCode: ").Append(ForwardedAcquirerCode).Append("\n");
            sb.Append("  MerchantNumber: ").Append(MerchantNumber).Append("\n");
            sb.Append("  ResponseCode: ").Append(ResponseCode).Append("\n");
            sb.Append("  AchVerification: ").Append(AchVerification).Append("\n");
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
            return this.Equals(obj as PtsV2PaymentsRefundPost201ResponseProcessorInformation);
        }

        /// <summary>
        /// Returns true if PtsV2PaymentsRefundPost201ResponseProcessorInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of PtsV2PaymentsRefundPost201ResponseProcessorInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PtsV2PaymentsRefundPost201ResponseProcessorInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TransactionId == other.TransactionId ||
                    this.TransactionId != null &&
                    this.TransactionId.Equals(other.TransactionId)
                ) && 
                (
                    this.ForwardedAcquirerCode == other.ForwardedAcquirerCode ||
                    this.ForwardedAcquirerCode != null &&
                    this.ForwardedAcquirerCode.Equals(other.ForwardedAcquirerCode)
                ) && 
                (
                    this.MerchantNumber == other.MerchantNumber ||
                    this.MerchantNumber != null &&
                    this.MerchantNumber.Equals(other.MerchantNumber)
                ) && 
                (
                    this.ResponseCode == other.ResponseCode ||
                    this.ResponseCode != null &&
                    this.ResponseCode.Equals(other.ResponseCode)
                ) && 
                (
                    this.AchVerification == other.AchVerification ||
                    this.AchVerification != null &&
                    this.AchVerification.Equals(other.AchVerification)
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
                if (this.TransactionId != null)
                    hash = hash * 59 + this.TransactionId.GetHashCode();
                if (this.ForwardedAcquirerCode != null)
                    hash = hash * 59 + this.ForwardedAcquirerCode.GetHashCode();
                if (this.MerchantNumber != null)
                    hash = hash * 59 + this.MerchantNumber.GetHashCode();
                if (this.ResponseCode != null)
                    hash = hash * 59 + this.ResponseCode.GetHashCode();
                if (this.AchVerification != null)
                    hash = hash * 59 + this.AchVerification.GetHashCode();
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
            // TransactionId (string) maxLength
            if(this.TransactionId != null && this.TransactionId.Length > 18)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TransactionId, length must be less than 18.", new [] { "TransactionId" });
            }

            // ForwardedAcquirerCode (string) maxLength
            if(this.ForwardedAcquirerCode != null && this.ForwardedAcquirerCode.Length > 32)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ForwardedAcquirerCode, length must be less than 32.", new [] { "ForwardedAcquirerCode" });
            }

            // MerchantNumber (string) maxLength
            if(this.MerchantNumber != null && this.MerchantNumber.Length > 15)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MerchantNumber, length must be less than 15.", new [] { "MerchantNumber" });
            }

            // ResponseCode (string) maxLength
            if(this.ResponseCode != null && this.ResponseCode.Length > 10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ResponseCode, length must be less than 10.", new [] { "ResponseCode" });
            }

            yield break;
        }
    }

}
