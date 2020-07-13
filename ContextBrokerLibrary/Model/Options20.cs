/* 
 * FIWARE-NGSI v2 Specification
 *
 * TODO: Add a description
 *
 * OpenAPI spec version: 1.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ContextBrokerLibrary.Model
{
    /// <summary>
    /// Defines Options20
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Options20
    {
        /// <summary>
        /// Enum Count for value: count
        /// </summary>
        [EnumMember(Value = "count")]
        Count = 1,

        /// <summary>
        /// Enum Values for value: values
        /// </summary>
        [EnumMember(Value = "values")]
        Values = 2
    }
}