var builder = DistributedApplication.CreateBuilder(args);
builder.AddProject<Projects.FRWP_APIGateWay>("frwp-api-gateway");
builder.AddProject<Projects.FRWP_Web>("frwp-web");
builder.AddProject<Projects.FRWP_Infrastructure>("frwp-infrastructure");
builder.Build().Run();