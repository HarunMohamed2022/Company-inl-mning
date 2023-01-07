using Company.Common.DTOs;
using Company.Data.Services;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<CompanyContext>(
 options =>
 options.UseSqlServer(
 builder.Configuration.GetConnectionString("CourseConnection")));

ConfigureAutomapper(builder.Services);
RegisterServices(builder.Services);


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

void ConfigureAutomapper(IServiceCollection services)
{
    var config = new MapperConfiguration(cfg =>
    {
        cfg.CreateMap<Anställd, AnställdDTO>().ReverseMap();
        cfg.CreateMap<Avdelning, AvdelningDTO>().ReverseMap();
        cfg.CreateMap<Beffatning, BeffatningDTO>().ReverseMap();
        cfg.CreateMap<Företag, FöretagDTO>().ReverseMap();
        cfg.CreateMap<AnställdBefattningar,AnställdBefattningarDTO>().ReverseMap();
    });
    var mapper = config.CreateMapper();
    services.AddSingleton(mapper);
}

void RegisterServices(IServiceCollection services)
{
    services.AddScoped<IDbService, DbService>();
}
