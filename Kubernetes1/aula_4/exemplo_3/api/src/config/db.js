require('dotenv').config();

var mongoose = require('mongoose');
const mongoUrl = process.env.MONGO_URL;

mongoose.connect(mongoUrl);

var Schema = mongoose.Schema;

var PersonSchema = new Schema({
    name: String,
    mail: String,
    role: String
});


var Person = mongoose.model('Person', PersonSchema);
module.exports = Person;

