# Introduction

Este repositório contém uma aplicação Node.js que expõe um servidor web com métricas do Prometheus. Ele foi criado como um exemplo de como monitorar uma aplicação Node.js usando o Prometheus e o Grafana com Docker.



# Requisitos

* Docker
* Docker Compose

# Começando

```
docker-compose up
```

* Acesse a aplicação em http://localhost:3000
* Acesse o Prometheus em http://localhost:9090
* Acesse o Grafana em http://localhost:3001 e faça login com as credenciais padrão (usuário: admin, senha: admin)
* Configure uma fonte de dados do Prometheus no Grafana usando a URL http://prometheus:9090
* Importe o painel de amostra grafana/dashboards/nodejs-app.json para o Grafana.

# Detalhes

A aplicação é um simples servidor web Node.js que exibe uma mensagem "Hello World!" na rota raiz (/) e expõe métricas do Prometheus na rota /metrics.

As métricas do Prometheus são criadas usando o cliente Prometheus Node.js. Duas métricas são definidas: myapp_requests_total, que é um contador que incrementa para cada requisição recebida pela aplicação, e myapp_request_duration_seconds, que é um histograma que mede a duração de cada requisição.

O arquivo *docker-compose.yml*  define três serviços:

A aplicação Node.js, que é construída usando o Dockerfile na raiz do repositório.
O Prometheus, que está configurado para coletar métricas da aplicação Node.js e as expõe na porta 9090.
O Grafana, que já está pré-configurado com uma fonte de dados do Prometheus e um painel de amostra que exibe as métricas da aplicação Node.js.

Quando os containers são iniciados usando docker-compose up, a aplicação é exposta na porta 3000, o Prometheus é exposto na porta 9090 e o Grafana é exposto na porta 3001.

# Conclusão

Este repositório fornece um exemplo de como monitorar uma aplicação Node.js usando o Prometheus e o Grafana com Docker. É um ponto de partida que pode ser personalizado e expandido para atender às suas próprias necessidades.