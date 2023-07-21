var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.MapGet("/status", () => "OK");
app.Run();

// Required for our Program class to be visible from our test projects.
// We could do this with InternalsVisibleTo, but that doesn't work with
// NCrunch's test runner.
public partial class Program { }
