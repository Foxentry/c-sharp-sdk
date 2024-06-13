/**
 * Foxentry API reference
 *
 * The version of the OpenAPI document: 2.0
 * Contact: info@foxentry.cz
 *
 * NOTE: This file is auto generated.
 * Do not edit the file manually.
 */
using System.Text.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Schema.Generation;

namespace FoxentrySdk.Core;

public static class JsonHelpers
{
    public static JObject ParseUtf8JsonReader(ref Utf8JsonReader reader)
    {
        using var jsonDocument = JsonDocument.ParseValue(ref reader);
        string jsonString = jsonDocument.RootElement.GetRawText();

        return JObject.Parse(jsonString);
    }

    public static JSchema GetJsonSchema(this Type type) => new JSchemaGenerator().Generate(type);
}
