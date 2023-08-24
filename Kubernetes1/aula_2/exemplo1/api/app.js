const express = require('express');
const bodyParser = require('body-parser');
const UserRepository = require('./userRepository');
const cors = require('cors');

const app = express();

app.use(bodyParser.urlencoded({ extended: false }));
app.use(bodyParser.json());
app.use(cors());

app.get('/', (req, res) => {
    res.status(200).json({ message: 'Health' });
});


app.post('/cadastrar', (req, res) => {
    const { name, email, birthday } = req.body;

    const userRepository = new UserRepository;
    var resultado = userRepository.save(name, email, birthday)
    console.log(`resultado ${resultado.idade}`);
    if (isNaN(resultado.idade)) {
        //throw new Error('Preecha o campo corretamente');
        process.exit(500)
    }

    res.status(200).json({ message: resultado });
});


module.exports = app;