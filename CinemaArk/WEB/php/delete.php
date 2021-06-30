<?php
session_start();

$id = $_POST['del'];
unset($_SESSION['cart'][$id]);
$_SESSION['cart']=array_values($_SESSION['cart']);
if (empty($_SESSION['cart']))
{
    unset($_SESSION['cart']);
}
