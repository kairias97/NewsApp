'use strict';
const path = require('path');
const port = process.env.PORT || 1337;
const express = require('express');
const app = express();

app.get('/app/*', function (req, res) {
    res.sendFile(path.join(__dirname, 'app', req.params[0]));
})
    .get('/*', function (req, res) {
    res.sendFile(path.join(__dirname, 'public','index.html'));
}).listen(port, function () {
    console.log(`Listening in port: ${port}`);
});
