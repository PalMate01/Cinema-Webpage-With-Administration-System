<?php
session_start();
require_once('config/connect.php');
include('config/functions.php');

$html = '<br><br><br><br>';
$html .= '<h1 class="text-light text-center">Jegyfoglalás</h1>';
$html .= '<table class="container col-lg-6 col-md-8 col-sm-4 table-striped table-bordered table-dark">';
$html .= '<td>ELŐADÁS JEGYEK</td>';
$error = '';
$lecture = '';
$seat = '';
$lines = '';
$movies = '';
$tickets = '';
$month = '';
$days = '';
$months = '';

$sql_tickets = "SELECT * FROM tickets";
$sql_seats = "SELECT * FROM seats";
$sql_lines = "SELECT * FROM line";
$sql_movies = "SELECT * FROM movies";
$sql_days = "SELECT * FROM days";
$sql_months = "SELECT * FROM months";
$sql_lecture = "SELECT * FROM lecture_time";
$sql_items = "SELECT * FROM items";

$result_items = $connect -> query($sql_items);
$result_tickets = $connect -> query($sql_tickets);
$result_seats = $connect -> query($sql_seats);
$result_lines = $connect -> query($sql_lines);
$result_movies = $connect -> query($sql_movies);
$result_days = $connect -> query($sql_days);
$result_months = $connect -> query($sql_months);
$result_lecture = $connect -> query($sql_lecture);

//Időpont
while($row_lecture = $result_lecture -> fetch_assoc()){
    $lecture .= '<option>'.$row_lecture['time'].'</option>';
}

//Hónap
while($row_months = $result_months -> fetch_assoc()){
    $month_id = (int)$row_months['id'];
    $month .= '<option value="'.$row_months['id'].'">'.$row_months['month'].'</option>';
}

//Nap
while($row_days = $result_days -> fetch_assoc()){
    $days .= '<option>'.$row_days['day'].'</option>';
}

//Székek
while($row_seats = $result_seats -> fetch_assoc()){
    $seat .= '<option>'.$row_seats['seat'].'</option>';
}

//Sorok
while($row_lines = $result_lines -> fetch_assoc()){
    $lines .= '<option>'.$row_lines['line'].'</option>';
}

//Filmek
while($row_movies = $result_movies -> fetch_assoc()){
    $movies .= '<option>'.$row_movies['title'].' -'.$row_movies['room'].'.Terem'.'</option>';
}

//Jegytípusok
while ($row_tickets = $result_tickets -> fetch_assoc())
{
    $tickets .= '<option>'.$row_tickets['type_name'].' -'.$row_tickets['price']." Ft".'</option>';
}

//Van-e eredmény
if (!$result_items || !$result_tickets || !$result_seats || !$result_movies || !$result_days || !$result_months || !$result_lecture){
    die("SQL hiba!");
}
$items = null;
while($row_items = $result_items -> fetch_assoc()){
    $items .= $row_items['id'];
}

$html .= '<tr>' ;
    $html .= '<td>Jegytípus</td>';
    $html .='<td>'. '<select class="selectVal form-control bg-dark text-light ">'.$tickets.'</select>'.'</td>'.'<br>';
    $html .= '</tr>';

    $html .= '<tr>' ;
    $html .= '<td>Előadás</td>';
    $html .='<td>'. '<select id="movie" class="selectVal form-control bg-warning">'.$movies.'</select>'.'</td>';
    $html .= '</tr>';

    $html .= '<tr">' ;
    $html .= '<td>Sor</td>';
    $html .='<td>'. '<select id="line" class="selectVal form-control bg-dark text-light">'.$lines.'</select>'.'</td>';
    $html .= '</tr>';

    $html .= '<tr">' ;
    $html .= '<td>Szék</td>';
    $html .='<td>'. '<select id="seat" class="selectVal  form-control bg-warning">'.$seat.'</select>'.'</td>';
    $html .= '</tr>';

    $html .= '<tr">' ;
    $html .= '<td>Vetítési Hónap</td>';
    $html .='<td>'. '<select id="date"  class="selectVal form-control bg-dark text-light" onchange="DateValidate()">'.$month.'</select>'.'</td>';
    $html .= '</tr>';

    $html .= '<tr">' ;
    $html .= '<td>Vetítési nap</td>';
    $html .='<td>'. '<select id="day" class="selectVal  form-control bg-warning">'.$days.'</select>'.'</td>';
    $html .= '</tr>';

    $html .= '<tr">' ;
    $html .= '<td>Időpont</td>';
    $html .='<td>'. '<select id="lecture" class="selectVal form-control bg-dark text-light" >'.$lecture.'</select>'.'</td>';
    $html .= '</tr>';

    $html .= '<tr>';
    $html .= '<td></td>';
    //Kosárba rakás bejelentkezéshez kötve
    if(isLogged() == true)
    {
    $html .= '<td><span class="cart btn btn-secondary text-center">Kosárba</span>'.'</td>';
    $html .= '</tr>';
    }else
    {
        echo "<br><br><br><br>";
    $log = '<div class="container bg-danger text-light col-lg-6">';
    $log .= '<h1 class="text-center">A jegy kosárba rakásához kérjük jelentkezzen be!</h1>';
    $log .= '</div>';
    echo $log;
    }
    $html .= '<td colspan="2"><br></td>';

$html .= '</table>';

//tartalom
echo $html;
//body
echo file_get_contents('html/body.html');
printMenu();

//footer
echo file_get_contents('html/footer.html');

$connect -> close();
?>
