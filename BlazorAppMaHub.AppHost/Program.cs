var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.BlazorAppMaHub>("blazorappmahub");

builder.Build().Run();
