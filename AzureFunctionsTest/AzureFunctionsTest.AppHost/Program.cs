using Aspire.Hosting.Azure;
using Azure.Provisioning.Storage;

var builder = DistributedApplication.CreateBuilder(args);

var messaging = builder.AddConnectionString("Messaging");
var externalApi = builder.AddConnectionString("ExternalApi");
var externalApi2 = builder.AddConnectionString("ExternalApi2");


builder.AddAzureFunctionsProject<Projects.AzureFunctionsTest_Functions>("funcapp")
    .WithReference(messaging)
    //.WithReference(externalApi) Same problem
//    .WithReference(externalApi2) Same problem
    .WithEnvironment("ConnectionStrings__ExternalApi", externalApi)
    .WithEnvironment("ConnectionStrings__ExternalApi2", externalApi2);

builder.Build().Run();