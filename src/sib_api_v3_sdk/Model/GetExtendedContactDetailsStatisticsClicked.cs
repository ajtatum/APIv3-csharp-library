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
    /// GetExtendedContactDetailsStatisticsClicked
    /// </summary>
    [DataContract]
    public partial class GetExtendedContactDetailsStatisticsClicked :  IEquatable<GetExtendedContactDetailsStatisticsClicked>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetExtendedContactDetailsStatisticsClicked" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetExtendedContactDetailsStatisticsClicked() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetExtendedContactDetailsStatisticsClicked" /> class.
        /// </summary>
        /// <param name="campaignId">ID of the campaign which generated the event (required).</param>
        /// <param name="links">Listing of the clicked links for the campaign (required).</param>
        public GetExtendedContactDetailsStatisticsClicked(long? campaignId = default(long?), List<GetExtendedContactDetailsStatisticsLinks> links = default(List<GetExtendedContactDetailsStatisticsLinks>))
        {
            // to ensure "campaignId" is required (not null)
            if (campaignId == null)
            {
                throw new InvalidDataException("campaignId is a required property for GetExtendedContactDetailsStatisticsClicked and cannot be null");
            }
            else
            {
                this.CampaignId = campaignId;
            }
            // to ensure "links" is required (not null)
            if (links == null)
            {
                throw new InvalidDataException("links is a required property for GetExtendedContactDetailsStatisticsClicked and cannot be null");
            }
            else
            {
                this.Links = links;
            }
        }
        
        /// <summary>
        /// ID of the campaign which generated the event
        /// </summary>
        /// <value>ID of the campaign which generated the event</value>
        [DataMember(Name="campaignId", EmitDefaultValue=false)]
        public long? CampaignId { get; set; }

        /// <summary>
        /// Listing of the clicked links for the campaign
        /// </summary>
        /// <value>Listing of the clicked links for the campaign</value>
        [DataMember(Name="links", EmitDefaultValue=false)]
        public List<GetExtendedContactDetailsStatisticsLinks> Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetExtendedContactDetailsStatisticsClicked {\n");
            sb.Append("  CampaignId: ").Append(CampaignId).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
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
            return this.Equals(input as GetExtendedContactDetailsStatisticsClicked);
        }

        /// <summary>
        /// Returns true if GetExtendedContactDetailsStatisticsClicked instances are equal
        /// </summary>
        /// <param name="input">Instance of GetExtendedContactDetailsStatisticsClicked to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetExtendedContactDetailsStatisticsClicked input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CampaignId == input.CampaignId ||
                    (this.CampaignId != null &&
                    this.CampaignId.Equals(input.CampaignId))
                ) && 
                (
                    this.Links == input.Links ||
                    this.Links != null &&
                    this.Links.SequenceEqual(input.Links)
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
                if (this.CampaignId != null)
                    hashCode = hashCode * 59 + this.CampaignId.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
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
