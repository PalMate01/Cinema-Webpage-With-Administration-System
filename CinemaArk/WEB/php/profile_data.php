<?php
session_start();
$response = "";
if (!empty($_SESSION['uid'])){
    require_once('../config/connect.php');
    $uid = $_SESSION['uid'];
    $sql = "SELECT * FROM user WHERE id = $uid;";
    if ($result = $connect -> query($sql)){
        if ($result -> num_rows == 1){
            $row = $result -> fetch_assoc();
            $response .= "name:".$row['name'].";email:".$row['email'].";address:".$row['home_address'];    
        }
    } else {
        echo "SQL hiba!";
    }
    echo $response;
    $connect -> close();
} else {
    header('Location: ../index.php');
    die();
}