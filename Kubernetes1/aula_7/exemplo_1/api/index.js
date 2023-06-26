const express = require('express');
const app = express();

app.get('/health', (req, res) => {
  res.status(200).json({ status: 'OK' });
});

app.listen(3000, () => {
  console.log('Servidor iniciado na porta 3000');
});