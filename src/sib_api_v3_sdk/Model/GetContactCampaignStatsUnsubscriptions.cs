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
    /// GetContactCampaignStatsUnsubscriptions
    /// </summary>
    [DataContract]
    public partial class GetContactCampaignStatsUnsubscriptions :  IEquatable<GetContactCampaignStatsUnsubscriptions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetContactCampaignStatsUnsubscriptions" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetContactCampaignStatsUnsubscriptions() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetContactCampaignStatsUnsubscriptions" /> class.
        /// </summary>
        /// <param name="userUnsubscription">Contact has unsubscribed via the unsubscription link in the email (required).</param>
        /// <param name="adminUnsubscription">Contact has been unsubscribed from the administrator (required).</param>
        public GetContactCampaignStatsUnsubscriptions(List<GetExtendedContactDetailsStatisticsUnsubscriptionsUserUnsubscription> userUnsubscription = default(List<GetExtendedContactDetailsStatisticsUnsubscriptionsUserUnsubscription>), List<GetExtendedContactDetailsStatisticsUnsubscriptionsAdminUnsubscription> adminUnsubscription = default(List<GetExtendedContactDetailsStatisticsUnsubscriptionsAdminUnsubscription>))
        {
            // to ensure "userUnsubscription" is required (not null)
            if (userUnsubscription == null)
            {
                throw new InvalidDataException("userUnsubscription is a required property for GetContactCampaignStatsUnsubscriptions and cannot be null");
            }
            else
            {
                this.UserUnsubscription = userUnsubscription;
            }
            // to ensure "adminUnsubscription" is required (not null)
            if (adminUnsubscription == null)
            {
                throw new InvalidDataException("adminUnsubscription is a required property for GetContactCampaignStatsUnsubscriptions and cannot be null");
            }
            else
            {
                this.AdminUnsubscription = adminUnsubscription;
            }
        }
        
        /// <summary>
        /// Contact has unsubscribed via the unsubscription link in the email
        /// </summary>
        /// <value>Contact has unsubscribed via the unsubscription link in the email</value>
        [DataMember(Name="userUnsubscription", EmitDefaultValue=false)]
        public List<GetExtendedContactDetailsStatisticsUnsubscriptionsUserUnsubscription> UserUnsubscription { get; set; }

        /// <summary>
        /// Contact has been unsubscribed from the administrator
        /// </summary>
        /// <value>Contact has been unsubscribed from the administrator</value>
        [DataMember(Name="adminUnsubscription", EmitDefaultValue=false)]
        public List<GetExtendedContactDetailsStatisticsUnsubscriptionsAdminUnsubscription> AdminUnsubscription { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetContactCampaignStatsUnsubscriptions {\n");
            sb.Append("  UserUnsubscription: ").Append(UserUnsubscription).Append("\n");
            sb.Append("  AdminUnsubscription: ").Append(AdminUnsubscription).Append("\n");
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
            return this.Equals(input as GetContactCampaignStatsUnsubscriptions);
        }

        /// <summary>
        /// Returns true if GetContactCampaignStatsUnsubscriptions instances are equal
        /// </summary>
        /// <param name="input">Instance of GetContactCampaignStatsUnsubscriptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetContactCampaignStatsUnsubscriptions input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UserUnsubscription == input.UserUnsubscription ||
                    this.UserUnsubscription != null &&
                    this.UserUnsubscription.SequenceEqual(input.UserUnsubscription)
                ) && 
                (
                    this.AdminUnsubscription == input.AdminUnsubscription ||
                    this.AdminUnsubscription != null &&
                    this.AdminUnsubscription.SequenceEqual(input.AdminUnsubscription)
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
                if (this.UserUnsubscription != null)
                    hashCode = hashCode * 59 + this.UserUnsubscription.GetHashCode();
                if (this.AdminUnsubscription != null)
                    hashCode = hashCode * 59 + this.AdminUnsubscription.GetHashCode();
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
