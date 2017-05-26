<?php

require_once 'clock.php';

if(isset($_GET['timeZone'])){
    $object = new MyTime($_GET['timeZone']);
	if($object !=NULL){
		echo json_encode($object);
		
	}
	else{
		$time3 = new MyTime('Israel'); 
		//echo json_encode($time3 ); 
	
	}		
		
}else {
	$time3 = new MyTime('Israel'); 
	
}

?>