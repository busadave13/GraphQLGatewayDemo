using Entitlements.Service;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IEntitlementService, EntitlementService>();

builder.Services.AddGraphQLServer()
    .AddQueryType<QueryType>()
    .AddFiltering()
    .PublishSchemaDefinition(c => c
        .SetName("entitlements"));

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();
app.MapGraphQL();

app.Run();
