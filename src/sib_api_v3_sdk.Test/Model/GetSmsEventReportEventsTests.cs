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
    ///  Class for testing GetSmsEventReportEvents
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class GetSmsEventReportEventsTests
    {
        // TODO uncomment below to declare an instance variable for GetSmsEventReportEvents
        //private GetSmsEventReportEvents instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of GetSmsEventReportEvents
            //instance = new GetSmsEventReportEvents();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of GetSmsEventReportEvents
        /// </summary>
        [Test]
        public void GetSmsEventReportEventsInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" GetSmsEventReportEvents
            //Assert.IsInstanceOfType<GetSmsEventReportEvents> (instance, "variable 'instance' is a GetSmsEventReportEvents");
        }


        /// <summary>
        /// Test the property 'PhoneNumber'
        /// </summary>
        [Test]
        public void PhoneNumberTest()
        {
            // TODO unit test for the property 'PhoneNumber'
        }
        /// <summary>
        /// Test the property 'Date'
        /// </summary>
        [Test]
        public void DateTest()
        {
            // TODO unit test for the property 'Date'
        }
        /// <summary>
        /// Test the property 'MessageId'
        /// </summary>
        [Test]
        public void MessageIdTest()
        {
            // TODO unit test for the property 'MessageId'
        }
        /// <summary>
        /// Test the property 'Event'
        /// </summary>
        [Test]
        public void EventTest()
        {
            // TODO unit test for the property 'Event'
        }
        /// <summary>
        /// Test the property 'Reason'
        /// </summary>
        [Test]
        public void ReasonTest()
        {
            // TODO unit test for the property 'Reason'
        }
        /// <summary>
        /// Test the property 'Reply'
        /// </summary>
        [Test]
        public void ReplyTest()
        {
            // TODO unit test for the property 'Reply'
        }
        /// <summary>
        /// Test the property 'Tag'
        /// </summary>
        [Test]
        public void TagTest()
        {
            // TODO unit test for the property 'Tag'
        }

    }

}
