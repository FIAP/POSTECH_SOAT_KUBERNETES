FROM node:14

ENV MONGO_URL=""
ENV REDIS_URL=""

WORKDIR /usr/src/app

COPY package*.json ./

RUN npm install

COPY . .

EXPOSE 3000
CMD [ "npm","start" ]