# 🍲 MyRecipeBook

**API RESTful para gestão de receitas culinárias**, desenvolvida em C# com arquitetura moderna, foco em escalabilidade e boas práticas de desenvolvimento.

---

## 📌 Objetivo

Esse projeto tem como foco o aprendizado prático em desenvolvimento back-end utilizando .NET 6/7 com aplicação real de conceitos como:

- Domain-Driven Design (DDD)
- Clean Architecture
- Princípios SOLID
- Testes unitários e de integração
- CI/CD e deploy no Azure
- Autenticação com OAuth (Google)
- Integração com OpenAI / ChatGPT

---

## 🛠️ Tecnologias e Ferramentas

- C# / .NET
- ASP.NET Core Web API
- Entity Framework Core
- Docker
- SQL Server
- Azure DevOps
- Swagger / Swashbuckle
- xUnit / FluentAssertions
- GitHub + Git Flow

---

## 📂 Estrutura de Pastas

MyRecipeBook/
│
├── source/
│ ├── backend/
│ │ ├── MyRecipeBook.api/ # Camada de apresentação
│ │ ├── MyRecipeBook.application/ # Casos de uso e serviços
│ │ ├── MyRecipeBook.domain/ # Entidades e contratos
│ │ ├── MyRecipeBook.infrastructure/# Infra, banco de dados
│ └── shared/
│ ├── MyRecipeBook.Communication/ # DTOs, contratos
│ └── MyRecipeBook.Exceptions/ # Tratamento de erros

---

## 🚀 Como executar o projeto

### Pré-requisitos

- [.NET SDK 6 ou superior](https://dotnet.microsoft.com/)
- [Docker](https://www.docker.com/)
- [SQL Server ou Docker para DB](https://hub.docker.com/_/microsoft-mssql-server)

### Passos

# Clone o projeto
git clone git@github.com:JonathansBarbosa/MyRecipeBook.git

# Acesse a pasta da API
cd MyRecipeBook/source/backend/MyRecipeBook.api

# Restaure os pacotes
dotnet restore

# Rode a aplicação
dotnet run

🧪 Testes

# Executar todos os testes
dotnet test
📅 Em desenvolvimento
 Cadastro de usuários
 Autenticação via Google
 Criação de receitas
 Upload de imagens
 Integração com ChatGPT
 Deploy no Azure

👨‍💻 Autor
Jonathan Barbosa
Desenvolvedor Back-End Jr | .NET, C#, Azure, CI/CD

🌟 Contribuições
Esse repositório faz parte de um projeto pessoal de aprendizagem, mas qualquer feedback é bem-vindo!
Abra uma issue, sugestão ou me chame no LinkedIn. Vamos crescer juntos!
