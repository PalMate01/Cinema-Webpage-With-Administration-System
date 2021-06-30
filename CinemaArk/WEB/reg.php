<?php
session_start();
require_once('config/connect.php');
include('config/functions.php');

if (isset($_POST['username1']) && isset($_POST['pswd']) && isset($_POST['real_name']) && isset($_POST['email']) && isset($_POST['address']))
{

$username = $_POST['username1'];
$pwd = $_POST['pswd'];
$real_name = $_POST['real_name'];
$email = ($_POST["email"]);
$address = $_POST['address'];
$join_date = date('Y-m-d H:i:s');
$hashpwd = hash('sha256', $pwd);
$usernames = "SELECT username FROM user WHERE username = '$username';";
$emails = "SELECT email FROM user WHERE email = '$email';";
$check_usernames = $connect -> query($usernames);
$check_emails = $connect -> query($emails);
$row = $check_usernames -> fetch_assoc();
$row2 = $check_emails -> fetch_assoc();


//Van e már ilyen email, username
if (!empty($row['username']) || !empty($row2['email']))
{
    echo '<script>alert("Ilyen felhasználónévvel vagy Email címmel már regisztráltak!")</script>';
}else
{
    //jelszó erősség szabályozás
    $uppercase = preg_match('@[A-Z]@', $pwd); //minimum 1 nagybetű
    $lowercase = preg_match('@[a-z]@', $pwd); //minimum 1 kisbetű
    $number    = preg_match('@[0-9]@', $pwd); //minimum 1 szám
    $length    = preg_match('@[^\w]@', $pwd); //minimum 8 karakter hosszúság
    if(!$uppercase || !$lowercase || !$number ||  strlen($pwd) < 8 )
    {
        echo '<script>alert("A jelszónak tartalmaznia kell nagybetűt, kisbetűt, számot és minimum 8 karakternek kell lennie!")</script>';
    }else
    {

    //lakcím forma ellenőrzés
    if (preg_match('/^[1-9]{1}[0-9]{3}[a-zA-ZáéíóöőúüűÁÉÍÓÖŐÚÜŰ\s]+\d+$/', $address))
    {
    //A valódi név csak szóközt és betűket tartalmazhat
    if(preg_match("/^[a-zA-ZáéíóöőúüűÁÉÍÓÖŐÚÜŰ\s]*$/",$real_name))
    {
        //Helyes email cím forma-e?
        if (filter_var($email, FILTER_VALIDATE_EMAIL))
        {
            if (isset($_POST['reg']))
            {
                $sql = "INSERT INTO user (username, pwd, name, email, home_address, join_date) VALUES ('$username', '$hashpwd', '$real_name', '$email', '$address', '$join_date');";
                $connect -> query($sql);
                
                if (!$sql){
                    echo 'SQL hiba!';   
                }else{
                    header('Location: index.php');
                }
            }
        }else
        {
            echo '<script>alert("Helytelen e-mail cím forma!")</script>';
        }
    }else
    {
        echo '<script>alert("Helytelen név! (Csak betűket és szóközt tartalmazhat a neve)")</script>';
    }
}else{
    echo '<script>alert("Helytelen lakcím forma!")</script>';
}
}
}
}

echo file_get_contents('html/body.html');
echo file_get_contents('html/reg_form.html');

printMenu();

echo file_get_contents('html/footer.html');
?>