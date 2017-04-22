<?php
$json=file_get_contents("memos.json");
$jsonIterator = new RecursiveIteratorIterator(
    new RecursiveArrayIterator(json_decode($json, TRUE)),
    RecursiveIteratorIterator::SELF_FIRST);

class Memos {
    public $title = "";
    public $content  = "";
    public $time = "";
}

$arr=new ArrayIterator();
$e=new Memos();
$counter=0; //the current place in the created array
foreach ($jsonIterator as $key => $val) {
    if(is_array($val) and $key==0) { //first item in the memos array
        $counter=$counter++;
        $e=new Memos();
        echo "$key:\n";
    } else if(is_array($val)) { //new memo in the memos array
        $counter=$counter++;
        $e=new Memos();
        echo "$key:\n";
    } else if($key=="title") {
        $e->title=$val;
        echo "$key => $val\n";
    } else if($key=="content") {
        $e->content = $val;
        echo "$key => $val\n";
    } else if($key=="time") {
        $e->time=$val;
        echo "$key => $val\n";
        if(($counter+1)==$jsonIterator->getDepth()) { //for ending the current memo and append it to the memos array
            $arr->append($e);
            echo json_encode($e);
        }
    }
}
echo json_encode($arr); //printing the whole array of memos

?>