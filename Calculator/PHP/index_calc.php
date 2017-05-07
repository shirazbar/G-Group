<?php
/**
 * Created by PhpStorm.
 * User: Futurlena
 * Date: 24-Apr-17
 * Time: 10:22
 */
require_once 'Calculator.php';
if(isset($_GET['calc'])) {
    $object = new Calculator($_GET['calc']);
    echo json_encode($object);
}
?>