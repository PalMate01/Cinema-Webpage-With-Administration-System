<?php
session_start();
include('config/functions.php');
//Van-e belépett felhasználó
if (!isLogged()){
    header('Location: login.php');
    die();
}
//Van-e termék a kosárban?
$userId = $_SESSION['uid'];
if (empty($_SESSION['cart'])){
    header('Location: cart.php');   
    die();
}
$cart = $_SESSION['cart'];
require_once('config/connect.php');
$connect -> autocommit(false);
//orders táblába adatok beszúrása
$sql = "INSERT INTO orders (customer_id, date, payment_mode) VALUES ($userId, LOCALTIMESTAMP(), 'cash');";   //Először a megrendelés rögzítése
if (!$connect -> query($sql)){
    echo 'SQL hiba!';   
}

$orderId = $connect -> insert_id;
//items táblába adatok beszúrása
$sql_items = "INSERT INTO items (product_id, quantity, price, order_id, customer_id, movie, room, line, seat, month, day, lecture) VALUES (?, ?, ?, $orderId, $userId, ?, ?, ?, ?, ?, ?, ?);";
$stmt_items = $connect -> prepare($sql_items);


for ($i=0; $i < count($cart); $i++)
{
    //Ár kinyerése
    $nevesprice = explode("-", $cart[$i][0]);
    $price = str_replace(" Ft", "", $nevesprice[1]);

    $movie_room = explode(" -", $cart[$i][1]);

    $movie = $movie_room[0];
    $room = $movie_room[1];
    $line = $cart[$i][2];
    $seat = $cart[$i][3];
    $month = $cart[$i][4];
    $day = $cart[$i][5];
    $lecture = $cart[$i][6];

    foreach ($cart as $id => $db){}
    $sql_ar = "SELECT * FROM tickets WHERE id = $id";
    if (!$result = $connect -> query($sql_ar)){
        die('SQL hiba!');
    }
    $id += 1;
    $row = $result -> fetch_array();

    $stmt_items -> bind_param("iiisiiisis", $id, $db, $price, $movie, $room, $line, $seat, $month, $day, $lecture);
    $stmt_items -> execute();

    $seat = $cart[$i][3];

    /*$sql_free ="UPDATE seats SET it_free = '1' WHERE seat = $seat";
    if (!$connect -> query($sql_free)){
    echo 'SQL hiba!';
    }*/
}
//EMAIL ÉRTESÍTÉS A FELHASZNÁLÓNAK A SIKERES VÁSÁRLÁSRÓL
//SMTP KONFIGURÁCIÓ SZÜKSÉGES HOZZÁ, A KÉSŐBBIEKBEN MEGOLDHATÓ

/*
$sql_email = "SELECT email FROM user WHERE id = $userId";
$result_email = $connect -> query($sql_email);

while($row_email = $result_email -> fetch_assoc()){
    $email = $row_email['email'];
}


if(isset($email))
{
    var_dump('<br><br><br><br><br><br>');
    $success = null;
    $address = $email;
    // Tárgy
    $subject = "Teszt üzenet";
    // Levél törzse
    $body = "Szia! Ez itt egy levél tőlem neked";
    // Fejléc
    $header = "MIME-Version: 1.0\n";
    $header .= "Content-Type: text/html; charset=utf8\n";
    // Kitől jön a levél név és email
    $header .= "From: cinemaArk \n";
    // Kinek megy vissza ha hiba van
    $header .= "Errors-to: palmate14@gmail.com\n";
    // A törzs HTML-esítése
    mb_internal_encoding("UTF-8");
    $subject = mb_encode_mimeheader($subject, "UTF-8", "Q");
    $content = "$body";
    // Levélküldés és a sikeresség ellenőrzése

        $success = mail($address, $subject, $content, $header);
        var_dump($success);

    // Visszajelzés a küldésről
    if ($success) {
    echo "OK";
    } else {
    echo "NO";
    }
}
*/

//Visszajelzés, hogy sikeres-e a megrendelés
if (!$connect -> commit())
{
    echo '<script>alert("Hibás rendelés! Kérjük próbálja újra.")</script>';
} else 
{
    echo '<script>alert("Megrendelése rögzítésre került!")</script>';
    
}
echo $html;
$connect -> close();
$stmt_items -> close();

//body
echo file_get_contents('html/body.html');
//menüsáv
printMenu();
echo '<div id="kosar"></div>';
//footer
echo file_get_contents('html/footer.html');