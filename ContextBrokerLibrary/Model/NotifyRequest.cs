/* 
 * FIWARE-NGSI v2 Specification
 *
 * TODO: Add a description
 *
 * OpenAPI spec version: 1.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace ContextBrokerLibrary.Model
{
    /// <summary>
    /// NotifyRequest
    /// </summary>
    [DataContract]
    public partial class NotifyRequest : IEquatable<NotifyRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotifyRequest" /> class.
        /// </summary>
        /// <param name="subscriptionId">subscriptionId (required).</param>
        /// <param name="data">data (required).</param>
        public NotifyRequest(string subscriptionId = default(string), List<Object> data = default(List<Object>))
        {
            // to ensure "subscriptionId" is required (not null)
            if (subscriptionId == null)
            {
                throw new InvalidDataException(
                    "subscriptionId is a required property for NotifyRequest and cannot be null");
            }
            else
            {
                this.SubscriptionId = subscriptionId;
            }

            // to ensure "data" is required (not null)
            if (data == null)
            {
                throw new InvalidDataException("data is a required property for NotifyRequest and cannot be null");
            }
            else
            {
                this.Data = data;
            }
        }

        /// <summary>
        /// Gets or Sets SubscriptionId
        /// </summary>
        [DataMember(Name = "subscriptionId", EmitDefaultValue = false)]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public List<Object> Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NotifyRequest {\n");
            sb.Append("  SubscriptionId: ").Append(SubscriptionId).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as NotifyRequest);
        }

        /// <summary>
        /// Returns true if NotifyRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of NotifyRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NotifyRequest input)
        {
            if (input == null)
                return false;

            return
                (
                    this.SubscriptionId == input.SubscriptionId ||
                    (this.SubscriptionId != null &&
                     this.SubscriptionId.Equals(input.SubscriptionId))
                ) &&
                (
                    this.Data == input.Data ||
                    this.Data != null &&
                    input.Data != null &&
                    this.Data.SequenceEqual(input.Data)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.SubscriptionId != null)
                    hashCode = hashCode * 59 + this.SubscriptionId.GetHashCode();
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(
            ValidationContext validationContext)
        {
            yield break;
        }
    }
}