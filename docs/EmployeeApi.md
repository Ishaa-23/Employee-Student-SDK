# Org.OpenAPITools.Api.EmployeeApi

All URIs are relative to *http://localhost:5283*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiEmployeeIdDelete**](EmployeeApi.md#apiemployeeiddelete) | **DELETE** /api/Employee/{id} |  |
| [**ApiEmployeeIdGet**](EmployeeApi.md#apiemployeeidget) | **GET** /api/Employee/{id} | Returns employee of given id |
| [**ApiEmployeeIdPut**](EmployeeApi.md#apiemployeeidput) | **PUT** /api/Employee/{id} | Updates employee details |
| [**ApiEmployeePost**](EmployeeApi.md#apiemployeepost) | **POST** /api/Employee | Adds new employee |

<a id="apiemployeeiddelete"></a>
# **ApiEmployeeIdDelete**
> List&lt;Employee&gt; ApiEmployeeIdDelete (int id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiEmployeeIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:5283";
            var apiInstance = new EmployeeApi(config);
            var id = 56;  // int | 

            try
            {
                List<Employee> result = apiInstance.ApiEmployeeIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmployeeApi.ApiEmployeeIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiEmployeeIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<Employee>> response = apiInstance.ApiEmployeeIdDeleteWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmployeeApi.ApiEmployeeIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |

### Return type

[**List&lt;Employee&gt;**](Employee.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiemployeeidget"></a>
# **ApiEmployeeIdGet**
> List&lt;Employee&gt; ApiEmployeeIdGet (int id)

Returns employee of given id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiEmployeeIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:5283";
            var apiInstance = new EmployeeApi(config);
            var id = 56;  // int | 

            try
            {
                // Returns employee of given id
                List<Employee> result = apiInstance.ApiEmployeeIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmployeeApi.ApiEmployeeIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiEmployeeIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns employee of given id
    ApiResponse<List<Employee>> response = apiInstance.ApiEmployeeIdGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmployeeApi.ApiEmployeeIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |

### Return type

[**List&lt;Employee&gt;**](Employee.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiemployeeidput"></a>
# **ApiEmployeeIdPut**
> List&lt;Employee&gt; ApiEmployeeIdPut (int id, List<Employee>? employee = null)

Updates employee details

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiEmployeeIdPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:5283";
            var apiInstance = new EmployeeApi(config);
            var id = 56;  // int | 
            var employee = new List<Employee>?(); // List<Employee>? |  (optional) 

            try
            {
                // Updates employee details
                List<Employee> result = apiInstance.ApiEmployeeIdPut(id, employee);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmployeeApi.ApiEmployeeIdPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiEmployeeIdPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates employee details
    ApiResponse<List<Employee>> response = apiInstance.ApiEmployeeIdPutWithHttpInfo(id, employee);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmployeeApi.ApiEmployeeIdPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |
| **employee** | [**List&lt;Employee&gt;?**](Employee.md) |  | [optional]  |

### Return type

[**List&lt;Employee&gt;**](Employee.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: text/plain, application/json, text/json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiemployeepost"></a>
# **ApiEmployeePost**
> List&lt;Employee&gt; ApiEmployeePost (Employee? employee = null)

Adds new employee

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiEmployeePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:5283";
            var apiInstance = new EmployeeApi(config);
            var employee = new Employee?(); // Employee? |  (optional) 

            try
            {
                // Adds new employee
                List<Employee> result = apiInstance.ApiEmployeePost(employee);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmployeeApi.ApiEmployeePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiEmployeePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Adds new employee
    ApiResponse<List<Employee>> response = apiInstance.ApiEmployeePostWithHttpInfo(employee);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmployeeApi.ApiEmployeePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **employee** | [**Employee?**](Employee?.md) |  | [optional]  |

### Return type

[**List&lt;Employee&gt;**](Employee.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

