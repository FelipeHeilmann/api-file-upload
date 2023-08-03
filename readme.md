# API ASP.NET com Microsoft Azure

Esta é uma API desenvolvida em ASP.NET que utiliza o Microsoft Azure para armazenar e recuperar arquivos. A API possui duas rotas principais:

## Rota `api/file` - POST

Esta rota é utilizada para enviar um arquivo para a API. O arquivo será armazenado no Microsoft Azure e o nome do arquivo será retornado como resposta.

### Requisição

POST /api/file


**Corpo da Requisição:** Envie o arquivo como um formulário de dados (`multipart/form-data`) com a chave `ImageFile`.

### Resposta

```json
{
  "ImageFile": "nome_do_arquivo.extensao"
}
```


## Rota `api/file` - GET
Esta rota é utilizada para recuperar o arquivo previamente enviado através do nome retornado pela rota POST. O arquivo será baixado em seu formato original.

### Requisição

GET /api/file?name=nome_do_arquivo.extensao

Resposta
O arquivo será baixado automaticamente pelo navegador.

## Configuração do Microsoft Azure
Esta API utiliza o Microsoft Azure como armazenamento de arquivos. Certifique-se de ter uma conta ativa no Microsoft Azure e configurar as chaves de acesso corretamente na aplicação ASP.NET.

## Executando a API
Para executar a API localmente, siga os passos abaixo:

1. Certifique-se de ter o SDK do .NET Core instalado em sua máquina.
2. Clone este repositório em seu ambiente de desenvolvimento.
3. Configure as chaves e string de conexão ao Microsoft Azure na aplicação.
4. Execute o comando dotnet run no terminal dentro do diretório do projeto.
5. A API estará disponível em http://localhost:porta/api/file.

1. Certifique-se de ter o SDK do .NET Core instalado em sua máquina.
2. Clone este repositório em seu ambiente de desenvolvimento.
3. Configure as chaves e string de conexão ao Microsoft Azure na aplicação.
4. Execute o comando dotnet run no terminal dentro do diretório do projeto.
5. A API estará disponível em http://localhost:porta/api/file.
