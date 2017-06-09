<?php

/**
 * Memos class
 * The class gets the memos info from the database and echoes it
 * Created by PhpStorm.
 * User: orcohen125
 * Date: 10/05/2017
 * Time: 15:29
 */
class Memos {
    public $arr=array();

    /**
     * Memos constructor.
     * Getting data from database function.
     */
    public function __construct() {
        $mysqli = new mysqli("localhost", "root", "", "g_group"); //create the connection with the database
        if ($result = $mysqli->query("SELECT * FROM memos")) { //result gets the whole information from the table in database
            $i=0; //place in lines of database array ($arr)
            while ($line=$result->fetch_object()) { //line object is a line in the database
                $this->arr[$i]=$line;
                $i++;
            }
        }
        echo $this;
    }

    /**
     * @return string
     *              json representation of the memos array.
     */
    public function __toString() {
       return json_encode($this->arr);
    }
}

?>