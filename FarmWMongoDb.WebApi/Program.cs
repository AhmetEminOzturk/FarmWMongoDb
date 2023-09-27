using FarmWMongoDb.WebApi.Services.AboutUsServices;
using FarmWMongoDb.WebApi.Services.HomeServiceServices;
using FarmWMongoDb.WebApi.Services.StatisticServices;
using FarmWMongoDb.WebApi.Services.TestimonialServices;
using FarmWMongoDb.WebApi.Services.VideoBannerServices;
using FarmWMongoDb.WebApi.Services.WelcomeBannerServices;
using FarmWMongoDb.WebApi.Services.WhyUsServices;
using FarmWMongoDb.WebApi.Settings;
using Microsoft.Extensions.Options;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IAboutUsService, AboutUsService>();
builder.Services.AddScoped<IHomeServiceService, HomeServiceService>();
builder.Services.AddScoped<IStatisticService, StatisticService>();
builder.Services.AddScoped<ITestimonialService, TestimonialService>();
builder.Services.AddScoped<IVideoBannerService, VideoBannerService>();
builder.Services.AddScoped<IWelcomeBannerService, WelcomeBannerService>();
builder.Services.AddScoped<IWhyUsService, WhyUsService>();

builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
builder.Services.Configure<DatabaseSettings>(builder.Configuration.GetSection("DatabaseSettings"));

builder.Services.AddSingleton<IDatabaseSettings>(sp =>
{
    return sp.GetRequiredService<IOptions<DatabaseSettings>>().Value;
});



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
