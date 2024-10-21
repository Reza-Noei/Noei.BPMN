var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.Noei_BPMS_DatabaseMigration>("noei-bpms-databasemigration");

builder.AddProject<Projects.Noei_BPMS_Web_Server>("noei-bpms-web-server");

builder.Build().Run();
