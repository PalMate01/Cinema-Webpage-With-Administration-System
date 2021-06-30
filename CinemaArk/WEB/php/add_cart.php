<?php
session_start();

if (isset($_POST['addcart'])){
    $cart = $_POST['addcart'];

    if (!isset($_SESSION['cart'])) 
    {
        $_SESSION['cart'] = array();
        $_SESSION['cart'][0] = $cart;   
    }
    else
    {
        for ($i=0; $i < count($_SESSION['cart']); $i++)
        { 
            if (
            $cart[1] == $_SESSION['cart'][$i][1] &&
            $cart[2] == $_SESSION['cart'][$i][2] &&
            $cart[3] == $_SESSION['cart'][$i][3] &&
            $cart[4] == $_SESSION['cart'][$i][4] &&
            $cart[5] == $_SESSION['cart'][$i][5] &&
            $cart[6] == $_SESSION['cart'][$i][6])
            {
                $value=1;
                break;
            }
        }
        
        if ($value != 1) {
            $_SESSION['cart'][count($_SESSION['cart'])] = $cart;
        }
    } 
} else
    {
    http_response_code(400);
    }
?>