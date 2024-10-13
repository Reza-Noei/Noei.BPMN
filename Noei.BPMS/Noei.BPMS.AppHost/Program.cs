var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.Noei_BPMS_ApiService>("apiservice");

builder.Build().Run();
