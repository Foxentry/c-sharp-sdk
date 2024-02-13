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

public interface IHttpRequest
{
    Task<T> Request<T>(ApiRequestOptions options);
    Task Request(ApiRequestOptions options);
}
