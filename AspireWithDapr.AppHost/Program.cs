var builder = DistributedApplication.CreateBuilder(args);

builder.AddDapr();

//
//  Imagine the APIService is managed by a different group and they don't
//  want to share the source code. They just want us (the WebFrontEnd group)
//  to use their executable. 
//
//  Simple, instead of calling AddProject, we call AddExecutable but, even though we added
//  .WithDapSidecar, the APIService Dapr Sidecar is not started and we can't call the API.
//
//  So, instead of doing this (as in the original AspWithDapr sample):
//
//builder.AddProject<Projects.AspireWithDapr_ApiService>("apiservice")
//       .WithDaprSidecar("api");
//
//  we do:
//
var apiServiceCommand = Path.GetFullPath("../AspireWithDapr.ApiService/bin/Debug/net8.0/AspireWithDapr.ApiService.exe");
var apiServiceWorkingDirectory = Path.GetFullPath("../AspireWithDapr.ApiService/bin/Debug/net8.0/");
builder.AddExecutable("apiservice", apiServiceCommand, apiServiceWorkingDirectory, [])
       .WithDaprSidecar("api");

// End of changes

builder.AddProject<Projects.AspireWithDapr_Web>("webfrontend")
       .WithDaprSidecar("web");

builder.Build().Run();
