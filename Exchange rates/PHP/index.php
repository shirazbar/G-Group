<?php
require_once 'X_Rates.php';
if(isset($_GET['amount']) and isset($_GET['from']) and isset($_GET['to'])){
    $object = new X_Rates($_GET['amount'], $_GET['from'], $_GET['to']);
    echo json_encode($object);
}
else {
    echo 'Server Error';
}
?>