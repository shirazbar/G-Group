<?php

/**
 * Created by PhpStorm.
 * User: Futurlena
 * Date: 24-Apr-17
 * Time: 10:22
 */
class Calculator
{
    var $result;
    var $calc;

    public function __construct($calc)
    {
        $url = "https://www.calcatraz.com/calculator/api?c=?{$calc}";
        $json_string = file_get_contents($url);
        $this->result = $json_string;
    }

}