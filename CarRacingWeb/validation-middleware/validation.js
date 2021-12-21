const sql = require('mssql');
const db = require('../db');


module.exports.processLogin = function(req,res,next){
    let username = req.body.username;
    let password = req.body.password;

    sql.connect(db.config,(err) => {
        if(err) throw err;

        let request = new sql.Request();
        let cmd = `SELECT id_user FROM CARUSER WHERE UserName = '${username}' AND Password = '${password}'`;

        request.query(cmd,function(err,result){
            if(result.recordset.length > 0){
                res.cookie('id',result.recordset[0].id_user,{signed: true});
                next();
            } else {
                res.render('login.pug',{
                    errMess: 'Incorrect Username or Password'
                });
            }
        });
    });

}

module.exports.proccessRegister = function(req,res,next){
    let username = req.body.username;
    let password = req.body.password;
    let confirm = req.body.confirmPassword;

    if(confirm === password){
        sql.connect(db.config, (err) => {
            if(err) console.log(err);

            let request = new sql.Request();
            let cmd = `INSERT INTO CARUSER (id_user,UserName,Password,CharacterLevel,CurrentCoin,CurrentExp,ExpLevelUp,BestScore,CurrentCar) VALUES ('${username}ID','${username}','${password}',1,0,0,500,0,'1')`;

            request.query(cmd,function(error,result){
                if(error) {
                    res.render('register.pug',{
                        errMess: 'This username is already taken'
                    });
                    return;
                }
            });
            request.query(`INSERT INTO USER_CAR (id_user,id_car) VALUES ('${username}ID','1')`);
        }); 
    }

    if(confirm !== password){ 
        res.redirect('/regi');
        return;
    }

    next();
}
