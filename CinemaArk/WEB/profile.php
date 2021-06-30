<?php
session_start();
require_once('config/connect.php');
include('config/functions.php');

if (empty($_SESSION['uid'])){
    header('location: index.php');
    die('Nincs bejelentkezve!');
}

//Léteznek-e az input mezőink..
if (isset($_POST['username']) && isset($_POST['real_name']) && isset($_POST['email']) && isset($_POST['address']))
{
    $uid = $_SESSION['uid'];
    $upwd = "SELECT * FROM user WHERE id = '$uid';";

    $row=mysqli_fetch_array($upwd);

    if (!$upwd){
        die('SQL HIBA!');
    }

    if (isset($_POST['submit']))
    {
        
        $username = $connect -> real_escape_string ($_POST['username']);
        $real_name = $connect -> real_escape_string ($_POST['real_name']);
        $email = $connect -> real_escape_string ($_POST['email']);
        $address = $connect -> real_escape_string ($_POST['address']);

        //Lakcím validáció
        if (preg_match('/^[1-9]{1}[0-9]{3}[a-zA-ZáéíóöőúüűÁÉÍÓÖŐÚÜŰ\s]+\d+$/', $address))
        {  
            $sql = "UPDATE user SET email = '$email', username = '$username', name = '$real_name', home_address = '$address' WHERE id = '$uid';";
            if ($lht = $connect->prepare($sql))
            {
                $lht -> bind_param('ssss', $email, $username, $real_name, $address);
                if (!$lht -> execute())
                {
                    die ("sql végrehajtási hiba!");    
                }
                $lht-> execute();
                $lht-> bind_result($email, $username, $real_name, $address);
                header('Location: index.php');
                $lht -> close();
            }
            else 
                {
                    die ("SQL hiba");
                }
        }else{
            echo '<script>alert("Nem megfelelő lakcím formátum!")</script>';
        }

        

    }else
        {
        die('A kérés nem lett elküldve!');
        }
    
}
$connect -> close();

echo file_get_contents('html/body.html');
printMenu();

echo file_get_contents('html/profile_form.html');
echo file_get_contents('html/footer.html');