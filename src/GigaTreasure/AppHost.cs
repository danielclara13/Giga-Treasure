var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.GigaTreasure_Api>("GigaTreasure-Api");

builder.Build().Run();