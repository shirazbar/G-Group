<?php

/**
 * Created by PhpStorm.
 * User: Futurlena
 * Date: 21-Apr-17
 * Time: 11:52
 */
class X_Rates
{
    var $result;

    public function __construct($amount, $from, $to)
    {
        $url = "http://api.fixer.io/latest?base={$from}";
        $amount = (float) $amount;
        $json_string = file_get_contents($url);
        $json_array = (array) json_decode($json_string);
        $rates_to = $json_array['rates']->{$to};
        $this->result = $amount * $rates_to;
    }
     public function get_Result()
     {
         return $this->result;
     }
}

