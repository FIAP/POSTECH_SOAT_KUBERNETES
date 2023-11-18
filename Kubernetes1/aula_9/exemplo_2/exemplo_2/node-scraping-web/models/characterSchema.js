var mongoose = require('mongoose');
var Schema = mongoose.Schema;

var CharacterSchema = new Schema({
    name: String,
    thumb: String
});

module.exports = CharacterSchema;