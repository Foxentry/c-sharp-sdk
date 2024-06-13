<div align='center' class='text-center'>
  <img alt='' src='./assets/logo.webp' width='200' />
  <h1 align='center' class='text-center'>FoxentrySdk</h1>
</div>

<div align='center' class='text-center'>
  <a aria-label='Version' href='#'>
    <img alt='' src='https://img.shields.io/badge/version-1.0.1-blue' />
  </a>
  <a aria-label='License' href='https://opensource.org/licenses/MIT'>
    <img alt='' src='https://img.shields.io/badge/License-MIT-blue.svg' />
  </a>
</div>

Welcome to our FoxentrySdk. We are committed to providing you with the best SDK services experience possible. Please use our step-by-step instructions to become familiar with how to use our SDK.

- Current API version: 2.0
- Current package version: 1.0.1

## Table of Contents

- [Requirements](#requirements)
- [Installation](#installation)
- [Usage](#usage)
- [Features](#features)
- [Contributing](#contributing)
- [License](#license)
- [Contact](#contact)
- [Frequently Asked Questions (FAQ)](#frequently-asked-questions-faq)

## Requirements

- Installed .NET, stable version >= 8.0. If you do not have it installed, please refer to the [Microsoft website](https://dotnet.microsoft.com/en-us/download/dotnet/8.0).
- Foxentry.io API credentials.

## Installation

Use this command to install FoxentrySdk in your terminal.

```bash
dotnet add package FoxentrySdk
```

## Usage

In case that you successfully installed our FoxentrySdk please execute this code:

```csharp
using FoxentrySdk.Core;

internal class Program
{
    private static async Task Main(string[] args)
    {
        var config = new OpenAPIConfig();
        config.SetTokenValue("YOUR_API_KEY");
        var sdk = new FoxentrySdk.Sdk(config);

        try {
            var response = await sdk.Company.ValidateCompanyData(/* query parameters */);
            // Use response data
        } catch (ApiError e) {
            // Handle exception
        }
    }
}
```

## Features

Kindly note that every URI is relative to _https://api.foxentry.com/v2.0_.

The table displays all features categorized based on their specific purposes.

| Class                      | Method                   | HTTP request                | Description            |
| -------------------------- | ------------------------ | --------------------------- | ---------------------- |
| _FoxentrySdk.Sdk.Company_  | **ValidateCompanyData**  | **POST** /company/validate  | Validate company data  |
| _FoxentrySdk.Sdk.Company_  | **CompanySearch**        | **POST** /company/search    | Search company         |
| _FoxentrySdk.Sdk.Company_  | **GetCompanyData**       | **POST** /company/get       | Get company data       |
| _FoxentrySdk.Sdk.Email_    | **ValidateEmail**        | **POST** /email/validate    | Validate email         |
| _FoxentrySdk.Sdk.Email_    | **EmailSearch**          | **POST** /email/search      | Search email           |
| _FoxentrySdk.Sdk.Location_ | **LocationValidation**   | **POST** /location/validate | Validate location data |
| _FoxentrySdk.Sdk.Location_ | **LocationSearch**       | **POST** /location/search   | Search location        |
| _FoxentrySdk.Sdk.Location_ | **LocationGet**          | **POST** /location/get      | Get location data      |
| _FoxentrySdk.Sdk.Location_ | **LocationLocalization** | **POST** /location/localize | Localization           |
| _FoxentrySdk.Sdk.Name_     | **NameValidation**       | **POST** /name/validate     | Validate name data     |
| _FoxentrySdk.Sdk.Phone_    | **ValidatePhoneNumber**  | **POST** /phone/validate    | Validate phone number  |

## Contributing

To learn more about the possibility of contributing to the subsequent development of this SDK, please visit our [contributing page](./CONTRIBUTING.md). Kindly note that contributions are limited by a unique set of rules in order to ensure clarity.

## License

Please refer to the [license page](./LICENSE) for more information about the license type and the corresponding terms of use.

## Contact

We kindly request that you direct all questions to our support email:

- [info@foxentry.cz](mailto:info@foxentry.cz)

## Frequently Asked Questions (FAQ)
