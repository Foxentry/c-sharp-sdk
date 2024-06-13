/**
 * Foxentry API reference
 *
 * The version of the OpenAPI document: 2.0
 * Contact: info@foxentry.cz
 *
 * NOTE: This file is auto generated.
 * Do not edit the file manually.
 */
using System.Net;

namespace FoxentrySdk.Core
{
    public class ApiResponse<TValue>
    {
        public TValue? Value { get; init; } = default;
        public required HttpStatusCode Status { get; init; }
        public Dictionary<string, string>? RawHeaders { get; init; } = default;
    }
}
