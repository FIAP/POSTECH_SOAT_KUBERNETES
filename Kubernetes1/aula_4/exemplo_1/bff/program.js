const express = require('express')
const axios = require('axios')

const app = express()
const port = 3010

app.get('/lista', async function(req, res) {
    try {
      const response = await axios.get('http://localhost:3000/lista');
      const dados = response.data;
      
      res.send(dados);
    } catch (error) {
      console.error(error);
      res.status(500).send('Erro ao buscar dados');
    }
  });

app.listen(port, () => {
    console.log(`Example app listening on port ${port}`)
})
