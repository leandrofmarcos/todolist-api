# TodoList API

Esta é uma API de TodoList que permite gerenciar tarefas (todos). A aplicação é desenvolvida em .NET Core e utiliza o Entity Framework Core com banco de dados SQLite.

## Configuração

Certifique-se de ter o SDK do .NET Core instalado em sua máquina.

1. Clone o repositório:
    ```
    git clone https://github.com/seu-usuario/todo-list-api.git
    ```

2. Navegue para o diretório do projeto:
    ```
    cd todo-list-api
    ```

3. Execute a aplicação:
    ```
    dotnet run
    ```

A API estará acessível em http://localhost:5000 ou https://localhost:5001.

## Documentação e Teste da API

A API está documentada e pode ser testada utilizando o Swagger. Para acessar o Swagger, abra o seu navegador e navegue para a seguinte URL:

O Swagger fornece uma interface interativa onde você pode visualizar e testar todos os endpoints disponíveis na API. Você pode enviar requisições e ver as respostas em tempo real, facilitando o desenvolvimento e o teste da aplicação.

## Endpoints

| Método | Endpoint                  | Descrição                              |
|--------|---------------------------|----------------------------------------|
| GET    | /api/todos                | Retorna todos os todos                  |
| GET    | /api/todos/{id}           | Retorna um todo específico pelo ID      |
| POST   | /api/todos                | Adiciona um novo todo                   |
| PUT    | /api/todos/{id}/description | Atualiza a descrição de um todo         |
| PATCH  | /api/todos/{id}/complete  | Marca um todo como concluído            |
| PATCH  | /api/todos/{id}/incomplete | Marca um todo como não concluído        |
| DELETE | /api/todos/{id}           | Remove um todo específico pelo ID       |

## Task

- [ ] Melhorar a validação dos dados recebidos

## Roadmap

Aqui está o roadmap planejado para futuras versões da aplicação:

- Versão 1.1:
    - Adicionar suporte a tags nos todos
    - Implementar pesquisa de todos por tags

## Contribuição

Contribuições são bem-vindas! Sinta-se à vontade para abrir issues e enviar pull requests.

## Licença

Este projeto está licenciado sob a [MIT License](LICENSE).
