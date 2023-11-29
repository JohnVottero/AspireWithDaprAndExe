# .NET Aspire dapr sample app with Executable

This is a clone of the AspireWithDapr sample with minor changes:

- Update NuGet Packages
- A change in AspireWithDapr.AppHost Program.cs to use AddExecutable for the APIService.

Imagine the APIService is managed by a different group and they don't
want to share the source code. They just want us (the WebFrontEnd group)
to use their executable.

Simple, instead of calling AddProject, we call AddExecutable but, even though we added
.WithDapSidecar, the APIService Dapr Sidecar is not started and we can't call the API.

## Demonstrates

- A problem using WithDaprSidecar with AddExecutable.

## Sample prerequisites

This sample is written in C# and targets .NET 8.0. It requires the [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) or later.

## Building the sample

To download and run the sample, follow these steps:

1. Download and unzip the sample.
2. In Visual Studio (2022 or later):
    1. On the menu bar, choose **File** > **Open** > **Project/Solution**.
    2. Navigate to the folder that holds the unzipped sample code, and open the solution (.sln) file.
    3. Right click the _AspireWithDapr.AppHost_ project in the solution explore and choose it as the startup project.
    4. Choose the <kbd>F5</kbd> key to run with debugging, or <kbd>Ctrl</kbd>+<kbd>F5</kbd> keys to run the project without debugging.
3. From the command line:
   1. Navigate to the folder that holds the unzipped sample code.
   2. At the command line, type [`dotnet run`](https://docs.microsoft.com/dotnet/core/tools/dotnet-run).

To run the game, run the .NET Aspire app by executing the following at the command prompt (opened to the base directory of the sample):

``` bash
dotnet run --project AspireWithDapr.AppHost
```

1. On the **Projects** page, click on one of the endpoints for the listed project. This launches the simple .NET app.
2. In the .NET app:
  1. Visit the **Weather**.

For more information about using dapr, see the [Dapr documentation](https://docs.dapr.io/developing-applications/sdks/dotnet/).
