# Sprint1CSharp - Challenge FIAP 2025

API desenvolvida em ASP.NET Core para gerenciar Clientes e seus Veículos, como parte do desafio Mottu: Mapeamento Inteligente de Pátios e Gestão de Motos.

## 📌 Tecnologias Utilizadas

- ASP.NET Core 8
- Entity Framework Core
- Oracle DB
- Swagger 
- Visual Studio / VS Code

## 🚀 Como executar

1. Clone o repositório:
```bash
git clone https://github.com/SEU_USUARIO/Sprint1CSharp.git
cd Sprint1CSharp
```

2. Atualize as credenciais:
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

4. Acesse a aplicação através da URL que o terminal lhe retornar:
```bash
http://localhost:5269/swagger
```



## 📌 Endpoints da API - Clientes

| Método | Rota                                | Parâmetros            | Descrição                                                                 |
|--------|-------------------------------------|------------------------|---------------------------------------------------------------------------|
| GET    | `/api/clientes`                     | `?nome=` (opcional)    | Retorna todos os clientes. Se informado, filtra por nome (QueryParam).   |
| GET    | `/api/clientes/{id}`                | `id` (int)             | Retorna um cliente específico pelo ID, incluindo seus veículos.          |
| GET    | `/api/clientes/{id}/veiculos`       | `id` (int)             | Retorna todos os veículos associados a um cliente específico.            |
| GET    | `/api/clientes/email/{email}`       | `email` (string)       | Retorna um cliente com base no e-mail.                                   |
| POST   | `/api/clientes`                     | JSON body              | Cria um novo cliente com um ou mais veículos associados.                 |
| PUT    | `/api/clientes/{id}`                | `id` (int), JSON body  | Atualiza os dados de um cliente. O `id` da URL deve ser igual ao do corpo. |
| DELETE | `/api/clientes/{id}`                | `id` (int)             | Remove o cliente e seus veículos do banco de dados.                      |





