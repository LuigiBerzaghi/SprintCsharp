# 🚗 Sprint1CSharp - Challenge FIAP 2025

API REST desenvolvida em **ASP.NET Core 8** com **Entity Framework Core** e banco de dados **Oracle**, como parte do desafio proposto pela **Mottu**. O objetivo é realizar o **mapeamento inteligente de pátios** e a **gestão de veículos (motos)** de forma organizada e automatizada.

---

## 🔧 Tecnologias Utilizadas

- [ASP.NET Core 8](https://learn.microsoft.com/aspnet/core)
- [Entity Framework Core](https://learn.microsoft.com/ef/core)
- [Oracle Database](https://www.oracle.com/br/database/)
- [Oracle.EntityFrameworkCore](https://www.nuget.org/packages/Oracle.EntityFrameworkCore)
- [Swagger](https://github.com/domaindrivendev/Swashbuckle.AspNetCore)
- [Visual Studio](https://visualstudio.microsoft.com/pt-br/)

---

## 🚀 Como Executar o Projeto

### 1. **Clone o Repositório**

```bash
git clone https://github.com/LuigiBerzaghi/SprintCsharp.git
cd SprintCSharp
```

### 2. **Configure a Conexão com o Banco de Dados**

Abra o arquivo `appsettings.json` e substitua as credenciais com as fornecidas pela FIAP ou pela sua conta Oracle:

```json
"ConnectionStrings": {
  "OracleConnection": "User Id=SEU_USUARIO;Password=SUA_SENHA;Data Source=oracle.fiap.com.br:1521/ORCL"
}
```

### 3. **Restaure os Pacotes e Atualize o Banco**

```bash
dotnet restore
dotnet ef database update
```

Esse comando aplicará as **migrations do EF Core** e criará as tabelas `Clientes` e `Veiculos` no banco de dados Oracle, caso ainda não existam.

### 4. **Execute a API**

```bash
dotnet run
```

### 5. **Acesse a Interface Swagger**

Abra o navegador e acesse:

```
http://localhost:5269/swagger
```

Você poderá testar os endpoints diretamente na interface gráfica interativa.

---

## 📌 Endpoints da API - Clientes

| Método | Rota                          | Parâmetros            | Descrição                                                                  | Exemplo de JSON Body |
|--------|-------------------------------|------------------------|-----------------------------------------------------------------------------|------------------------|
| GET    | `/api/clientes`               | `?nome=` (opcional)    | Retorna todos os clientes. Pode filtrar por nome.                          | —                      |
| GET    | `/api/clientes/{id}`          | `id` (int)             | Retorna um cliente específico com seus veículos.                           | —                      |
| GET    | `/api/clientes/{id}/veiculos` | `id` (int)             | Lista todos os veículos associados a um cliente.                           | —                      |
| GET    | `/api/clientes/email/{email}` | `email` (string)       | Retorna um cliente com base no e-mail informado.                           | —                      |
| POST   | `/api/clientes`               | JSON body              | Cria um novo cliente e seus veículos.                                      | ✅ (Ver abaixo)         |
| PUT    | `/api/clientes/{id}`          | `id` (int), JSON body  | Atualiza os dados de um cliente existente.                                 | ✅ (Ver abaixo)         |
| DELETE | `/api/clientes/{id}`          | `id` (int)             | Remove um cliente e seus veículos do banco.                                | —                      |

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
