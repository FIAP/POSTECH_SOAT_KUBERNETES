'use strict';
var Person = require('../config/db');


module.exports = new class PersonRepository {

    getAll() {
        return Person.find();
    }

    getById(id) {
        return Person.findById(id);
    }

    create(person) {
        return Person.create(person);
    }

    update(id, person) {

        const updatedperson = {
            name: person.name,
            mail: person.mail,
            role: person.role,
        }

        return Person.findByIdAndUpdate(id, updatedperson);
    }

    delete(id) {
        return Person.findByIdAndRemove(id);
    }
}

