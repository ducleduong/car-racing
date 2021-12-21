var sql = require('mssql');
const db = require('../db');

module.exports.getPageLogin = function(req,res){
    res.render('login.pug');
}

module.exports.login = function(req,res){
    res.redirect('/auth');
}

module.exports.getPageRegister = function(req, res) {
    res.render('register.pug');
}

module.exports.register = function(req,res){
    let username = req.body.username;

   res.cookie('id',`${username}ID`,{signed: true});
   res.redirect('/auth');
}

module.exports.indexLog = async function(req,res){
    if(!req.signedCookies.id){
        res.redirect('/login');
    } else {
        let results = await db.getRanking();
        sql.connect(db.config,(err) => {
            if(err) throw err;
            var request = new sql.Request();
            let idUser = req.signedCookies.id;
            let cmd = `SELECT CharacterLevel,UserName,CurrentCoin FROM CARUSER WHERE id_user = '${idUser}'`;
            request.query(cmd,function(err,result){
                if(err) throw err;
                
                res.render('index-logged.pug',{
                    username: result.recordset[0].UserName.trim(),
                        level: result.recordset[0].CharacterLevel,
                        coin: result.recordset[0].CurrentCoin,
                        result: results
                    });
            });
        });
    }
}

module.exports.index = async function(req,res){
    let result = await db.getRanking();
    if(!req.signedCookies.id){
    res.render('index.pug',{result});
    } else {
        res.redirect('/auth');
    }

    
}

module.exports.logout = function(req,res){
    res.clearCookie('id');
    res.redirect('/');
}