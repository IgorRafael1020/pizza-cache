using ApiPizzaCache.Repositories;
using ApiPizzaCache.Services.Pizza;
using ApiPizzaCache.Services.Redis;
using StackExchange.Redis;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IPizzaRepository, PizzaRepository>();
builder.Services.AddScoped<IPizzaService, PizzaService>(); 
builder.Services.AddScoped<IRedisService, RedisService>();

// Configure Redis
string enderecoRedis = Environment.GetEnvironmentVariable("ENDERECO_REDIS") ?? "localhost";
string portaRedis = Environment.GetEnvironmentVariable("PORTA_REDIS") ?? "6379";

ConfigurationOptions options = new ConfigurationOptions
{
    AbortOnConnectFail = false,
    EndPoints = { enderecoRedis, portaRedis }
};

builder.Services.AddSingleton<IConnectionMultiplexer>(o => ConnectionMultiplexer.Connect(options));

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
