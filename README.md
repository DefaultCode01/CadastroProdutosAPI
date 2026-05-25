
# 🚀 CadastroProdutos API

> API RESTful desenvolvida com **C#**, **ASP.NET Core** e **Entity Framework Core**, utilizando autenticação JWT e integração com banco de dados SQL Server.

---

# 📸 Preview da API

## 🔹 Swagger da aplicação

![Swagger API](<img width="990" height="520" alt="Screenshot 2026-05-25 124953" src="https://github.com/user-attachments/assets/2f71e6e2-6c93-4e93-bd9c-748053f8de3c" />)

---

## 🔹 Endpoints protegidos com JWT

![JWT Swagger](<img width="974" height="468" alt="Screenshot 2026-05-25 124302" src="https://github.com/user-attachments/assets/8ee67e7f-4af9-4ca4-9635-f4dff45d1fb2" />)

---

# 📖 Sobre o Projeto

Este projeto foi desenvolvido durante o curso:

## 🎓 **Aprendendo Backend em C#: Banco de Dados, API e Segurança**

O objetivo da aplicação é fornecer uma API RESTful completa para gerenciamento de produtos, aplicando conceitos modernos de desenvolvimento backend com .NET.

---

# 🧠 O que a API possui

A aplicação contém dois exemplos de implementação:

✅ API RESTful utilizando armazenamento em memória

✅ API RESTful utilizando banco de dados SQL Server com Entity Framework Core

✅ Autenticação JWT

✅ Swagger/OpenAPI

✅ CRUD completo

✅ Injeção de Dependência

---

# 🛠️ Tecnologias Utilizadas

| 🚀 Tecnologia | 📌 Função |
|---|---|
| **C#** | Linguagem principal |
| **ASP.NET Core** | Framework backend |
| **Entity Framework Core** | ORM para acesso ao banco |
| **SQL Server** | Banco de dados |
| **JWT Authentication** | Segurança e autenticação |
| **Swagger** | Documentação e testes |
| **Dependency Injection** | Arquitetura desacoplada |

---

# ⚙️ Funcionalidades

A API permite:

- 📋 Listar produtos
- 🔎 Buscar produtos por ID
- ➕ Cadastrar produtos
- ✏️ Atualizar produtos
- ❌ Excluir produtos
- 🔐 Realizar login com JWT
- 🛡️ Proteger rotas autenticadas
- 🧪 Testar endpoints pelo Swagger

---

# 🌐 Estrutura dos Endpoints

# 🔑 Login

| Método | Endpoint | Descrição |
|---|---|---|
| `POST` | `/api/Login` | Realiza autenticação e gera token JWT |

---

# 📦 Produtos

| Método | Endpoint | Descrição |
|---|---|---|
| `GET` | `/api/Produtos` | Lista todos os produtos |
| `GET` | `/api/Produtos/{id}` | Busca produto por ID |
| `POST` | `/api/Produtos` | Cadastra um produto |
| `PUT` | `/api/Produtos/{id}` | Atualiza um produto |
| `DELETE` | `/api/Produtos/{id}` | Remove um produto |

---

# 🔐 Exemplo de Login

## 📥 Requisição

```json
{
  "username": "admin",
  "password": "123"
}
````

---

## 📤 Resposta

```json
{
  "token": "eyJhbGc..."
}
```

---

# 🛡️ Como Utilizar o Token JWT

Após realizar login, copie o token retornado e utilize no botão **Authorize** do Swagger.

## Header utilizado:

```http
Authorization: Bearer SEU_TOKEN
```

---

# ▶️ Como Executar o Projeto

## 1️⃣ Clonar o repositório

```bash
git clone https://github.com/SEU-USUARIO/CadastroProdutosAPI.git
```

---

## 2️⃣ Entrar na pasta

```bash
cd CadastroProdutosAPI
```

---

## 3️⃣ Restaurar dependências

```bash
dotnet restore
```

---

## 4️⃣ Atualizar banco de dados

```bash
dotnet ef database update
```

---

## 5️⃣ Executar aplicação

```bash
dotnet run
```

---

# 📚 Swagger

Após executar o projeto, acesse:

```text
https://localhost:xxxx/swagger
```

O Swagger permite:

* ✅ Visualizar endpoints
* ✅ Testar requisições
* ✅ Validar respostas
* ✅ Utilizar autenticação JWT
* ✅ Simular consumo da API

---

# 🧩 Conceitos Aplicados

# 🌐 APIs RESTful

* Métodos HTTP
* Rotas
* Controllers
* Endpoints

---

# ⚡ ASP.NET Core

* Middleware
* Configuração de serviços
* Controllers
* Pipeline HTTP

---

# 🗄️ Entity Framework Core

* ORM
* DbContext
* Migrations
* Persistência de dados

---

# 💾 Banco de Dados

* CRUD completo
* Relacionamento entre entidades
* Connection String
* Migrações

---

# 🔒 JWT Authentication

* Geração de tokens
* Autenticação
* Autorização
* Proteção de rotas

---

# 🔧 Injeção de Dependência

* Services
* Interfaces
* Desacoplamento
* Reutilização de código

---

# 📈 O Que Aprendi

Durante este projeto, foram praticados conceitos importantes de desenvolvimento backend:

✅ Construção de APIs REST com .NET

✅ Integração com banco de dados usando EF Core

✅ Estruturação de aplicações backend

✅ Implementação de autenticação JWT

✅ Criação de CRUD completo

✅ Utilização de Swagger

✅ Aplicação de boas práticas de arquitetura

✅ Uso de interfaces e services

✅ Injeção de dependência

---

# 🎓 Curso Realizado

## 📚 Aprendendo Backend em C#: Banco de Dados, API e Segurança

### 📌 Conteúdos estudados

* APIs RESTful com ASP.NET Core
* Entity Framework Core
* SQL Server
* JWT Authentication
* Injeção de Dependência
* CRUD completo
* Segurança de APIs

---

## ⏱️ Carga horária

**7,5 horas**

---

# 👨‍💻 Autor

**Matheus da Silva Gomes**
Estudante de Análise e Desenvolvimento de Sistemas • Desenvolvedor de Jogos

🔗 LinkedIn: https://www.linkedin.com/in/matheus-da-silva-gomes-baa89a23b
🐙 GitHub: https://github.com/DefaultCode01

