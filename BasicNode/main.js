fs = require('fs');

fs.readdir('C:/', function (err, files) {
    if (err) {
        console.log(err);
        return;
    }
    console.log(files.length);
});

