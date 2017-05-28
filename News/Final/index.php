<?php
    if (isset($_GET["site"])) {
        $Url = ['bbc' => 'http://newsapi.org/v1/articles?source=bbc-news&sortBy=top&apiKey=3bb7b1e020f94de4a17f166b009fbc7f',
            'abc' => 'http://newsapi.org/v1/articles?source=abc-news-au&sortBy=top&apiKey=3bb7b1e020f94de4a17f166b009fbc7f',
            'nyn' => 'http://newsapi.org/v1/articles?source=the-new-york-times&sortBy=top&apiKey=3bb7b1e020f94de4a17f166b009fbc7f',
            'mtv' => 'http://newsapi.org/v1/articles?source=mtv-news&sortBy=top&apiKey=3bb7b1e020f94de4a17f166b009fbc7f'];
        $a = $_GET["site"];
        //$a="bbc";
        $url = $Url[$a];
        $json = file_get_contents($url, 0);
        $parsed_json = json_decode($json, true);
        $json = [
            "articles" => array(),
            "publisher" => $a
        ];
        if ($a == "mtv")
            for ($i = 0; $i < 5; $i++) {
                $json["articles"][$i] = [
                    "title" => $parsed_json['articles'][$i]['title'],
                    "url" => $parsed_json['articles'][$i]['url']
                ];
            }
        else
            for ($i = 0; $i < 10; $i++) {
                $json["articles"][$i] = [
                    "title" => $parsed_json['articles'][$i]['title'],
                    "url" => $parsed_json['articles'][$i]['url']
                ];
            }
        echo json_encode($json);
    }
?>