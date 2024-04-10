using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();
app.Urls.Add("http://0.0.0.0:5000");
app.MapGet("/", () => Results.Ok("Hello World!"));
app.Run();
