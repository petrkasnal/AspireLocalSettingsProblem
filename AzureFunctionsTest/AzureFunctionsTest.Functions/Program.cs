using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Azure.Functions.Worker.Builder;
using Microsoft.Extensions.Configuration;

var builder = FunctionsApplication.CreateBuilder(args);

builder.AddServiceDefaults();

var value = builder.Configuration.GetConnectionString("Messaging");
var myExternalApi = builder.Configuration.GetConnectionString("ExternalApi");
var myExternalApi2 = builder.Configuration.GetConnectionString("ExternalApi2");


var host = builder.Build();

host.Run();
