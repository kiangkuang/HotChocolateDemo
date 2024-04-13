using HotChocolateDemo.Types;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>()
    .AddCacheControl()
    .ModifyCacheControlOptions(o => o.DefaultMaxAge = 20_000)
    .UseQueryCachePipeline();

var app = builder.Build();

app.MapGraphQL();

app.Run();
