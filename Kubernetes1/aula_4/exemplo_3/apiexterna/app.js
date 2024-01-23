const express = require('express');

const app = express();
const personRepository = require('./repositories/personRepository');

app.get('/person', (req, res) => {
    personRepository.getAll()
    .then((person) => {    
        console.log(person)    
        res.status(200).send(person);
    }).catch(err => res.status(500).send(err))    
});


app.listen(3000, () => {
  console.log('Servidor Express rodando na porta 3000');
});