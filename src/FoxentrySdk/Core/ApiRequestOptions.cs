/**
 * Foxentry API reference
 *
 * The version of the OpenAPI document: 2.0
 * Contact: info@foxentry.com
 *
 * NOTE: This file is auto generated.
 * Do not edit the file manually.
 */
using System.Net.Http;
using System;

namespace FoxentrySdk.Core;

public class ApiRequestOptions
{
    public required HttpMethod Method { get; init; }
    public required string Path { get; init; }
    public IDictionary<string, object>? Params { get; set; }
    public IDictionary<string, object>? Cookies { get; set; }
    public IDictionary<string, string>? Headers { get; set; }
    public IDictionary<string, object>? Query { get; set; }
    public IRequestBody? Body { get; set; }
    public string? ResponseHeader { get; set; }
};
