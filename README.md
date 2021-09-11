# Work in Progress...


# Case
A empresa Pharma Inc, est� trabalhando em um projeto em colabora��o com sua base de clientes para facilitar a gest�o e visualiza��o da informa��o dos seus pacientes de maneira simples e objetiva em um Dashboard onde podem listar, filtrar e expandir os dados dispon�veis.
O seu objetivo nesse projeto, � trabalhar no desenvolvimento da REST API da empresa Pharma Inc seguindo os requisitos propostos neste desafio.

## Recursos

1. Desenvolver REST API importando os dados do projeto: https://randomuser.me/documentation
2. Trabalhar em um [FORK](https://lab.coodesh.com/help/gitlab-basics/fork-project.md) deste reposit�rio em seu usu�rio ou utilizar um reposit�rio em seu github pessoal (n�o esque�a de colocar no readme a refer�ncia a este challenge)


## API

### Modelo de Dados:

Para a defini��o do modelo, consultar o arquivo [users.json](./users.json) que foi exportado do Random Users.

- `imported_t`: campo do tipo Date com a dia e hora que foi importado;
- `status`: campo do tipo Enum com os poss�veis valores draft, trash e published;

### Sistema do CRON

Para prosseguir com o desafio, precisaremos criar na API um sistema de atualiza��o que vai importar os dados para a Base de Dados com a vers�o mais recente do [Random User](https://randomuser.me/documentation#format) uma vez ao d�a. Adicionar aos arquivos de configura��o o melhor hor�rio para executar a importa��o.

A lista de arquivos do Random User, pode ser encontrada em: 

- https://randomuser.me/api

Escolher o formato que seja mais c�modo para importar todos os dados para a Base de Dados, o Random User tem os seguintes formatos:

- JSON (default)
- PrettyJSON or pretty
- CSV
- YAML
- XML

Ter em conta que:

- Todos os produtos dever�o ter os campos personalizados `imported_t` e `status`.
- Importar os dados de maneira paginada para n�o sobrecargar a API do Random Users. Por exemplo, de 100 em usu�rios.
- Limitar a importa��o a somente 2000 usuarios;


### A REST API


Na REST API teremos um CRUD com os seguintes endpoints:

   - `GET /`: Retornar uma mensagem "REST Back-end Challenge 20201209 Running"
   - `PUT /users/:userId`: Ser� respons�vel por receber atualiza��es dso dados
   - `DELETE /users/:userId`: Remover o user da base
   - `GET /users/:userId`: Obter a informa��o somente de um user da base de dados
   - `GET /users`: Listar todos os usu�rios da base de dados

### Extras

- **Diferencial 1** Escrever Unit Test para os endpoints da REST API
- **Diferencial 2** Executar o projeto usando Docker
- **Diferencial 3** Escrever um esquema de seguran�a utilizando `API KEY` nos endpoints. Ref: https://learning.postman.com/docs/sending-requests/authorization/#api-key
- **Diferencial 4** Descrever a documenta��o da API utilizando o conceito de Open API 3.0;

## Readme do Reposit�rio

- Deve conter o t�tulo do projeto
- Uma descri��o sobre o projeto em frase
- Deve conter uma lista com linguagem, framework e/ou tecnologias usadas
- Como instalar e usar o projeto (instru��es)
- N�o esque�a o [.gitignore](https://www.toptal.com/developers/gitignore)
- Se est� usando github pessoal, referencie que � um challenge by coodesh 


## Refer�ncia

[Challenge](https://lab.coodesh.com/public-challenges/back-end-challenge-2021/-/tree/master)  
[Randon User Generator](https://randomuser.me/documentation)  
[Schedule a Background Task](https://stackoverflow.com/questions/63795334/in-asp-net-core-3-1-how-can-i-schedule-a-background-task-cron-jobs-with-hoste)  
