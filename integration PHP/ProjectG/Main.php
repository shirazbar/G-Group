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
        if ($req->input('register') != null){
            $uname = $req->input('UserName');
            $umail = $req->input('UserMail');
            $upass = $req->input('UserPassword');

            if ($uname != null && $umail != null && $upass != null)
            {
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
                else if(!preg_match('/[0-9]/', $upass))
                    echo "Password must contain at least one number";
                else if(!preg_match('/[A-Z]/', $upass))
                    echo "Password must contain at least one uppercase letter";
                else if(!preg_match('/[a-z]/', $upass))
                    echo "Password must contain at least one lowercase letter";
                else {
                    $user->register($uname, $umail, $upass);
                }
            }
            else
                echo "Please fill all the fields!";
        }
        else if ($req->input('login') != null)
        {
            $uname = $req->input('UserName');
            $upass = $req->input('UserPassword');
            if (!$user->login($uname,$upass))
                echo "User Email / Name does not match the password!";
        }

        if ($req->query('exchange') != null)
        {
            $amount = $req->query('amount');
            $from = $req->query('from');
            $to = $req->query('to');
            if ($amount != null && $from != null && $to != null) {
                require_once 'ExchangeRates.php';
                $exchange = new ExchangeRates($amount, $from, $to);
                echo json_encode($exchange);
            }
            else {
                echo 'Server Error';
            }
        }

        if($req->query('calc') != null)
        {
            require_once 'Calculator.php';
            $object = new Calculator($_GET['calc']);
            echo json_encode($object);
        }

    }
}