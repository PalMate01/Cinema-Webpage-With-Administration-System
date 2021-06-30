<?php
session_start();
require_once('config/connect.php');
include('config/functions.php');
$error = "";

if (isset($_POST['username']) && isset($_POST['pswd']))
{
    $username = $_POST['username'];
    $pwd = $_POST['pswd'];
    $hashpwd = hash('sha256', $pwd);
    $sql = "SELECT * FROM user WHERE username = '$username' AND pwd = '$hashpwd';";
    $result = $connect -> query($sql);
    if (!$result)
    {
       die("Hiba a lekérdezésben!");
    }

    if ($result -> num_rows == 1)
    {
        $row = $result -> fetch_assoc();
        $_SESSION['uid'] = $row['id'];
        $_SESSION['username'] = $row['name'];
        
        header('Location: index.php');
        die();
    }else
    {
        echo '<br>';
        echo '<br>';
        echo '<br>';
        echo '<html><button onclick="history.go(-1);">Vissza</button> </html>';
        $error .= '<h3 class="text-danger">Helytelen felhasználónév vagy jelszó!</h3>';
    }
}

echo file_get_contents('html/body.html');
echo file_get_contents('html/log_form.html');

printMenu();

echo $error;

echo file_get_contents('html/footer.html');
?>
