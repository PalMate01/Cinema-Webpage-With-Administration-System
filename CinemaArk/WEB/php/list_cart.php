<?php
session_start();
require_once('../config/connect.php');
$cart = null;
$sum = 0;
$html = '';

$sql = "SELECT * FROM tickets";
$sql_movies = "SELECT * FROM movies";
$result = $connect -> query($sql);
$result_movies = $connect -> query($sql_movies);

if (isset($_SESSION['cart']))
{
    $cart = $_SESSION['cart'];

    $html .= '<br><br><br><br>';
    $html .= '<h1 class="text-light text-center">Kosár</h1><br>';
    $html .= '<div class="container d-flex justify-content-center">';
    $html .= '<table class="table-bordered table-dark table-hover">';
    $html .= '<tr class="bg-dark text-light text-uppercase text-center"> <th>Termék név</th> <th>Előadás</th> <th>Terem</th> <th>Sor</th> <th>Szék</th> <th>Hónap</th> <th>Nap</th> <th>Időpont</th> <th>Ár</th> <th>Művelet</th> </tr>';
    
    $all_price = 0;
    for ($i=0; $i < count($cart); $i++)
    {
            
    if(!$result){
        die("SQL HIBA");
    }
    
    $nevesprice = explode("-", $cart[$i][0]);
    $price = str_replace(" Ft", "", $nevesprice[1]);
    //Összesen az ár
    $all_price += $price;
    

    $movie_room = explode(" -", $cart[$i][1]);

    $html .='<tr id="henlo" value="'.$i.'" class="text-center">';
    $html .='<td class="value">'.$nevesprice[0].'</td>'; //jegytípus
    $html .='<td class="value">'.$movie_room[0].'</td>'; //előadás
    $html .='<td class="value text-center">';

    while ($row_movies = $result_movies -> fetch_assoc()) {

        if ($cart[$i][0] == $row_movies['title']) {
            $kiir = $row_movies['room'];
            
        }
    }

    $html .= $movie_room[1]; //terem
    $html .= '</td>';

    $html .='<td class="value">'.$cart[$i][2].'</td>'; //sor
    $html .='<td class="value">'.$cart[$i][3].'</td>'; //szék
    $html .='<td class="value">'.$cart[$i][4].'</td>'; //hónap
    $html .='<td class="value">'.$cart[$i][5].'</td>'; //nap
    $html .='<td class="value">'.$cart[$i][6].'</td>'; //időpont
    $html .='<td class="value text-center">';

    while ($row = $result -> fetch_assoc()) {

        if ($cart[$i][0] == $row['type_name']) {
            $kiir = $row['price'];
            
        }
    }

    $html .= $price; //ár
    $html .= ' Ft</td>';
    $html .='<td class="text-center"> <span class="product-delete btn btn-warning" value="'.$i.'"> &#128465; </span> </td>';
    $html .='</tr>';
    }

    $html .= '<tr> <td colspan="4" class="text-right">Összesen: </td> <td class="text-center">'.$all_price.' Ft</td></tr>';
    $html .= '</table>';
    $html .= '</div>';
    $html .= '<br>';
    $html .= '<div class="container text-center col-lg-4 col-md-6 col-ms-4">';
    $html .= '<a class="btn btn-danger mx-3" href="empty_cart.php">Kosár ürítése</a>';
    $html .= '<a class="btn btn-success mx-3" name="send" method="post" href="order.php">Megrendelés</a>';
    $html .= '</div>';

    $connect -> close();
} else {
    echo "<br><br><br><br><br>";
    $html .= '<div class="container text-light col-lg-2">';
    $html .= '<h1 class="text-center">Üres a kosár!</h1>';
    $connect -> close();
}
echo $html;