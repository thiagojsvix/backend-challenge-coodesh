# Work in Progress...


# Case
A empresa Pharma Inc, está trabalhando em um projeto em colaboração com sua base de clientes para facilitar a gestão e visualização da informação dos seus pacientes de maneira simples e objetiva em um Dashboard onde podem listar, filtrar e expandir os dados disponíveis.
O seu objetivo nesse projeto, é trabalhar no desenvolvimento da REST API da empresa Pharma Inc seguindo os requisitos propostos neste desafio.

## Recursos

1. Desenvolver REST API importando os dados do projeto: https://randomuser.me/documentation
2. Trabalhar em um [FORK](https://lab.coodesh.com/help/gitlab-basics/fork-project.md) deste repositório em seu usuário ou utilizar um repositório em seu github pessoal (não esqueça de colocar no readme a referência a este challenge)


## API

### Modelo de Dados:

Para a definição do modelo, consultar o arquivo [users.json](./users.json) que foi exportado do Random Users.

- `imported_t`: campo do tipo Date com a dia e hora que foi importado;
- `status`: campo do tipo Enum com os possíveis valores draft, trash e published;

### Sistema do CRON

Para prosseguir com o desafio, precisaremos criar na API um sistema de atualização que vai importar os dados para a Base de Dados com a versão mais recente do [Random User](https://randomuser.me/documentation#format) uma vez ao día. Adicionar aos arquivos de configuração o melhor horário para executar a importação.

A lista de arquivos do Random User, pode ser encontrada em: 

- https://randomuser.me/api

Escolher o formato que seja mais cômodo para importar todos os dados para a Base de Dados, o Random User tem os seguintes formatos:

- JSON (default)
- PrettyJSON or pretty
- CSV
- YAML
- XML

Ter em conta que:

- Todos os produtos deverão ter os campos personalizados `imported_t` e `status`.
- Importar os dados de maneira paginada para não sobrecargar a API do Random Users. Por exemplo, de 100 em usuários.
- Limitar a importação a somente 2000 usuarios;


### A REST API


Na REST API teremos um CRUD com os seguintes endpoints:

   - `GET /`: Retornar uma mensagem "REST Back-end Challenge 20201209 Running"
   - `PUT /users/:userId`: Será responsável por receber atualizações dso dados
   - `DELETE /users/:userId`: Remover o user da base
   - `GET /users/:userId`: Obter a informação somente de um user da base de dados
   - `GET /users`: Listar todos os usuários da base de dados

### Extras

- **Diferencial 1** Escrever Unit Test para os endpoints da REST API
- **Diferencial 2** Executar o projeto usando Docker
- **Diferencial 3** Escrever um esquema de segurança utilizando `API KEY` nos endpoints. Ref: https://learning.postman.com/docs/sending-requests/authorization/#api-key
- **Diferencial 4** Descrever a documentação da API utilizando o conceito de Open API 3.0;

## Readme do Repositório

- Deve conter o título do projeto
- Uma descrição sobre o projeto em frase
- Deve conter uma lista com linguagem, framework e/ou tecnologias usadas
- Como instalar e usar o projeto (instruções)
- Não esqueça o [.gitignore](https://www.toptal.com/developers/gitignore)
- Se está usando github pessoal, referencie que é um challenge by coodesh 


## Referência

[Challenge](https://lab.coodesh.com/public-challenges/back-end-challenge-2021/-/tree/master)  
[Randon User Generator](https://randomuser.me/documentation)  
[Schedule a Background Task](https://stackoverflow.com/questions/63795334/in-asp-net-core-3-1-how-can-i-schedule-a-background-task-cron-jobs-with-hoste)  
