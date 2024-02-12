using Microsoft.EntityFrameworkCore;
using Subjectmarks.Models;
using Microsoft.Extensions.DependencyInjection;
using Subjectmarks.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<SubjectmarksDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("SubjectmarksDbContext") ?? throw new InvalidOperationException("Connection string 'SubjectmarksDbContext' not found.")));

// Add services to the container.
builder.Services.AddDbContext<RainbowschoolContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("EFPConst")));
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
