/**
 * Foxentry API reference
 *
 * The version of the OpenAPI document: 2.0
 * Contact: info@foxentry.com
 *
 * NOTE: This file is auto generated.
 * Do not edit the file manually.
 */
using System.Text;
using System.Text.Json;
using System.Net;
using FoxentrySdk.Core;
using FoxentrySdk.Models;
using FoxentrySdk.Services;
using RichardSzalay.MockHttp;

namespace FoxentrySdk.Tests;

public class LocationServiceTests
{
    [Fact]
    public async Task LocationService_LocationValidation()
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

        var url = MockedHttpRequest.JoinUrl(config.BaseUrl.ToString(), "/location/validate");

        var query = new Dictionary<string, object>();

        var parameters = new Dictionary<string, object>();

        var headers = new Dictionary<string, string> {
          { "Authorization", $"Bearer {token}" },
          { "Accept", "application/json"}
        };
        headers.Add("foxentry-include-request-details", false.ToString());

        var responseHeaders = new Dictionary<string, string> {
           { "foxentry-api-version","2.0" },
           { "foxentry-daily-credits-left","9881.64" },
           { "foxentry-daily-credits-limit","10000" },
           { "foxentry-rate-limit","5000" },
           { "foxentry-rate-limit-period","900" },
           { "foxentry-rate-limit-remaining","4999" },
        };

        var mockHttp = new MockHttpMessageHandler();
        var mock = mockHttp.When(HttpMethod.Post, MockedHttpRequest.BuildPath(url, parameters, query))
          .Respond(HttpStatusCode.OK, responseHeaders, new StringContent(JsonSerializer.Serialize(expectedResponse), Encoding.UTF8, "application/json"));

        mock.WithHeaders(headers);

        var mockedHttpRequest = new MockedHttpRequest(config, mockHttp);
        var service = new LocationService(mockedHttpRequest);

        var result = await service.LocationValidation(new() { Request = null }, false);

        Assert.NotNull(result.Value);
        Assert.Equal(JsonSerializer.Serialize(expectedResponse), JsonSerializer.Serialize(result.Value), StringComparer.OrdinalIgnoreCase);
        Assert.Equal("2.0", result.Headers.FoxentryApiVersion);
        Assert.Equal(9881.64, result.Headers.FoxentryDailyCreditsLeft);
        Assert.Equal(10000, result.Headers.FoxentryDailyCreditsLimit);
        Assert.Equal(5000, result.Headers.FoxentryRateLimit);
        Assert.Equal(900, result.Headers.FoxentryRateLimitPeriod);
        Assert.Equal(4999, result.Headers.FoxentryRateLimitRemaining);
    }

    [Fact]
    public async Task LocationService_LocationSearch()
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

        var url = MockedHttpRequest.JoinUrl(config.BaseUrl.ToString(), "/location/search");

        var query = new Dictionary<string, object>();

        var parameters = new Dictionary<string, object>();

        var headers = new Dictionary<string, string> {
          { "Authorization", $"Bearer {token}" },
          { "Accept", "application/json"}
        };
        headers.Add("foxentry-include-request-details", false.ToString());

        var responseHeaders = new Dictionary<string, string> {
           { "foxentry-api-version","2.0" },
           { "foxentry-daily-credits-left","9881.64" },
           { "foxentry-daily-credits-limit","10000" },
           { "foxentry-rate-limit","5000" },
           { "foxentry-rate-limit-period","900" },
           { "foxentry-rate-limit-remaining","4999" },
        };

        var mockHttp = new MockHttpMessageHandler();
        var mock = mockHttp.When(HttpMethod.Post, MockedHttpRequest.BuildPath(url, parameters, query))
          .Respond(HttpStatusCode.OK, responseHeaders, new StringContent(JsonSerializer.Serialize(expectedResponse), Encoding.UTF8, "application/json"));

        mock.WithHeaders(headers);

        var mockedHttpRequest = new MockedHttpRequest(config, mockHttp);
        var service = new LocationService(mockedHttpRequest);

        var result = await service.LocationSearch(new() { Request = null }, false);

        Assert.NotNull(result.Value);
        Assert.Equal(JsonSerializer.Serialize(expectedResponse), JsonSerializer.Serialize(result.Value), StringComparer.OrdinalIgnoreCase);
        Assert.Equal("2.0", result.Headers.FoxentryApiVersion);
        Assert.Equal(9881.64, result.Headers.FoxentryDailyCreditsLeft);
        Assert.Equal(10000, result.Headers.FoxentryDailyCreditsLimit);
        Assert.Equal(5000, result.Headers.FoxentryRateLimit);
        Assert.Equal(900, result.Headers.FoxentryRateLimitPeriod);
        Assert.Equal(4999, result.Headers.FoxentryRateLimitRemaining);
    }

    [Fact]
    public async Task LocationService_LocationGet()
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

        var url = MockedHttpRequest.JoinUrl(config.BaseUrl.ToString(), "/location/get");

        var query = new Dictionary<string, object>();

        var parameters = new Dictionary<string, object>();

        var headers = new Dictionary<string, string> {
          { "Authorization", $"Bearer {token}" },
          { "Accept", "application/json"}
        };
        headers.Add("foxentry-include-request-details", false.ToString());

        var responseHeaders = new Dictionary<string, string> {
           { "foxentry-api-version","2.0" },
           { "foxentry-daily-credits-left","9881.64" },
           { "foxentry-daily-credits-limit","10000" },
           { "foxentry-rate-limit","5000" },
           { "foxentry-rate-limit-period","900" },
           { "foxentry-rate-limit-remaining","4999" },
        };

        var mockHttp = new MockHttpMessageHandler();
        var mock = mockHttp.When(HttpMethod.Post, MockedHttpRequest.BuildPath(url, parameters, query))
          .Respond(HttpStatusCode.OK, responseHeaders, new StringContent(JsonSerializer.Serialize(expectedResponse), Encoding.UTF8, "application/json"));

        mock.WithHeaders(headers);

        var mockedHttpRequest = new MockedHttpRequest(config, mockHttp);
        var service = new LocationService(mockedHttpRequest);

        var result = await service.LocationGet(new() { Request = null }, false);

        Assert.NotNull(result.Value);
        Assert.Equal(JsonSerializer.Serialize(expectedResponse), JsonSerializer.Serialize(result.Value), StringComparer.OrdinalIgnoreCase);
        Assert.Equal("2.0", result.Headers.FoxentryApiVersion);
        Assert.Equal(9881.64, result.Headers.FoxentryDailyCreditsLeft);
        Assert.Equal(10000, result.Headers.FoxentryDailyCreditsLimit);
        Assert.Equal(5000, result.Headers.FoxentryRateLimit);
        Assert.Equal(900, result.Headers.FoxentryRateLimitPeriod);
        Assert.Equal(4999, result.Headers.FoxentryRateLimitRemaining);
    }

    [Fact]
    public async Task LocationService_LocationLocalization()
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

        var url = MockedHttpRequest.JoinUrl(config.BaseUrl.ToString(), "/location/localize");

        var query = new Dictionary<string, object>();

        var parameters = new Dictionary<string, object>();

        var headers = new Dictionary<string, string> {
          { "Authorization", $"Bearer {token}" },
          { "Accept", "application/json"}
        };
        headers.Add("foxentry-include-request-details", false.ToString());

        var responseHeaders = new Dictionary<string, string> {
           { "foxentry-api-version","2.0" },
           { "foxentry-daily-credits-left","9881.64" },
           { "foxentry-daily-credits-limit","10000" },
           { "foxentry-rate-limit","5000" },
           { "foxentry-rate-limit-period","900" },
           { "foxentry-rate-limit-remaining","4999" },
        };

        var mockHttp = new MockHttpMessageHandler();
        var mock = mockHttp.When(HttpMethod.Post, MockedHttpRequest.BuildPath(url, parameters, query))
          .Respond(HttpStatusCode.OK, responseHeaders, new StringContent(JsonSerializer.Serialize(expectedResponse), Encoding.UTF8, "application/json"));

        mock.WithHeaders(headers);

        var mockedHttpRequest = new MockedHttpRequest(config, mockHttp);
        var service = new LocationService(mockedHttpRequest);

        var result = await service.LocationLocalization(new() { Request = null }, false);

        Assert.NotNull(result.Value);
        Assert.Equal(JsonSerializer.Serialize(expectedResponse), JsonSerializer.Serialize(result.Value), StringComparer.OrdinalIgnoreCase);
        Assert.Equal("2.0", result.Headers.FoxentryApiVersion);
        Assert.Equal(9881.64, result.Headers.FoxentryDailyCreditsLeft);
        Assert.Equal(10000, result.Headers.FoxentryDailyCreditsLimit);
        Assert.Equal(5000, result.Headers.FoxentryRateLimit);
        Assert.Equal(900, result.Headers.FoxentryRateLimitPeriod);
        Assert.Equal(4999, result.Headers.FoxentryRateLimitRemaining);
    }

}
