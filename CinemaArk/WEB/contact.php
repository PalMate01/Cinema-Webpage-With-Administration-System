<?php
session_start();
include('config/functions.php');
include('config/connect.php');
echo file_get_contents('html/body.html');
echo file_get_contents('html/contact_form.html');
printMenu();
echo file_get_contents('html/footer.html');

if (empty($_SESSION['uid'])){
    header('location: index.php');
    die('Nincs bejelentkezve!');
}

if(isset($_POST['message']))
{
    $uid = $_SESSION['uid'];
    $message = $connect -> real_escape_string($_POST['message']);

    if(isset($_POST['submit']))
    {
        $sql = "INSERT INTO contact (name_id, message) VALUES('$uid', '$message')";

        if (!$connect -> query($sql)){
            echo 'SQL hiba!';   
        }else{
            echo '<script>alert("Üzenetét rögzítettük.")</script>';
        }
    }else
    {
        die('Sikertelen küldés!');
    }
}
$connect -> close();
