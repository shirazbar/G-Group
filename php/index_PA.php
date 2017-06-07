<?php
require_once 'Flickr_api.php';
if(isset($_GET['word'])){
    $object = new Flickr_api($_GET['word']);
	echo $object->GetImagesArray();
}
?>