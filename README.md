
📚 Biblioteca API - Gerenciamento de Livros
Este projeto é uma RESTful API desenvolvida com ASP.NET Core (.NET 10) para o gerenciamento de um catálogo de livros. O sistema implementa operações completas de CRUD (Create, Read, Update, Delete) seguindo as melhores práticas de arquitetura de software e design de código.

🚀 Tecnologias e Arquitetura
O projeto foi construído utilizando o que há de mais moderno no ecossistema Microsoft:

C# 14 (Utilizando recursos modernos como Primary Constructors)

.NET 10 (LTS): Versão de Longo Suporte, garantindo performance e estabilidade.

ASP.NET Core Web API

Injeção de Dependência (DI) nativa

Service Layer Pattern: Separação clara entre a lógica de negócios e o controle de requisições.

DTOs (Data Transfer Objects): Para segurança e validação no tráfego de dados.

Persistência em Memória: Estrutura otimizada para desenvolvimento ágil.

⚙️ Como Executar
Pré-requisitos: .NET 10 SDK instalado.

Bash
# Clone este repositório
git clone https://github.com/SEU-USUARIO/NOME-DO-REPO.git

# Entre na pasta
cd BLIBLIOTECA

# Execute o projeto
dotnet run
A API estará rodando em https://localhost:PORTA (verifique o console para o número da porta).

🧪 Como Testar com Postman / Insomnia
Abaixo estão os detalhes para testar cada endpoint da API.

1. Criar um Livro (POST)
Cadastra um novo livro no sistema. O ID é gerado automaticamente.

URL: /api/books

Método: POST

Corpo (JSON):

JSON
{
  "title": "O Senhor dos Anéis",
  "author": "J.R.R. Tolkien",
  "year": 1954,
  "genre": 1,
  "description": "Uma jornada épica na Terra Média.",
  "price": 129.90,
  "stock": 15
}
Retornos Possíveis:

201 Created: Sucesso (retorna o livro criado com link Location).

400 Bad Request: Dados inválidos (ex: preço negativo).

409 Conflict: Livro com mesmo título e autor já existe.

2. Listar Todos (GET)
Retorna o catálogo completo.

URL: /api/books

Método: GET

Retorno: 200 OK com a lista de objetos JSON.

3. Buscar por ID (GET)
Retorna os detalhes de um único livro.

URL: /api/books/{id} (ex: /api/books/1)

Método: GET

Retornos Possíveis:

200 OK: Livro encontrado.

404 Not Found: ID inexistente.

4. Atualizar Livro (PUT)
Atualiza os dados de um livro existente.

URL: /api/books/{id}

Método: PUT

Corpo (JSON): Envie o objeto completo com os novos dados.

Retornos Possíveis:

204 No Content: Atualizado com sucesso.

404 Not Found: Livro não encontrado.

5. Deletar Livro (DELETE)
Remove um livro do catálogo.

URL: /api/books/{id}

Método: DELETE

Retornos Possíveis:

204 No Content: Removido com sucesso.

404 Not Found: ID não encontrado.

🔮 Roadmap (Futuro do Projeto)
Este projeto está em evolução constante. As próximas implementações planejadas são:

[ ] Persistência em Banco de Dados: Migração da lista estática para SQL Server ou PostgreSQL utilizando Entity Framework Core.

[ ] Mapeamento Automático: Implementação do AutoMapper para reduzir código repetitivo entre DTOs e Entidades.

[ ] Segurança: Implementação de Autenticação e Autorização (JWT).

[ ] LGPD: Refinamento do tratamento de dados sensíveis visando conformidade com a Lei Geral de Proteção de Dados.

Desenvolvido por Juan 💻 Estudante de Ciência da Computação (Graduação 2028)
