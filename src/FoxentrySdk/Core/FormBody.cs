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

public class FormBody : IRequestBody
{
    private readonly IDictionary<string, object> _body;

    public FormBody(IDictionary<string, object> body)
    {
        _body = body;
    }

    public HttpContent GetHttpContent()
    {
        return new FormUrlEncodedContent(_body.Select(x => new KeyValuePair<string?, string?>(x.Key, x.Value?.ToString())));
    }
}
