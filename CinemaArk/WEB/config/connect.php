<?php
$connect = new mysqli("localhost","root","","zaro_dolgozat","3306");
if ($connect -> connect_errno){
    die("Az a datbázishoz nem sikerült csatlakozni!");
}
if(!$connect -> set_charset("utf8")){
    echo("karakterkódolási hiba!");
}
?>