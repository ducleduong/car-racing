const sql = require('mssql');

module.exports.config = {
    user: 'sa',
    password: 'talasamset2804',
    server: 'localhost',
    database: 'CarRacingGameDB'
}

module.exports.getRanking = function (){ 
    return new Promise((res,rej) => {
        sql.connect(this.config,(err) => {
            if(err) throw err;

            var request = new sql.Request();
            cmd = `SELECT TOP 8 UserName,BestScore FROM CARUSER ORDER BY BestScore DESC`;
            request.query(cmd,function(err,result){
                if(err) 
                    res(err);
                else
                    res(result.recordset);
            });
        });
    });
}