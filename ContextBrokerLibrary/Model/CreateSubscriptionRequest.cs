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
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace ContextBrokerLibrary.Model
{
    /// <summary>
    /// CreateSubscriptionRequest
    /// </summary>
    [DataContract]
    public partial class CreateSubscriptionRequest : IEquatable<CreateSubscriptionRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSubscriptionRequest" /> class.
        /// </summary>
        /// <param name="description">description (required).</param>
        /// <param name="subject">subject (required).</param>
        /// <param name="notification">notification (required).</param>
        /// <param name="expires">expires (required).</param>
        /// <param name="throttling">throttling (required).</param>
        public CreateSubscriptionRequest(string description = default(string), Object subject = default(Object),
            Object notification = default(Object), string expires = default(string), int? throttling = default(int?))
        {
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new InvalidDataException(
                    "description is a required property for CreateSubscriptionRequest and cannot be null");
            }
            else
            {
                this.Description = description;
            }

            // to ensure "subject" is required (not null)
            if (subject == null)
            {
                throw new InvalidDataException(
                    "subject is a required property for CreateSubscriptionRequest and cannot be null");
            }
            else
            {
                this.Subject = subject;
            }

            // to ensure "notification" is required (not null)
            if (notification == null)
            {
                throw new InvalidDataException(
                    "notification is a required property for CreateSubscriptionRequest and cannot be null");
            }
            else
            {
                this.Notification = notification;
            }

            // to ensure "expires" is required (not null)
            if (expires == null)
            {
                throw new InvalidDataException(
                    "expires is a required property for CreateSubscriptionRequest and cannot be null");
            }
            else
            {
                this.Expires = expires;
            }

            // to ensure "throttling" is required (not null)
            if (throttling == null)
            {
                throw new InvalidDataException(
                    "throttling is a required property for CreateSubscriptionRequest and cannot be null");
            }
            else
            {
                this.Throttling = throttling;
            }
        }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Subject
        /// </summary>
        [DataMember(Name = "subject", EmitDefaultValue = false)]
        public Object Subject { get; set; }

        /// <summary>
        /// Gets or Sets Notification
        /// </summary>
        [DataMember(Name = "notification", EmitDefaultValue = false)]
        public Object Notification { get; set; }

        /// <summary>
        /// Gets or Sets Expires
        /// </summary>
        [DataMember(Name = "expires", EmitDefaultValue = false)]
        public string Expires { get; set; }

        /// <summary>
        /// Gets or Sets Throttling
        /// </summary>
        [DataMember(Name = "throttling", EmitDefaultValue = false)]
        public int? Throttling { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateSubscriptionRequest {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  Notification: ").Append(Notification).Append("\n");
            sb.Append("  Expires: ").Append(Expires).Append("\n");
            sb.Append("  Throttling: ").Append(Throttling).Append("\n");
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
            return this.Equals(input as CreateSubscriptionRequest);
        }

        /// <summary>
        /// Returns true if CreateSubscriptionRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateSubscriptionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateSubscriptionRequest input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                     this.Description.Equals(input.Description))
                ) &&
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                     this.Subject.Equals(input.Subject))
                ) &&
                (
                    this.Notification == input.Notification ||
                    (this.Notification != null &&
                     this.Notification.Equals(input.Notification))
                ) &&
                (
                    this.Expires == input.Expires ||
                    (this.Expires != null &&
                     this.Expires.Equals(input.Expires))
                ) &&
                (
                    this.Throttling == input.Throttling ||
                    (this.Throttling != null &&
                     this.Throttling.Equals(input.Throttling))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.Notification != null)
                    hashCode = hashCode * 59 + this.Notification.GetHashCode();
                if (this.Expires != null)
                    hashCode = hashCode * 59 + this.Expires.GetHashCode();
                if (this.Throttling != null)
                    hashCode = hashCode * 59 + this.Throttling.GetHashCode();
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