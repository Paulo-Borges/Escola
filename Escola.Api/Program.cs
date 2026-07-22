using Escola.Api.Middleware;
using Escola.Infra.Ioc;
using Microsoft.OpenApi;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSwaggerGen(options =>
{
options.AddSecurityDefinition("bearer", new OpenApiSecurityScheme
{
    Type = SecuritySchemeType.Http,
    Scheme = "bearer",
    BearerFormat = "JWT",
    Description = "JWT Authorization header using the Bearer scheme"
});
options.AddSecurityRequirement(document => new OpenApiSecurityRequirement
    {
    [new OpenApiSecuritySchemeReference("bearer", document)] = []
     });
});
builder.Services.AddControllers();

// PASSANDO A CONFIGURAÇÃO PARA O MÉTODO DE EXTENSÃO AddInfrastructure
builder.Services.AddInfrastructure(builder.Configuration);


// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();


builder.Services.AddCors(options =>
{
    options.AddPolicy("LiberarTudo", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseMiddleware<ExceptionMiddleware>();

app.UseHttpsRedirection();

app.UseCors("LiberarTudo");

app.UseAuthorization();


app.MapControllers();

app.Run();
