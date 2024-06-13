/**
 * Foxentry API reference
 *
 * The version of the OpenAPI document: 2.0
 * Contact: info@foxentry.cz
 *
 * NOTE: This file is auto generated.
 * Do not edit the file manually.
 */
namespace FoxentrySdk.Core;

public class OpenAPIConfig
{
    public Uri BaseUrl { get; set; } = new Uri("https://api.foxentry.com");
    public string ApiVersion { get; set; } = "2.0";
    public bool WithCredentials { get; set; } = false;
    public CredentialsUsage Credentials { get; set; } = CredentialsUsage.Include;
    public Func<ApiRequestOptions, Task<string>>? Token { get; set; } = null;
    public Func<ApiRequestOptions, Task<string>>? Username { get; set; } = null;
    public Func<ApiRequestOptions, Task<string>>? Password { get; set; } = null;
    public Func<ApiRequestOptions, Task<IDictionary<string, string>>>? Headers { get; set; } = null;
    public Func<string, string>? PathEncoder { get; set; } = null;

    public void SetTokenValue(string token)
    {
        Token = (options) => Task.FromResult(token);
    }

    public void SetUsernameValue(string username)
    {
        Username = (options) => Task.FromResult(username);
    }

    public void SetPasswordValue(string password)
    {
        Password = (options) => Task.FromResult(password);
    }

    public void SetHeadersValue(IDictionary<string, string> headers)
    {
        Headers = (options) => Task.FromResult(headers);
    }

    public enum CredentialsUsage
    {
        Include,
        Omit,
        SameOrigin
    }
}
