const db = require('./config/db');
const battleRepository = require('./repository/battleRepository');

const csv = require('csv-parser');
const fs = require('fs');

fs.createReadStream('./battles.csv')
    .pipe(csv())
    .on('data', (row) => {
        battleRepository.create(row);
    })
    .on('end', () => {
        console.log('CSV file successfully processed')
    });