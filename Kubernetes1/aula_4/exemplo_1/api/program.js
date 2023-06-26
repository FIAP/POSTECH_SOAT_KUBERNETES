const express = require('express')
const app = express()
const port = 3000

app.get('/lista', function (req, res) {

    var nomes = ['João', 'Maria', 'Pedro'];
    let indice_aleatorio = Math.floor(Math.random() * nomes.length);
    let valor_aleatorio = nomes[indice_aleatorio];
    let result = {nome : valor_aleatorio }

    res.send(result);
});

app.listen(port, () => {
    console.log(`Example app listening on port ${port}`)
})
