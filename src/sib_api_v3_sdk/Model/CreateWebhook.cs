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
    /// CreateWebhook
    /// </summary>
    [DataContract]
    public partial class CreateWebhook :  IEquatable<CreateWebhook>, IValidatableObject
    {
        /// <summary>
        /// Defines Events
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EventsEnum
        {
            
            /// <summary>
            /// Enum HardBounce for value: hardBounce
            /// </summary>
            [EnumMember(Value = "hardBounce")]
            HardBounce = 1,
            
            /// <summary>
            /// Enum SoftBounce for value: softBounce
            /// </summary>
            [EnumMember(Value = "softBounce")]
            SoftBounce = 2,
            
            /// <summary>
            /// Enum Blocked for value: blocked
            /// </summary>
            [EnumMember(Value = "blocked")]
            Blocked = 3,
            
            /// <summary>
            /// Enum Spam for value: spam
            /// </summary>
            [EnumMember(Value = "spam")]
            Spam = 4,
            
            /// <summary>
            /// Enum Delivered for value: delivered
            /// </summary>
            [EnumMember(Value = "delivered")]
            Delivered = 5,
            
            /// <summary>
            /// Enum Request for value: request
            /// </summary>
            [EnumMember(Value = "request")]
            Request = 6,
            
            /// <summary>
            /// Enum Click for value: click
            /// </summary>
            [EnumMember(Value = "click")]
            Click = 7,
            
            /// <summary>
            /// Enum Invalid for value: invalid
            /// </summary>
            [EnumMember(Value = "invalid")]
            Invalid = 8,
            
            /// <summary>
            /// Enum Deferred for value: deferred
            /// </summary>
            [EnumMember(Value = "deferred")]
            Deferred = 9,
            
            /// <summary>
            /// Enum Opened for value: opened
            /// </summary>
            [EnumMember(Value = "opened")]
            Opened = 10,
            
            /// <summary>
            /// Enum UniqueOpened for value: uniqueOpened
            /// </summary>
            [EnumMember(Value = "uniqueOpened")]
            UniqueOpened = 11,
            
            /// <summary>
            /// Enum Unsubscribed for value: unsubscribed
            /// </summary>
            [EnumMember(Value = "unsubscribed")]
            Unsubscribed = 12,
            
            /// <summary>
            /// Enum ListAddition for value: listAddition
            /// </summary>
            [EnumMember(Value = "listAddition")]
            ListAddition = 13
        }


        /// <summary>
        /// Events triggering the webhook. Possible values for Transactional type webhook – request, delivered, hardBounce, softBounce, blocked, spam, invalid, deferred, click, opened, uniqueOpened and unsubscribed and possible values for Marketing type webhook – spam, opened, click, hardBounce, softBounce, unsubscribed, listAddition &amp; delivered
        /// </summary>
        /// <value>Events triggering the webhook. Possible values for Transactional type webhook – request, delivered, hardBounce, softBounce, blocked, spam, invalid, deferred, click, opened, uniqueOpened and unsubscribed and possible values for Marketing type webhook – spam, opened, click, hardBounce, softBounce, unsubscribed, listAddition &amp; delivered</value>
        [DataMember(Name="events", EmitDefaultValue=false)]
        public List<EventsEnum> Events { get; set; }
        /// <summary>
        /// Type of the webhook
        /// </summary>
        /// <value>Type of the webhook</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Transactional for value: transactional
            /// </summary>
            [EnumMember(Value = "transactional")]
            Transactional = 1,
            
            /// <summary>
            /// Enum Marketing for value: marketing
            /// </summary>
            [EnumMember(Value = "marketing")]
            Marketing = 2
        }

        /// <summary>
        /// Type of the webhook
        /// </summary>
        /// <value>Type of the webhook</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWebhook" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateWebhook() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWebhook" /> class.
        /// </summary>
        /// <param name="url">URL of the webhook (required).</param>
        /// <param name="description">Description of the webhook.</param>
        /// <param name="events">Events triggering the webhook. Possible values for Transactional type webhook – request, delivered, hardBounce, softBounce, blocked, spam, invalid, deferred, click, opened, uniqueOpened and unsubscribed and possible values for Marketing type webhook – spam, opened, click, hardBounce, softBounce, unsubscribed, listAddition &amp; delivered (required).</param>
        /// <param name="type">Type of the webhook (default to TypeEnum.Transactional).</param>
        public CreateWebhook(string url = default(string), string description = default(string), List<EventsEnum> events = default(List<EventsEnum>), TypeEnum? type = TypeEnum.Transactional)
        {
            // to ensure "url" is required (not null)
            if (url == null)
            {
                throw new InvalidDataException("url is a required property for CreateWebhook and cannot be null");
            }
            else
            {
                this.Url = url;
            }
            // to ensure "events" is required (not null)
            if (events == null)
            {
                throw new InvalidDataException("events is a required property for CreateWebhook and cannot be null");
            }
            else
            {
                this.Events = events;
            }
            this.Description = description;
            // use default value if no "type" provided
            if (type == null)
            {
                this.Type = TypeEnum.Transactional;
            }
            else
            {
                this.Type = type;
            }
        }
        
        /// <summary>
        /// URL of the webhook
        /// </summary>
        /// <value>URL of the webhook</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }

        /// <summary>
        /// Description of the webhook
        /// </summary>
        /// <value>Description of the webhook</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateWebhook {\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Events: ").Append(Events).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as CreateWebhook);
        }

        /// <summary>
        /// Returns true if CreateWebhook instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateWebhook to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateWebhook input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Events == input.Events ||
                    this.Events != null &&
                    this.Events.SequenceEqual(input.Events)
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Events != null)
                    hashCode = hashCode * 59 + this.Events.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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
