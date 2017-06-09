<?php
/**
 * Created by PhpStorm.
 * User: orcohen125
 * Date: 10/05/2017
 * Time: 15:29
 */
if((isset($_GET['action'])and isset($_GET['title']))) { //if there are action of changing the database and title of memo
    require_once 'memosChange.php';
    $mc=new MemosChange(); //creates an object which deals with the memos changes
    if($_GET['action']=='remove') { //removing a memo
        $mc->remove($_GET['title']);
    }
    else if($_GET['action']=='add') { //adding a memo
        $mc->add($_GET['user'],$_GET['title'],$_GET['content'],$_GET['time']);
    }
    else if($_GET['action']=='edit') { //editing and changing a memo
        $mc->edit($_GET['user'],$_GET['title'],$_GET['content'],$_GET['time'],$_GET['oldTitle']);
    }
}
else { //there is not an action and the memos object has to be created
    require_once 'memos.php';
    $memos= new Memos();
}



//}
?>
