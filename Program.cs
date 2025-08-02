using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();
builder.Services.ConfigureHttpJsonOptions(opt =>
{
    // Comment the below line and the schema is generated correctly
    // opt.SerializerOptions.Converters.Add(new CreateChannelRequestConverter());
});

var app = builder.Build();

app.MapOpenApi();
app.MapPost("/channels", ([FromBody]CreateChannelRequest req) => "Hello World!");

app.Run();