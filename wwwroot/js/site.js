$(document).ready(function ()//this is code that runs once the page is ready and loaded
{
    console.log("script tag loaded! YeeHaw!");
    let BoxCount1 = $('#ClickCount').html();//function scoped var to use when page loads
    console.log("The initial value of BoxCount is: " + BoxCount1);
    $('#Parcels').append('<input type="text" class="form-control" id="Parcel1" placeholder="Enter container #1 content">');
});
//this section handles the button to add container inputs to the form
$('#BoxClicker').click(function ()//this is the code that runs when user adds container inputs via BoxClicker
{
    let BoxCount2 = $('#ClickCount').html();//creates counter scoped to this function when button is clicked
    console.log("Adding Click Event worked!! and existing BoxCount is: " + BoxCount2);
    if (BoxCount2 < 20)//bool to check if user clicked too many times
    {
        console.log("Boxcount is less than 20");
        BoxCount2++;//increment the count if bool is true
        console.log("BoxCount now equals: " + BoxCount2);
        var newInput = '<input type="text" class="form-control extraBox" id="Parcel' + BoxCount2 + ' "placeholder="Enter container #' + BoxCount2 + ' content">';//new string to append
        $('#Parcels').append(newInput);//adds a new input with associated tags
        console.log("New Parcel Input appended");
        $('#BoxQty').attr('value', BoxCount2);//updates hidden input to get number of labels needed
        document.getElementById("ClickCount").innerHTML = BoxCount2;//users see this as the counter
    }
    else {
        console.log("Box Count limit of 20 has been reached");
        //document.getElementById("BoxClicker").innerHTML = "Limit of 5 is reached";//Button changes to inform user
    }
});
//this section handles the button to remove inputs from the form
$('#BoxRemover').click(function () {
    let BoxCount3 = $('#ClickCount').html();//function scoped var to use when page loads
    console.log("Remove Click Event worked!! and existing BoxCount is: " + BoxCount3);
    if (BoxCount3 > 1) {
        $('.extraBox').last().remove();
        BoxCount3--;
        console.log("extraBox removed and new BoxCount is: " + BoxCount3);
        $('#BoxQty').attr('value', BoxCount3);//updates hidden input to get number of labels needed
        document.getElementById("ClickCount").innerHTML = BoxCount3;//users see this as the counter
    }
});
