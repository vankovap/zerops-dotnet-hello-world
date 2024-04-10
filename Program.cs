using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();
app.MapGet("/", () => Results.Ok("Hello World!"));
app.Run();
