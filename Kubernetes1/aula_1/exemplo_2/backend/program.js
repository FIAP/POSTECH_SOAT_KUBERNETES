const express = require('express');
const redis = require('redis');
const cors = require('cors');

const app = express();
app.use(cors());

const client = redis.createClient({
    host: 'redis-server',
    port: 6379
});

client.set('visits', 0);

app.get('/visits', (req, res) => {
    client.get('visits', (err, visits) => {
        res.send({ message: `Numero de visitantes:  ${visits}` });
    });
});

app.get('/api/curso', (req, res) => {

    client.get('visits', (err, visits) => {
        client.set('visits', parseInt(visits) + 1);
    });

    res.send({ message: 'Seja bem vindo(a)!' });
});


app.listen(3000, () => {
    console.log('Listening on port 3000');
});