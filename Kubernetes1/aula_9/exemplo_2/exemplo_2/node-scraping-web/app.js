var request = require("request");
var uuid = require('uuid');

var helper = require("./infra/helper");

let url = 'https://dog.ceo/api/breeds/image/random';


request.get(url, (error, response, body) => {
    if (error) {
        return console.dir(error);
    }
    let urlImage = JSON.parse(body).message;
    console.log(urlImage);
    console.log(urlImage.substring(urlImage.lastIndexOf('/')+1));
   // helper.downloadImageToUrl(JSON.parse(body).message, "./temp/" + uuidv1())
});

