var mongoose = require('mongoose');
CharacterSchema = require('../models/characterSchema');

var CharacterRepository = mongoose.model('character', CharacterSchema);
module.exports = CharacterRepository;