const express = require('express');
const cors = require('cors');

const app = express();

// Enable CORS for all routes
app.use(cors());

app.get('/api/curso', (req, res) => {
    res.send({ message: 'seja bem vindo(a)!' });
});

app.listen(3000, () => {
    console.log('Listening on port 3000');
});
