# aspire-mongodb-sample
ASP.NET Core 8.0 Aspire MongoDB

In this article, you learn how to use the .NET Aspire MongoDB database integration. The Aspire.MongoDB.Driver library:

* Registers a IMongoClient in the DI container for connecting to a MongoDB database.
* Automatically configures the following:
    * Health checks, logging and telemetry to improve app monitoring and diagnostics
* It supports both a local MongoDB Database and a MongoDB Atlas database deployed in the cloud.

## Get started
To get started with the .NET Aspire MongoDB database integration, install the Aspire.MongoDB.Driver NuGet package in the client-consuming project, i.e., the project for the application that uses the MongoDB database client.
```sh
dotnet add package Aspire.MongoDB.Driver
```

## App host usage
To model the MongoDB resource in the app host, install the Aspire.Hosting.MongoDB NuGet package in the app host project.
```sh
dotnet add package Aspire.Hosting.MongoDB
```