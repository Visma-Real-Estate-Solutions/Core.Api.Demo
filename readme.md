# ReadMe

## About
This is a demo application for third party integrators seeking to integrate with Flow, the Core API.
It is a simple console application that intends to point third-party integrators in the right direction when
implementing API requests to ensure correct usage and a smooth integration experience. In this
application, you can find best practices, as well as lots of request examples for communication with Flow.

This application was built in:  <br />
.NET 8.0  <br />
C# 12.0

This application is meant to be used in conjunction with the Flow API documentation and the Swagger UI. <br />
https://visma-real-estate-solutions.github.io/core-documentation/
https://integration.webtopsolutions.com/flow/swagger/index.html

The classes in the Client folder correspond to the different API sections in Swagger. The same goes for models in the Models folder.

## Disclaimer
- This is not an end-all be-all guide, rather an example application intended to show you how to properly interact with the Flow API as a third-party integrator.
- Endpoints and their respective properties might change over time.

## Getting started

### Prerequisites
1. Clone the repository
2. Open the solution in Visual Studio, JetBrains Rider or any other IDE that supports .NET 8.0
    - 2.1. Make sure you have .NET 8.0 SDK installed

### How to run
* You need an API user
    * Contact support.realestate@visma.com
    * Insert your API user credentials in the `appsettings.json` file.
      * Host
      * client_id
      * client_secret

### Running the application
* Set the CoreDemoApi project as the startup project
* Uncomment line 18 in CoreApiDemo, in the `Run()` method, providing a valid case Id. (66115 is tested only for the integration environment)
* Run the application

## Best practices
See Program.cs for best practices on how to implement authorization, retry policies and how to avoid throttling.
