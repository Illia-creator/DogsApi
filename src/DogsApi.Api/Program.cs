using DogsApi.Api.Infrastructure;
using static System.Net.Mime.MediaTypeNames;

var builder = WebApplication.CreateBuilder(args);

builder.AddServices(builder.Configuration);

var app = builder.Build();

app.AddApplication();
