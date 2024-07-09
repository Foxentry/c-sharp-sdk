/**
 * Foxentry API reference
 *
 * The version of the OpenAPI document: 2.0
 * Contact: info@foxentry.com
 *
 * NOTE: This file is auto generated.
 * Do not edit the file manually.
 */
using System.Text.Json.Serialization;

namespace FoxentrySdk.Core;

[AttributeUsage(AttributeTargets.Interface, AllowMultiple = false)]
public class JsonInterfaceConverterAttribute : JsonConverterAttribute
{
    public JsonInterfaceConverterAttribute(Type converterType)
        : base(converterType)
    {
    }
}
