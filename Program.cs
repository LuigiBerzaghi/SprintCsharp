using Microsoft.EntityFrameworkCore;
using Sprint1CSharp.Data;

var builder = WebApplication.CreateBuilder(args);

// 🔌 Configuração da string de conexão Oracle
var connectionString = builder.Configuration.GetConnectionString("OracleConnection");

// 💾 Registro do AppDbContext com EF Core + Oracle
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseOracle(connectionString));

// 🔧 Serviços essenciais da API
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// 📄 Habilita documentação Swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// 🛡️ HTTPS redirection e configuração básica
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
