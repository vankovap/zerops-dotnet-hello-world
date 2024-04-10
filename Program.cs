using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();
app.Urls.Add("http://0.0.0.0:5000");
app.MapGet("/", () => "Hello World!");
app.Run();
