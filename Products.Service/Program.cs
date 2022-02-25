using ProductReviews.Service;
using Products.Service;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IProductContractService, ProductContractService>();

builder.Services.AddGraphQLServer()
    .AddType<UnsignedLongType>()
    .AddQueryType<Query>()
    .AddFiltering()
    .PublishSchemaDefinition(c => c
        .SetName("products"));

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();
app.MapGraphQL();

app.Run();
