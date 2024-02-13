/**
 * Foxentry API reference
 *
 * The version of the OpenAPI document: 2.0
 * Contact: info@foxentry.cz
 *
 * NOTE: This file is auto generated.
 * Do not edit the file manually.
 */
using System.Text.Json;
using FoxentrySdk.Core;
using FoxentrySdk.Models;
using FoxentrySdk.Services;
using RichardSzalay.MockHttp;

namespace FoxentrySdk.Tests;

public class NameServiceTests
{
    [Fact]
    public async Task NameService_NameValidation()
    {
        var token = "api_token";
        var config = new OpenAPIConfig
        {
            Token = _ => Task.FromResult(token)
        };
        var expectedResponse = new
        {
            status = 200,
            request = default(object),
            response = default(object),
            errors = default(object)
        };
        var url = config.BaseUrl + "/name/validate";

        var query = new Dictionary<string, object>();

        var parameters = new Dictionary<string, object>();

        var headers = new Dictionary<string, string> {
          { "Authorization", $"Bearer {token}" },
          { "Accept", "application/json"}
        };
        headers.Add("Foxentry-Include-Request-Details", true.ToString());
        headers.Add("Api-Version", "2.0");

        var mockHttp = new MockHttpMessageHandler();
        var mock = mockHttp.When(HttpMethod.Post, MockedHttpRequest.BuildPath(url, parameters, query))
          .Respond("application/json", JsonSerializer.Serialize(expectedResponse));

        mock.WithHeaders(headers);

        var mockedHttpRequest = new MockedHttpRequest(config, mockHttp);
        var service = new NameService(mockedHttpRequest);

        var result = await service.NameValidation(true, new() { Request = null }, "2.0");

        Assert.NotNull(result);
        Assert.Equal(JsonSerializer.Serialize(expectedResponse), JsonSerializer.Serialize(result), StringComparer.OrdinalIgnoreCase);
    }

}
