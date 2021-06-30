$(document).ready(function(){
    let url = location.href;
    //kosár tartalmának listázása, de csak a cart.php oldal betöltése esetén
    if (url.indexOf("cart") > -1) listCart();

    //Kosárhoz adás
    $(".cart").click(function()
    {  
        var elements = document.getElementsByClassName('selectVal');
        var results = [];

            for (var i = 0; i < elements.length; i++)
            {
                var element = elements[i];
                var strSel = element.options[element.selectedIndex].text;
                results.push(strSel);
            }
              $.post("php/add_cart.php",{addcart : results}, function()
              {
                  alert("kosárhoz adva");
              });
    });
    deleteProduct();

});


//Termék Törlése a kosárból
function deleteProduct()
{
    $(document).on("click", ".product-delete", function()
    {
        var id= $(this).attr("value");
        console.log(id);
        $.ajax(
            {
                url : "php/delete.php",
                method : "post",
                data : {del : id},
                success: function()
                {
                    listCart();
                },
                error: function()
                {
                    console.log('Ajax Hiba!');
                }
            });
            
    });
}

//Mennyi napos a hónap validáció
function DateValidate()
{
    var days = document.getElementById('date').value;
    var y = 2021;
    $("#day").empty();
    var februar = (y % 4 == 0 && y % 100) || y % 400 == 0 ? 29 : 28;

    switch (days)
    {
        case "2" :
            for (var i = 1; i <= februar; i++) {
                
                $('#day').append($("<option></option>").text(i));
              }
            break;
        case "9" : case "4" : case "6" : case "11" :
            for (var i = 1; i <= 30; i++) {
                
                $('#day').append($("<option></option>").text(i));
              }
            break;
        default :
            for (var i = 1; i <= 31; i++) {
                
                $('#day').append($("<option></option>").text(i));
            }
            break;
    }; 
}

//Kosár kikistázása
function listCart(){
    $.get("php/list_cart.php", function(data, status){
        $('#kosar').html(data);
    });
}


