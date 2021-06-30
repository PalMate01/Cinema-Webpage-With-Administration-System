<?php
session_start();
include('config/functions.php');
echo file_get_contents('html/footer.html');
echo file_get_contents('html/body.html');
echo file_get_contents('html/start_page.html');
printMenu();