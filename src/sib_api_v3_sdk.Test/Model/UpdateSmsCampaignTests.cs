/* 
 * SendinBlue API
 *
 * SendinBlue provide a RESTFul API that can be used with any languages. With this API, you will be able to :   - Manage your campaigns and get the statistics   - Manage your contacts   - Send transactional Emails and SMS   - and much more...  You can download our wrappers at https://github.com/orgs/sendinblue  **Possible responses**   | Code | Message |   | :- -- -- -- -- -- --: | - -- -- -- -- -- -- |   | 200  | OK. Successful Request  |   | 201  | OK. Successful Creation |   | 202  | OK. Request accepted |   | 204  | OK. Successful Update/Deletion  |   | 400  | Error. Bad Request  |   | 401  | Error. Authentication Needed  |   | 402  | Error. Not enough credit, plan upgrade needed  |   | 403  | Error. Permission denied  |   | 404  | Error. Object does not exist |   | 405  | Error. Method not allowed  | 
 *
 * OpenAPI spec version: 3.0.0
 * Contact: contact@sendinblue.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Model;
using sib_api_v3_sdk.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace sib_api_v3_sdk.Test
{
    /// <summary>
    ///  Class for testing UpdateSmsCampaign
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class UpdateSmsCampaignTests
    {
        // TODO uncomment below to declare an instance variable for UpdateSmsCampaign
        //private UpdateSmsCampaign instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of UpdateSmsCampaign
            //instance = new UpdateSmsCampaign();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of UpdateSmsCampaign
        /// </summary>
        [Test]
        public void UpdateSmsCampaignInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" UpdateSmsCampaign
            //Assert.IsInstanceOfType<UpdateSmsCampaign> (instance, "variable 'instance' is a UpdateSmsCampaign");
        }


        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Test]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }
        /// <summary>
        /// Test the property 'Sender'
        /// </summary>
        [Test]
        public void SenderTest()
        {
            // TODO unit test for the property 'Sender'
        }
        /// <summary>
        /// Test the property 'Content'
        /// </summary>
        [Test]
        public void ContentTest()
        {
            // TODO unit test for the property 'Content'
        }
        /// <summary>
        /// Test the property 'Recipients'
        /// </summary>
        [Test]
        public void RecipientsTest()
        {
            // TODO unit test for the property 'Recipients'
        }
        /// <summary>
        /// Test the property 'ScheduledAt'
        /// </summary>
        [Test]
        public void ScheduledAtTest()
        {
            // TODO unit test for the property 'ScheduledAt'
        }

    }

}
