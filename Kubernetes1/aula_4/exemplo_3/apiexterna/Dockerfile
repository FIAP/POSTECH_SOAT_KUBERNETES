FROM node:14

WORKDIR /usr/src/app

COPY package*.json ./

RUN npm install

ENV MONGO_URL="uri"

COPY . .

EXPOSE 3000
CMD [ "node","app.js" ]