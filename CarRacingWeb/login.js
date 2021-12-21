var sql = require('mssql');
var express = require('express');
var session = require('express-session');
var bodyParser = require('body-parser');
var path = require('path');

var config = {
    user: 'sa',
    password: 'talasamset2804',
    server: 'localhost',
    database: 'CarRacingGameDB'
};

var app = express();

app.use(express.static('public'))

app.use(session({
	secret: 'secret',
	resave: true,
	saveUninitialized: true
}));

app.set('view','./public/view');
app.set('view engine', 'ejs');
app.use(bodyParser.urlencoded({extended: true}));
app.use(bodyParser.json());
app.use(bodyParser.text());

app.get('/', function(req, res) {
    res.sendFile(path.join(__dirname + '/login.html'));
});

app.post('/auth', function(req,res){
    var username = req.body.username;
    var password = req.body.password;
    var confirm = req.body.confirmPassword;
    
    if(confirm == password){
        sql.connect(config, (err) => {
            if(err) console.log(err);

            var request = new sql.Request();
            let cmd = `INSERT INTO CARUSER (id_user,UserName,Password,CharacterLevel,CurrentCoin,CurrentExp,ExpLevelUp,BestScore,CurrentCar) VALUES ('${username}ID','${username}','${password}',1,0,0,500,0,'1')`;

            request.query(cmd,function(error,result){
                if(error) {
                    res.send('This username has already taken');
                } else {
                res.send("Sign Up success! Let's start game");
                }

                res.end();
            });
        });  
    } else {
        res.redirect('/');
        res.end();
    }
});

app.listen(8000);
