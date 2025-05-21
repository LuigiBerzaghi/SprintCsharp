# Sprint1CSharp - Challenge FIAP 2025

API desenvolvida em ASP.NET Core para gerenciar Clientes e seus Veículos, como parte do desafio da Mottu: Mapeamento Inteligente de Pátios e Gestão de Motos.

## 📌 Tecnologias Utilizadas

* ASP.NET Core 8
* Entity Framework Core
* Oracle DB
* Swagger (OpenAPI)
* Visual Studio / VS Code

## 🚀 Como executar

1. Clone o repositório:

```bash
git clone https://github.com/LuigiBerzaghi/SprintCsharp.git
cd SprintCSharp
```

2. Atualize as credenciais do banco Oracle no `appsettings.json`:

```json
"ConnectionStrings": {
  "OracleConnection": "User Id=SEU_USUARIO;Password=SUA_SENHA;Data Source=oracle.fiap.com.br:1521/ORCL"
}
```

3. Restaure os pacotes e aplique as migrations:

```bash
dotnet restore
dotnet ef database update
```

4. Execute a aplicação:

```bash
dotnet run
```

5. Acesse a interface gráfica da API (Swagger):

```
http://localhost:5269/swagger
```

---

## 📌 Endpoints da API - Clientes

| Método | Rota                          | Parâmetros            | Descrição                                                                  | Exemplo de JSON Body |
| ------ | ----------------------------- | --------------------- | -------------------------------------------------------------------------- | -------------------- |
| GET    | `/api/clientes`               | `?nome=` (opcional)   | Retorna todos os clientes. Se informado, filtra por nome (QueryParam).     | —                    |
| GET    | `/api/clientes/{id}`          | `id` (int)            | Retorna um cliente específico pelo ID, incluindo seus veículos.            | —                    |
| GET    | `/api/clientes/{id}/veiculos` | `id` (int)            | Retorna todos os veículos associados a um cliente específico.              | —                    |
| GET    | `/api/clientes/email/{email}` | `email` (string)      | Retorna um cliente com base no e-mail.                                     | —                    |
| POST   | `/api/clientes`               | JSON body             | Cria um novo cliente com um ou mais veículos associados.                   | Ver abaixo           |
| PUT    | `/api/clientes/{id}`          | `id` (int), JSON body | Atualiza os dados de um cliente. O `id` da URL deve ser igual ao do corpo. | Ver abaixo           |
| DELETE | `/api/clientes/{id}`          | `id` (int)            | Remove o cliente e seus veículos do banco de dados.                        | —                    |

---

### 🧪 Exemplo de JSON para POST/PUT

```json
{
  "nome": "Maria Oliveira",
  "cpf": "987.654.321-00",
  "email": "maria@email.com",
  "endereco": "Av. Central, 456",
  "veiculos": [
    {
      "modelo": "Corolla",
      "placa": "XYZ-9876",
      "cor": "Branco",
      "ano": "2022"
    }
  ]
}
```
