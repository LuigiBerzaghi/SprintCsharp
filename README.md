# Sprint1CSharp - Challenge FIAP 2025

API desenvolvida em ASP.NET Core para gerenciar Clientes e seus Veículos, como parte do desafio Mottu: Mapeamento Inteligente de Pátios e Gestão de Motos.

## 📌 Tecnologias Utilizadas

- ASP.NET Core 9
- Entity Framework Core
- Oracle DB
- Swagger (OpenAPI)
- Visual Studio / VS Code

## 🚀 Como executar

1. Clone o repositório:
```bash
git clone https://github.com/SEU_USUARIO/Sprint1CSharp.git
cd Sprint1CSharp
```

2. Clone o repositório:
```bash
"ConnectionStrings": {
  "OracleConnection": "User Id=SEU_USUARIO;Password=SUA_SENHA;Data Source=oracle.fiap.com.br:1521/ORCL"
}
```

3. Restaure os pacotes e aplique as migrations:
```bash
dotnet restore
dotnet ef database update
```

3. Execute a aplicação:
```bash
dotnet run
```

4. Acesse a aplicação:
```bash
https://localhost:5001/swagger
```








