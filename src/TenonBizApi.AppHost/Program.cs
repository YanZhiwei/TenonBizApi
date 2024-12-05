var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.TenonBizApi>("tenonbizapi");

builder.Build().Run();
