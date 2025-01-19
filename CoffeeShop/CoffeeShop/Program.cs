using System.Data.Common;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;

var configuration = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json")
    .Build();

configuration.GetConnectionString("DefaultCnn");


