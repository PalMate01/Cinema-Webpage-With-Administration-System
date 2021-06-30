<?php
session_start();
include('config/functions.php');
echo file_get_contents('html/body.html');
//menüsáv
printMenu();
echo '<div id="kosar"></div>';
//footer
echo file_get_contents('html/footer.html');
