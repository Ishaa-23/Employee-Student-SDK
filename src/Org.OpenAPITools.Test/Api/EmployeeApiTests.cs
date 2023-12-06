/*
 * Combined API
 *
 * Endpoints of CRUD of employee and displaying results of student.
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Org.OpenAPITools.Client;
using Org.OpenAPITools.Api;
// uncomment below to import models
//using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Test.Api
{
    /// <summary>
    ///  Class for testing EmployeeApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class EmployeeApiTests : IDisposable
    {
        private EmployeeApi instance;

        public EmployeeApiTests()
        {
            instance = new EmployeeApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of EmployeeApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' EmployeeApi
            //Assert.IsType<EmployeeApi>(instance);
        }

        /// <summary>
        /// Test ApiEmployeeGet
        /// </summary>
        [Fact]
        public void ApiEmployeeGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ApiEmployeeGet();
            //Assert.IsType<List<Employee>>(response);
        }

        /// <summary>
        /// Test ApiEmployeeIdDelete
        /// </summary>
        [Fact]
        public void ApiEmployeeIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //var response = instance.ApiEmployeeIdDelete(id);
            //Assert.IsType<List<Employee>>(response);
        }

        /// <summary>
        /// Test ApiEmployeeIdGet
        /// </summary>
        [Fact]
        public void ApiEmployeeIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //var response = instance.ApiEmployeeIdGet(id);
            //Assert.IsType<List<Employee>>(response);
        }

        /// <summary>
        /// Test ApiEmployeeIdPut
        /// </summary>
        [Fact]
        public void ApiEmployeeIdPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //List<Employee>? employee = null;
            //var response = instance.ApiEmployeeIdPut(id, employee);
            //Assert.IsType<List<Employee>>(response);
        }

        /// <summary>
        /// Test ApiEmployeePost
        /// </summary>
        [Fact]
        public void ApiEmployeePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Employee? employee = null;
            //var response = instance.ApiEmployeePost(employee);
            //Assert.IsType<List<Employee>>(response);
        }
    }
}
