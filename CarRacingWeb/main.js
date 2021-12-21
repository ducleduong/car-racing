var express = require('express');
var session = require('express-session');
var bodyParser = require('body-parser');
var controller = require('./controller/Controller');
var proccessor = require('./validation-middleware/validation');
var cookieParser = require('cookie-parser')

var app = express();

app.use(express.static('public'));
app.use(cookieParser('secret'));

app.use(session({
	secret: 'secret',
	resave: true,
	saveUninitialized: true
}));

app.set('views','./views/site');
app.set('view engine', 'pug');
app.use(bodyParser.urlencoded({extended: true}));
app.use(bodyParser.json());
app.use(bodyParser.text());

app.get('/', controller.index);
app.get('/regi' , controller.getPageRegister);
app.get('/login', controller.getPageLogin);
app.get('/auth', controller.indexLog);
app.get('/logout', controller.logout);

app.post('/error',proccessor.proccessRegister ,controller.register);
app.post('/errorlog',proccessor.processLogin,controller.login);

app.listen(8000,function(){
    console.log("Server is running...");
});
