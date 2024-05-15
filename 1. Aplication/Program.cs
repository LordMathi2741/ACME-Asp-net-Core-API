using _1._Aplication.Mapper;
using _2._Domain;
using _3._Infraestructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Dependency Injection
builder.Services.AddScoped<ITutorialInfraestructure, TutorialOracle>();
builder.Services.AddScoped<ITutorialDomain, TutorialDomain>();


builder.Services.AddAutoMapper(typeof(RequestToModel), typeof(ModelToRequest));

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