using Gateway.Service;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHttpClient(WellKnownSchemaNames.Entitlements, c => c.BaseAddress = new Uri("http://localhost:5098/graphql"));
builder.Services.AddHttpClient(WellKnownSchemaNames.Products, c => c.BaseAddress = new Uri("http://localhost:5008/graphql"));

builder.Services
    .AddGraphQLServer()
    .AddType<UnsignedLongType>()
    .AddRemoteSchema(WellKnownSchemaNames.Entitlements)
    .AddRemoteSchema(WellKnownSchemaNames.Products);

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();
app.MapGraphQL();

app.Run();
