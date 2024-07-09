/**
 * Foxentry API reference
 *
 * The version of the OpenAPI document: 2.0
 * Contact: info@foxentry.com
 *
 * NOTE: This file is auto generated.
 * Do not edit the file manually.
 */
using FoxentrySdk.Models;
using FoxentrySdk.Core;
using FoxentrySdk.Services;
using System.Net.Http;
namespace FoxentrySdk;
public class Sdk
{
    public CompanyService Company { get; }
    public EmailService Email { get; }
    public LocationService Location { get; }
    public NameService Name { get; }
    public PhoneService Phone { get; }
    private readonly IHttpRequest _httpRequest;
    public Sdk() : this(new OpenAPIConfig())
    { }
    public Sdk(OpenAPIConfig config)
    {
        _httpRequest = new HttpRequest(config);
        Company = new CompanyService(_httpRequest);
        Email = new EmailService(_httpRequest);
        Location = new LocationService(_httpRequest);
        Name = new NameService(_httpRequest);
        Phone = new PhoneService(_httpRequest);
    }
}
