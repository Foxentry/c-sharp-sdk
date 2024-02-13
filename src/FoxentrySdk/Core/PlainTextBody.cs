/**
 * Foxentry API reference
 *
 * The version of the OpenAPI document: 2.0
 * Contact: info@foxentry.cz
 *
 * NOTE: This file is auto generated.
 * Do not edit the file manually.
 */
using System.Net.Mime;
using System.Text;
using System.Net;

namespace FoxentrySdk.Core;

public class PlainTextBody : IRequestBody
{
    private readonly string _body;

    public PlainTextBody(string body)
    {
        _body = body;
    }

    public HttpContent GetHttpContent()
    {
        return new StringContent(
          _body,
          Encoding.UTF8,
          MediaTypeNames.Text.Plain
        );
    }
}
