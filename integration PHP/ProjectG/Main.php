<?php

/**
 * Created by PhpStorm.
 * User: Shiraz
 * Date: 28/04/2017
 * Time: 12:06
 */
class Main
{
    public function __construct(){
    }

    /**
     *
     */
    public function run()
    {
        // (new Request())->input('password')
        require_once("User.php");
        $user = new User();
        require_once('Request.php');
        $req = new Request();
        if ($req->Postinput('register') != null){
            $uname = $req->Postinput('UserName');
            $umail = $req->Postinput('UserMail');
            $upass = $req->Postinput('UserPassword');

            if ($uname != null && $umail != null && $upass != null) {
                $stmt = $user->getConn()->prepare("SELECT UserName,UserMail FROM users WHERE UserName=:UserName OR UserMail=:UserMail");
                $stmt->execute(array(':UserName'=>$uname, ':UserMail'=>$umail));
                $row=$stmt->fetch(PDO::FETCH_ASSOC);
                if($row['UserName']==$uname) {
                    echo "Username is already taken";
                }
                else if($row['UserMail']==$umail) {
                    echo "Email id is already taken";
                }
                else if (!filter_var($umail, FILTER_VALIDATE_EMAIL)) {
                    echo "Invalid Email!";
                }
                else if (strlen($upass) < 6) {
                    echo "Password must has at least 6 characters";
                }
                else {
                    $user->register($uname, $umail, $upass);
                }
            }
        }
        else if ($req->Postinput('login') != null)
        {
            $uname = $req->Postinput('UserName');
            $upass = $req->Postinput('UserPassword');
            if (!$user->login($uname,$upass))
                echo "User Email / Name does not match the password!";
        }

        if ($req->Getinput('exchange') != null)
        {
            $amount = $req->Getinput('amount');
            $from = $req->Getinput('from');
            $to = $req->Getinput('to');
            if ($amount != null && $from != null && $to != null) {
                require_once 'ExchangeRates.php';
                $exchange = new ExchangeRates($amount, $from, $to);
                echo json_encode($exchange);
            }
            else {
                echo 'Server Error';
            }
        }

    }
}