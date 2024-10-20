var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.Noei_BPMS_Service>("noei-bpms-service");

builder.AddProject<Projects.Noei_BPMS_DatabaseMigration>("noei-bpms-databasemigration");

builder.Build().Run();
