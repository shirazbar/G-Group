<?php

/**
 * Created by PhpStorm.
 * User: Shiraz
 * Date: 24/04/2017
 * Time: 11:40
 */
class Request
{
    function __construct(){
    }

    function input($arg){
        if (isset($_POST[$arg]))
        {
            return $_POST[$arg];
        }
        else
            return null;
    }

    function query($arg){
        if (isset($_GET[$arg]))
        {
            return $_GET[$arg];
        }
        else
            return null;
    }


}