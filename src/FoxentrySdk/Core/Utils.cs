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
using System.Globalization;

namespace FoxentrySdk.Core;

public static class Utils
{
    public static double ParseDouble(string? value)
    {
        string decimalSeparator = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
        string parsed = value;
        if (decimalSeparator == ".")
        {
            parsed = value.Replace(",", ".");
        }
        else if (decimalSeparator == ",")
        {
            parsed = value.Replace(".", ",");
        }

        return double.TryParse(parsed, NumberStyles.Any, CultureInfo.CurrentCulture, out double result) ? result : default;
    }
}
