<?php
/*$json=file_get_contents("memos.json");
$jsonIterator = new RecursiveIteratorIterator(
    new RecursiveArrayIterator(json_decode($json, TRUE)),
    RecursiveIteratorIterator::SELF_FIRST);*/

class Memos {
    public $title = "";
    public $content  = "";
    public $time = "";
    public $arr=Array();

    public $i=0;
    public $j=0;


    public function __construct($title,$content,$time)
    {

//
//        $db=new mysqli('localhost','root','','g_group');
//        $this->title=$title;
//        $this->content=$content;
//        $this->time=$time;
//
//        $result=mysqli_query($db,'SELECT * FROM memos');
//        echo print_r(mysqli_fetch_array($result));


        $mysqli = new mysqli("localhost", "root", "", "g_group");
        if ($result = $mysqli->query("SELECT * FROM memos")) {

            //print_r($result->fetch_assoc());
            while ($result->fetch_object()) {
                $this->arr[]=$result->fetch_assoc();
                //print_r($result->fetch_assoc());
                $this->i++;
            }

            while($this->j<$this->i) {
                echo print_r($this->arr[$this->j]);
                //print_r($this->arr[$this->j]);
                $this->j++;
            }
            //print($this->arr);
            //print($this->arr.strval());

        }
    }
}

/*$arr=new ArrayIterator();
$e=new Memos();
$counter=0; //the current place in the created array
foreach ($jsonIterator as $key => $val) {
    if(is_array($val) and $key==0) { //first item in the memos array
        $counter=$counter++;
        $e=new Memos();
        //echo "$key:\n";
    } else if(is_array($val)) { //new memo in the memos array
        $counter=$counter++;
        $e=new Memos();
        //echo "$key:\n";
    } else if($key=="title") {
        $e->title=$val;
        //echo "$key => $val\n";
    } else if($key=="content") {
        $e->content = $val;
        //echo "$key => $val\n";
    } else if($key=="time") {
        $e->time=$val;
        //echo "$key => $val\n";
        if(($counter+1)==$jsonIterator->getDepth()) { //for ending the current memo and append it to the memos array
            $arr->append($e);
            //echo json_encode($e);
        }
    }
}
echo json_encode($arr); //printing the whole array of memos*/

?>