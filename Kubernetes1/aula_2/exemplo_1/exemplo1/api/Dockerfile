# Imagem base do Node.js
FROM node:14-alpine

# Diretório de trabalho da aplicação
WORKDIR /app

# Copiar o arquivo package.json para o diretório de trabalho
COPY package*.json ./

# Instalar as dependências
RUN npm install

# Copiar o código-fonte para o diretório de trabalho
COPY . .

# Porta que a aplicação escuta
EXPOSE 3000

# Comando para iniciar a aplicação
CMD [ "npm", "start" ]