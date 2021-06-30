<?php
session_start();
require_once('config/connect.php');
include('config/functions.php');
$error = "";

$sql = "SELECT * FROM movies";
$result = $connect -> query($sql);
if (!$result){
    die("SQL hiba!");
}

$html = '<br><br><br><br>';
$html .= '<h1 class="text-light text-center">Műsoron lévő filmek</h1>';
$html .= '<div class="container mt-5 mb-5">';
$html .= '<div class="row">';



while ($row = $result -> fetch_assoc())
{
    $img = $row['img'];

        $html .= '<div class="col-sm-7 col-md-5 col-lg-3">'.'<br>';
        $html .= '<div class=" card bg-dark text-white">';
            $html .= '<img class="img" src="data:image/jpeg;base64,' . base64_encode( $img ) . '" />';
            $html .= '<p class="card-title">'.$row['title'].'</p>';
            $html .= '<span class="card-text">'.'Műfaj: '.$row['genre'].'</span>';
            $html .= '<span class="card-text">'.'Értékelés: '.$row['rating'].'</span>';
            $html .= '<span class="card-text">'.'Hossz: '.$row['lenght'].'</span>';
            $html .= '<span class="card-text">'.'Megjelenés: '.$row['release_date'].'</span>';
        $html .= '</div>';
        $html .= '</div>';
}
$html .= '</div>';
$html .= '</div>';

//menüsáv
printMenu();

//body
echo file_get_contents('html/body.html');

//tartalom
echo $html;

//footer
echo file_get_contents('html/footer.html');

$connect -> close();
?>