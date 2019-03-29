/* 
 * SendinBlue API
 *
 * SendinBlue provide a RESTFul API that can be used with any languages. With this API, you will be able to :   - Manage your campaigns and get the statistics   - Manage your contacts   - Send transactional Emails and SMS   - and much more...  You can download our wrappers at https://github.com/orgs/sendinblue  **Possible responses**   | Code | Message |   | :- -- -- -- -- -- --: | - -- -- -- -- -- -- |   | 200  | OK. Successful Request  |   | 201  | OK. Successful Creation |   | 202  | OK. Request accepted |   | 204  | OK. Successful Update/Deletion  |   | 400  | Error. Bad Request  |   | 401  | Error. Authentication Needed  |   | 402  | Error. Not enough credit, plan upgrade needed  |   | 403  | Error. Permission denied  |   | 404  | Error. Object does not exist |   | 405  | Error. Method not allowed  | 
 *
 * OpenAPI spec version: 3.0.0
 * Contact: contact@sendinblue.com
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
using SwaggerDateConverter = sib_api_v3_sdk.Client.SwaggerDateConverter;

namespace sib_api_v3_sdk.Model
{
    /// <summary>
    /// GetFolder
    /// </summary>
    [DataContract]
    public partial class GetFolder :  IEquatable<GetFolder>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetFolder" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetFolder() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetFolder" /> class.
        /// </summary>
        /// <param name="id">ID of the folder (required).</param>
        /// <param name="name">Name of the folder (required).</param>
        /// <param name="totalBlacklisted">Number of blacklisted contacts in the folder (required).</param>
        /// <param name="totalSubscribers">Number of contacts in the folder (required).</param>
        /// <param name="uniqueSubscribers">Number of unique contacts in the folder (required).</param>
        public GetFolder(long? id = default(long?), string name = default(string), long? totalBlacklisted = default(long?), long? totalSubscribers = default(long?), long? uniqueSubscribers = default(long?))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for GetFolder and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for GetFolder and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "totalBlacklisted" is required (not null)
            if (totalBlacklisted == null)
            {
                throw new InvalidDataException("totalBlacklisted is a required property for GetFolder and cannot be null");
            }
            else
            {
                this.TotalBlacklisted = totalBlacklisted;
            }
            // to ensure "totalSubscribers" is required (not null)
            if (totalSubscribers == null)
            {
                throw new InvalidDataException("totalSubscribers is a required property for GetFolder and cannot be null");
            }
            else
            {
                this.TotalSubscribers = totalSubscribers;
            }
            // to ensure "uniqueSubscribers" is required (not null)
            if (uniqueSubscribers == null)
            {
                throw new InvalidDataException("uniqueSubscribers is a required property for GetFolder and cannot be null");
            }
            else
            {
                this.UniqueSubscribers = uniqueSubscribers;
            }
        }
        
        /// <summary>
        /// ID of the folder
        /// </summary>
        /// <value>ID of the folder</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Name of the folder
        /// </summary>
        /// <value>Name of the folder</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Number of blacklisted contacts in the folder
        /// </summary>
        /// <value>Number of blacklisted contacts in the folder</value>
        [DataMember(Name="totalBlacklisted", EmitDefaultValue=false)]
        public long? TotalBlacklisted { get; set; }

        /// <summary>
        /// Number of contacts in the folder
        /// </summary>
        /// <value>Number of contacts in the folder</value>
        [DataMember(Name="totalSubscribers", EmitDefaultValue=false)]
        public long? TotalSubscribers { get; set; }

        /// <summary>
        /// Number of unique contacts in the folder
        /// </summary>
        /// <value>Number of unique contacts in the folder</value>
        [DataMember(Name="uniqueSubscribers", EmitDefaultValue=false)]
        public long? UniqueSubscribers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetFolder {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  TotalBlacklisted: ").Append(TotalBlacklisted).Append("\n");
            sb.Append("  TotalSubscribers: ").Append(TotalSubscribers).Append("\n");
            sb.Append("  UniqueSubscribers: ").Append(UniqueSubscribers).Append("\n");
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
            return this.Equals(input as GetFolder);
        }

        /// <summary>
        /// Returns true if GetFolder instances are equal
        /// </summary>
        /// <param name="input">Instance of GetFolder to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetFolder input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.TotalBlacklisted == input.TotalBlacklisted ||
                    (this.TotalBlacklisted != null &&
                    this.TotalBlacklisted.Equals(input.TotalBlacklisted))
                ) && 
                (
                    this.TotalSubscribers == input.TotalSubscribers ||
                    (this.TotalSubscribers != null &&
                    this.TotalSubscribers.Equals(input.TotalSubscribers))
                ) && 
                (
                    this.UniqueSubscribers == input.UniqueSubscribers ||
                    (this.UniqueSubscribers != null &&
                    this.UniqueSubscribers.Equals(input.UniqueSubscribers))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.TotalBlacklisted != null)
                    hashCode = hashCode * 59 + this.TotalBlacklisted.GetHashCode();
                if (this.TotalSubscribers != null)
                    hashCode = hashCode * 59 + this.TotalSubscribers.GetHashCode();
                if (this.UniqueSubscribers != null)
                    hashCode = hashCode * 59 + this.UniqueSubscribers.GetHashCode();
                return hashCode;
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
