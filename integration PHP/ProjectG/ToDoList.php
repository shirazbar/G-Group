<?php

/**
 * Created by PhpStorm.
 * User: Shiraz
 * Date: 20/05/2017
 * Time: 19:36
 */
class ToDoList
{
    private $conn;
    private $detail;
    private $content;
    private $date;
    private $UserId;

    public function __construct($UserId)
    {
        require_once("Database.php");
        $database = new Database();
        $this->conn = $database->dbConnection();
        $this->UserId = $UserId;
    }

    public function getConn()
    {
        return $this->conn;
    }

    public function runQuery($sql)
    {
        $stmt = $this->conn->prepare($sql);
        return $stmt;
    }

    public function addTask($UserId, $title, $content, $date)
    {

    }

}