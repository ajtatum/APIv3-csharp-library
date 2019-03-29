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
    /// CreateSmsCampaignRecipients
    /// </summary>
    [DataContract]
    public partial class CreateSmsCampaignRecipients :  IEquatable<CreateSmsCampaignRecipients>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSmsCampaignRecipients" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateSmsCampaignRecipients() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSmsCampaignRecipients" /> class.
        /// </summary>
        /// <param name="listIds">Lists Ids to send the campaign to. REQUIRED if scheduledAt is not empty (required).</param>
        /// <param name="exclusionListIds">List ids which have to be excluded from a campaign.</param>
        public CreateSmsCampaignRecipients(List<long?> listIds = default(List<long?>), List<long?> exclusionListIds = default(List<long?>))
        {
            // to ensure "listIds" is required (not null)
            if (listIds == null)
            {
                throw new InvalidDataException("listIds is a required property for CreateSmsCampaignRecipients and cannot be null");
            }
            else
            {
                this.ListIds = listIds;
            }
            this.ExclusionListIds = exclusionListIds;
        }
        
        /// <summary>
        /// Lists Ids to send the campaign to. REQUIRED if scheduledAt is not empty
        /// </summary>
        /// <value>Lists Ids to send the campaign to. REQUIRED if scheduledAt is not empty</value>
        [DataMember(Name="listIds", EmitDefaultValue=false)]
        public List<long?> ListIds { get; set; }

        /// <summary>
        /// List ids which have to be excluded from a campaign
        /// </summary>
        /// <value>List ids which have to be excluded from a campaign</value>
        [DataMember(Name="exclusionListIds", EmitDefaultValue=false)]
        public List<long?> ExclusionListIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateSmsCampaignRecipients {\n");
            sb.Append("  ListIds: ").Append(ListIds).Append("\n");
            sb.Append("  ExclusionListIds: ").Append(ExclusionListIds).Append("\n");
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
            return this.Equals(input as CreateSmsCampaignRecipients);
        }

        /// <summary>
        /// Returns true if CreateSmsCampaignRecipients instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateSmsCampaignRecipients to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateSmsCampaignRecipients input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ListIds == input.ListIds ||
                    this.ListIds != null &&
                    this.ListIds.SequenceEqual(input.ListIds)
                ) && 
                (
                    this.ExclusionListIds == input.ExclusionListIds ||
                    this.ExclusionListIds != null &&
                    this.ExclusionListIds.SequenceEqual(input.ExclusionListIds)
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
                if (this.ListIds != null)
                    hashCode = hashCode * 59 + this.ListIds.GetHashCode();
                if (this.ExclusionListIds != null)
                    hashCode = hashCode * 59 + this.ExclusionListIds.GetHashCode();
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
