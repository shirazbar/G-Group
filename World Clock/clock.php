<?php
header('Content-Type: text/plain; charset=utf-8;');
class MyTime{
	protected  $hours;
	protected  $minutes;
	protected  $seconds;
	protected  $path;
	protected  $d=array();
	public function  __construct($value){
		$basicPath="https://script.google.com/macros/s/AKfycbyd5AcbAnWi2Yn0xhFRbyzS4qMq1VucMVgVvhul5XqS9HkAyJY/exec";
		if(isset($value)){
			$newPath=$basicPath."?tz=".$value;
		}else{
			echo "value not set";
		}
		$file = file_get_contents($newPath);
		$myItem=json_decode($file, true);
	
		$this->d["hours"]=$myItem["hours"];
		$this->d["minutes"]= $myItem["minutes"];
		$this->d["seconds"]=$myItem["seconds"];
		echo $this;
		
		
	}
	public function __toString(){
	
		return json_encode($this->d);
	}	
	
	
	public function getTime(){
		if(isset($hours)&&isset($minutes) &&isset($seconds)){
			return $hours.':'.$minutes.':'.$seconds ;
		}
		return $this->hours.':'.$this->minutes.':'.$this->seconds;
	}
	
	
	
}




?> 
