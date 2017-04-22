<?php

class news{
    private $url =['bbc' => 'http://newsapi.org/v1/articles?source=bbc-news&sortBy=top&apiKey=3bb7b1e020f94de4a17f166b009fbc7f',
                    'abc' => 'http://newsapi.org/v1/articles?source=abc-news-au&sortBy=top&apiKey=3bb7b1e020f94de4a17f166b009fbc7f',
                    'newyork' => 'https://newsapi.org/v1/articles?source=the-new-york-times&sortBy=top&apiKey=3bb7b1e020f94de4a17f166b009fbc7f',
                    'mtv'=> 'https://newsapi.org/v1/articles?source=mtv-news&sortBy=top&apiKey=3bb7b1e020f94de4a17f166b009fbc7f'];
    private $nObj=array();
    private $result;
    public function __construct()
    {
        $this->JSON();
    }
    public function getObj(){
        return $this->result;
    }

    public function __destruct()
    {
        // TODO: Implement __destruct() method.
    }

    private function JSON(){
        $url ="";
        if(isset($_GET['source']))
           switch ($_GET['source']) {
               case "bbc":
                   $url = $this->url['bbc'];
                   break;
               case"foxnews":
                   $url = $this->url['foxnews'];
           }
        $this->result = file_get_contents($url,0);
    }
}