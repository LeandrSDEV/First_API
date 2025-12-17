# First API

API REST desenvolvida com **ASP.NET Core**, aplicando conceitos de **arquitetura em camadas**, **Entity Framework Core** e **boas práticas de desenvolvimento de APIs**, com documentação via **Swagger**.

Projeto utilizado para consolidar conhecimentos em back-end e servir como demonstração técnica em portfólio.

---

## Tecnologias

- ASP.NET Core Web API
- C#
- Entity Framework Core
- SQL Server
- Swagger (OpenAPI)

---

## Funcionalidades

- 🔍 Consulta de **CEP** através de integração externa
- 📝 CRUD completo de **Tarefas**
- 👤 CRUD completo de **Usuários**
- 📄 Documentação interativa com Swagger

---

## Endpoints

### CEP
- `GET /api/Cep/{cep}`

### Tarefa
- `GET /api/Tarefa`
- `GET /api/Tarefa/{id}`
- `POST /api/Tarefa`
- `PUT /api/Tarefa/{id}`
- `DELETE /api/Tarefa/{id}`

### Usuário
- `GET /api/Usuario`
- `GET /api/Usuario/{id}`
- `POST /api/Usuario`
- `PUT /api/Usuario/{id}`
- `DELETE /api/Usuario/{id}`

---

## Conceitos Aplicados

- Arquitetura em camadas (Controllers, Services/Repositories, Data)
- Entity Framework Core com Mapeamento (Fluent API)
- Padrão Repository
- Integração com API externa
- Documentação automática com Swagger

---

## Objetivo

Demonstrar habilidades em desenvolvimento de **APIs REST com .NET**, organização de código, persistência de dados e integração entre sistemas.
