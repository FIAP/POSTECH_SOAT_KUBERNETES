const axios = require('axios');
const fs = require('fs');
 

exports.downloadImageToUrl = (url, filename) => {

const imageUrl = url;
const imagePath = `./uploads/${filename}`; 

axios
  .get(imageUrl, { responseType: 'stream' })
  .then((response) => {
    response.data.pipe(fs.createWriteStream(imagePath))
      .on('finish', () => {
        console.log('Image downloaded successfully.');
      })
      .on('error', (error) => {
        console.error('Error occurred while downloading the image:', error);
      });
  })
  .catch((error) => {
    console.error('Error occurred while fetching the image:', error);
  });
    
};