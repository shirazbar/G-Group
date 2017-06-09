<?php
/**
 * Memos Change class
 * The class gets the memo info and updates the changes in the database
 * Created by PhpStorm.
 * User: orcohen125
 * Date: 07/06/2017
 * Time: 15:29
 */
class memosChange {


    /**
     * Removing memo from database function
     * @param $title
     *              title of memo
     */
    function remove($title) {
        $mysqli = new mysqli("localhost", "root", "", "g_group");
        $querysql="DELETE FROM memos WHERE title='".$title."'";
        $mysqli->query($querysql);
    }

    /**
     * Adding memo to database function
     * @param $user
     *              user which created the memo
     * @param $title
     *              title of memo
     * @param $content
     *              content of memo
     * @param $time
     *              time of memo
     */
    function add($user,$title,$content,$time) {
        $mysqli = new mysqli("localhost", "root", "", "g_group");
        $querysql="INSERT INTO memos(user, title, content, time) VALUES('".$user."','".$title."','".$content."','".$time."');";
        $mysqli->query($querysql);
    }

    /**
     * Editing and updating memo in database function
     * @param $user
     *              user which created the memo
     * @param $title
     *              title of memo
     * @param $content
     *              content of memo
     * @param $time
     *              time of memo
     * @param $oldTitle
     *              old title of memo before the edit
     */
    function edit($user,$title,$content,$time,$oldTitle) {
        $mysqli = new mysqli("localhost", "root", "", "g_group");
        $querysql="UPDATE memos SET user = '".$user."', title = '".$title."', content = '".$content."', time = '".$time."' WHERE title = '".$oldTitle."';";
        $mysqli->query($querysql);
    }
}
?>
