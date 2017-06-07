<?php


class Flickr_api{
	
	private $api_key = "e7be20e0bfb5f38a408bf5c1cf480bc2";
	private $url= "";
	private $data;
	private $images = array();
	
	
	public function __construct($word){
		$this->data = array();
		$this->url ='https://api.flickr.com/services/rest/'.
					'?method=flickr.photos.search' .
					'&api_key='.$this->api_key.
					'&text='.$word. 
					'&format=json'.
					'&nojsoncallback=1';
		
		$json_string = @file_get_contents($this->url);
		$json_parse = json_decode($json_string,true);
		
		
		for($i =0 ; $i < count($json_parse['photos']['photo']);$i++){
			//build a dictionary of the necessary data to get the image url.
			$this->data[$i] = [
				"farm" => $json_parse['photos']['photo'][$i]['farm'],
				"server" => $json_parse['photos']['photo'][$i]['server'],
				"id" => $json_parse['photos']['photo'][$i]['id'],
				"secret" => $json_parse['photos']['photo'][$i]['secret']
			];
			//make array of strings, each string contain url of an image.
			$this->images['image'.$i.''] = 'http://farm'.$this->data[$i]['farm'].
								'.staticflickr.com/'.$this->data[$i]['server'].'/'
								.$this->data[$i]['id'].'_'.$this->data[$i]['secret'].'_n.jpg';
		}
		
	}
	public function GetJsonData(){
		return json_encode($this->data);	
	}
	
	public function GetImagesArray(){
		return json_encode($this->images);
		
	}
	
}
?>