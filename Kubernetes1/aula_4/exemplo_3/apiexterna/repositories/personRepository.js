'use strict';
var Person = require('../config/db');

module.exports = new class PersonRepository {
    getAll() {
        return Person.find();
    }    
}

