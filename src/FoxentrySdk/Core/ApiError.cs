/**
 * Foxentry API reference
 *
 * The version of the OpenAPI document: 2.0
 * Contact: info@foxentry.com
 *
 * NOTE: This file is auto generated.
 * Do not edit the file manually.
 */
using System.Net;

namespace FoxentrySdk.Core;

public class ApiError : Exception
{
    public required string Url { get; init; }
    public required HttpStatusCode Status { get; init; }
    public string? StatusText { get; set; }
    public required object? Body { get; init; }
    public required ApiRequestOptions Request { get; init; }
}
