<?php
echo '<link rel="icon" href="data:;base64,=">';
function isLogged(){
    if (empty($_SESSION['uid'])){
        return false;
    }
    return true;
}

function printMenu(){
    if (isLogged() == true){
        $nav = file_get_contents('html/nav_in.html');
        $nav = str_replace('::username::', $_SESSION['username'], $nav);
        echo $nav;
     } else {
         echo file_get_contents('html/nav_out.html');
     }
}