
var mongoose = require('mongoose');
BattlesSchema = require('../models/battles');

var Battles = mongoose.model('battles', BattlesSchema);
module.exports = Battles;