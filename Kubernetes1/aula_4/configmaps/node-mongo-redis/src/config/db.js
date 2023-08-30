var mongoose = require('mongoose');
mongoose.connect('mongodb://127.0.0.1/db_employees');

var Schema = mongoose.Schema;

var PersonSchema = new Schema({
    name: String,
    mail: String,
    role: String
});


var Person = mongoose.model('Person', PersonSchema);
module.exports = Person;

