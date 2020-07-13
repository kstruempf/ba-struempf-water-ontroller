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
    /// GetAttributeValueResponse
    /// </summary>
    [DataContract]
    public partial class GetAttributeValueResponse : IEquatable<GetAttributeValueResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAttributeValueResponse" /> class.
        /// </summary>
        /// <param name="address">address (required).</param>
        /// <param name="zipCode">zipCode (required).</param>
        /// <param name="city">city (required).</param>
        /// <param name="country">country (required).</param>
        public GetAttributeValueResponse(string address = default(string), int? zipCode = default(int?),
            string city = default(string), string country = default(string))
        {
            // to ensure "address" is required (not null)
            if (address == null)
            {
                throw new InvalidDataException(
                    "address is a required property for GetAttributeValueResponse and cannot be null");
            }
            else
            {
                this.Address = address;
            }

            // to ensure "zipCode" is required (not null)
            if (zipCode == null)
            {
                throw new InvalidDataException(
                    "zipCode is a required property for GetAttributeValueResponse and cannot be null");
            }
            else
            {
                this.ZipCode = zipCode;
            }

            // to ensure "city" is required (not null)
            if (city == null)
            {
                throw new InvalidDataException(
                    "city is a required property for GetAttributeValueResponse and cannot be null");
            }
            else
            {
                this.City = city;
            }

            // to ensure "country" is required (not null)
            if (country == null)
            {
                throw new InvalidDataException(
                    "country is a required property for GetAttributeValueResponse and cannot be null");
            }
            else
            {
                this.Country = country;
            }
        }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name = "address", EmitDefaultValue = false)]
        public string Address { get; set; }

        /// <summary>
        /// Gets or Sets ZipCode
        /// </summary>
        [DataMember(Name = "zipCode", EmitDefaultValue = false)]
        public int? ZipCode { get; set; }

        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name = "city", EmitDefaultValue = false)]
        public string City { get; set; }

        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name = "country", EmitDefaultValue = false)]
        public string Country { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetAttributeValueResponse {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  ZipCode: ").Append(ZipCode).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
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
            return this.Equals(input as GetAttributeValueResponse);
        }

        /// <summary>
        /// Returns true if GetAttributeValueResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetAttributeValueResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetAttributeValueResponse input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                     this.Address.Equals(input.Address))
                ) &&
                (
                    this.ZipCode == input.ZipCode ||
                    (this.ZipCode != null &&
                     this.ZipCode.Equals(input.ZipCode))
                ) &&
                (
                    this.City == input.City ||
                    (this.City != null &&
                     this.City.Equals(input.City))
                ) &&
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                     this.Country.Equals(input.Country))
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
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.ZipCode != null)
                    hashCode = hashCode * 59 + this.ZipCode.GetHashCode();
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
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