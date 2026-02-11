# 📚 Biblioteca API - Gerenciamento de Livros

![.NET](https://img.shields.io/badge/.NET%2010-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![Status](https://img.shields.io/badge/Status-Em%20Desenvolvimento-yellow?style=for-the-badge)

> Uma API RESTful para gerenciamento de acervo literário, desenvolvida com as tecnologias mais recentes do ecossistema Microsoft.

---

## 📋 Sobre o Projeto

Este projeto foi desenvolvido como parte do meu portfólio acadêmico em **Ciência da Computação**. O objetivo é demonstrar a implementação de uma arquitetura organizada e escalável, utilizando **Injeção de Dependência**, **Service Layer Pattern** e as novidades do **.NET 10**.

O sistema gerencia o ciclo de vida completo de livros (**CRUD**), com validações de negócio e tratamento de erros padronizado.

---

## 🚀 Tecnologias Utilizadas

- **Runtime:** .NET 10
- **Linguagem:** C# 14 (Primary Constructors)
- **Framework:** ASP.NET Core Web API
- **Arquitetura:** MVC + Service Layer
- **Documentação:** OpenAPI/Swagger

---

## 🏛️ Arquitetura do Projeto

O projeto segue separação de responsabilidades para facilitar manutenção e evolução.

```text
📂 BLIBLIOTECA-API
├── 📂 Controllers       # (Apresentação) Endpoints/rotas HTTP
├── 📂 Services          # (Regra de Negócio) Lógica principal
├── 📂 Models            # (Domínio) Entidades (ex.: Book)
├── 📂 Comunication      # (DTOs) Requests/Responses (contratos da API)
├── 📂 Properties        # Configurações do projeto/ambiente
├── 📄 Program.cs        # Configuração de DI e pipeline
└── 📄 appsettings*.json # Configurações por ambiente
```

> Observação: no repositório a pasta está como **`Comunication`**. Se a intenção era **`Communication`**, vale renomear depois para padronizar.

---

## 🔌 Endpoints da API

| Método | Endpoint            | Descrição              | Sucesso |
|-------:|---------------------|------------------------|:-------:|
| POST   | `/api/books`        | Cria um novo livro     | 201     |
| GET    | `/api/books`        | Lista todos os livros  | 200     |
| GET    | `/api/books/{id}`   | Busca livro por ID     | 200     |
| PUT    | `/api/books/{id}`   | Atualiza um livro      | 204     |
| DELETE | `/api/books/{id}`   | Remove um livro        | 204     |

---

## 🛠️ Como Executar

### Pré-requisitos
- **.NET 10 SDK** instalado

### Passo a passo

```bash
# Clone o repositório
git clone https://github.com/juansoares28/BLIBLIOTECA-API.git

# Entre na pasta do projeto
cd BLIBLIOTECA-API

# Restaurar dependências
dotnet restore

# Executar a aplicação
dotnet run
```

A API vai iniciar em uma URL como:
- `https://localhost:PORTA`
- `http://localhost:PORTA`

> Confira a porta no console. Se o Swagger estiver habilitado, normalmente fica em `/swagger`.

---

## 🧪 Testando com Postman

### 1) Configurar `baseUrl`
No Postman, crie um **Environment** e adicione:

- `baseUrl` = `https://localhost:PORTA`

Aí você usa assim nas requisições:
- `{{baseUrl}}/api/books`

### 2) Exemplo de requisição (Criar livro)

**POST** `{{baseUrl}}/api/books`  
**Body** → raw → JSON:

```json
{
  "title": "Clean Code",
  "author": "Robert C. Martin",
  "year": 2008,
  "genre": 1,
  "description": "Essencial para engenheiros de software.",
  "price": 99.90,
  "stock": 10
}
```

---

## 🔮 Roadmap (Próximos Passos)

- [ ] Banco de Dados: Entity Framework Core (SQL Server/PostgreSQL)
- [ ] Mapeamento: AutoMapper
- [ ] Segurança: JWT (Autenticação/Autorização)
- [ ] CI/CD: GitHub Actions

---

## 👨‍💻 Autor

**Juan Soares G Vazquez**  
Estudante de Ciência da Computação (Graduação 2028) — foco em Backend, Infraestrutura e Arquitetura de Software.
