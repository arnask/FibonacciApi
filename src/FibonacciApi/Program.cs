using FibonacciApi.Presentation.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Host.ConfigureLogging();

builder.Services.ConfigureServices();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
