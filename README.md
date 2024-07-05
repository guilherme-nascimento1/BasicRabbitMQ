# RabbitMQ Simple Messenger

This is a simple C# messaging project using RabbitMQ. It demonstrates how to create a producer (Send) that sends messages to a queue and a consumer (Receive) that receives and processes those messages.

## Requirements

- .NET Core SDK
- RabbitMQ Server

## Configuração

### 1. Clone o Repositório

```bash
git clone https://github.com/seu-usuario/RabbitMQSimpleMessenger.git
cd RabbitMQSimpleMessenger

Instale as Dependências

dotnet add Send/Send.csproj package RabbitMQ.Client
dotnet add Receive/Receive.csproj package RabbitMQ.Client


```
### 2. Instale as Dependências
Certifique-se de que você tenha o RabbitMQ Client instalado em ambos os projetos (Send e Receive).

```
dotnet add Send/Send.csproj package RabbitMQ.Client
dotnet add Receive/Receive.csproj package RabbitMQ.Client

```
### 3. Execute o RabbitMQ Server
Certifique-se de que o RabbitMQ Server está em execução na sua máquina local (localhost).

Como Executar
Produtor (Send)
Para executar o produtor que envia mensagens para a fila RabbitMQ, navegue até a pasta Send e execute o comando:

```
cd Send
dotnet run

```
Consumidor (Receive)
Para executar o consumidor que recebe mensagens da fila RabbitMQ, navegue até a pasta Receive e execute o comando:
```
cd Receive
dotnet run
