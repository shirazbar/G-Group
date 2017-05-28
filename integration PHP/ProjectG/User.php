<?php

class User
{
    private $conn;

    public function __construct()
    {
        require_once("Database.php");
        $database = new Database();
        $db = $database->dbConnection();
        $this->conn = $db;
    }

    public function getConn()
    {
        return $this->conn;
    }

    public function runQuery($sql)
    {
                $stmt = $this->conn->prepare($sql);
        return $stmt;
    }

    public function register($uname,$umail,$upass)
    {
        try{
            $req = $this->conn->prepare("INSERT INTO users(UserName,UserMail,UserPassword) 
                                        VALUES(:UserName,:UserMail,:UserPassword)");
            $req->execute(array(
                'UserName' => $uname,
                'UserMail' => $umail,
                'UserPassword' => sha1($upass)
            ));
            echo "Successfully registered";
        }
        catch(PDOException $e)
        {
            echo $e->getMessage();
        }
    }
    public function login($uname,$upass)
    {
        try {
            $req = $this->conn->prepare("SELECT UserId,UserName,UserMail,UserPassword FROM users
                                     WHERE UserName=:UserName OR UserMail=:UserMail");
            $req->execute(array(
                'UserName' => $uname,
                'UserMail' => $uname
            ));
            $userRow = $req->fetch(PDO::FETCH_ASSOC);
            if ($req->rowCount() == 1) {
//                echo sha1($upass);
//                echo "\n";
//                echo $userRow['UserPassword'];
//                echo "\n";
                //if (password_verify($upass,$userRow['UserPassword'])){
                if (sha1($upass) == $userRow['UserPassword']) {
                    $_SESSION['UserSession'] = $userRow['UserId'];
                    echo $userRow['UserName'];
                    return true;
                }
                else {
                    return false;
                }
            }
        } catch (PDOException $e){
            echo "Something went wrong!";
        }
    }
}