<?php

require_once 'clock.php';

if(isset($_GET['timeZone'])){
    $object = new MyTime($_GET['timeZone']);	
		
}else {
	$time3 = new MyTime('Israel'); 
	
}

?>