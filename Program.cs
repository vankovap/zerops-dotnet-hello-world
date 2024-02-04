using Microsoft.AspNetCore.Builder;

namespace HelloWorld;

static class Program
{
    static void Main(string[] args)
    {
	var builder = WebApplication.CreateBuilder(args);

	var app = builder.Build();
	app.Urls.Add("http://0.0.0.0:5000");
	app.MapGet("/", () => "Hello World!");
	app.Run();
    }
}
