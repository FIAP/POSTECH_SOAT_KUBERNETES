# Projeto .NET - Conexão com a API do Kubernetes

Este projeto .NET fornece uma API RESTful para interagir com o cluster do Kubernetes. Ele expõe endpoints para recuperar informações sobre eventos, pods, serviços e detalhes específicos do pod e do serviço.

## Pré-requisitos
* .NET 8 SDK
* Kubernetes (local ou remoto)


## Uso
Compile e execute a API:


```
dotnet build
dotnet run
```

A API estará disponível em http://localhost:5000 ou https://localhost:5001.

## Endpoints

### BuscarEventos
* Método: GET
* URL: /KubernetesController/BuscarEventos


### BuscarDescricaoDePod
* Método: GET
* URL: /KubernetesController/BuscarDescricaoDePod?podName=<podName>

### BuscarPods
* Método: GET
* URL: /KubernetesController/BuscarPods

### BuscarServices
* Método: GET
* URL: /KubernetesController/BuscarServices

### BuscarNomeDosContainers
* Método: GET
* URL: /KubernetesController/BuscarNomeDeContainers?podName=<podName>

### BuscarServiceDetails
* Método: GET
* URL: /KubernetesController/BuscarServiceDetails?serviceName=<serviceName>


## Licença
Este projeto está licenciado sob a licença MIT. Consulte o arquivo LICENSE para obter detalhes.
