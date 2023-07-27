using DogApp.Api.Middlewares;
using Gb.Api.Extensions;
using Gb.Infrastructure.DbContexts;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers().ConfigureApiBehavior();
builder.Services.AddGbDbContext(builder.Configuration);
builder.Services.AddExternalServices();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.UseMiddleware<ErrorHandlingMiddleware>();
app.MigrateDatabase<GbDbContext>();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
