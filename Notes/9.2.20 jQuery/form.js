$(document).ready(function() { //making sure function runs after dom is loaded

     //use # for ids
     $("#submit").on('click', function() { //submits on click of button
   
       var name = $("#name"); //sets value inside of input to var
       var email = $("#email");
       var message = $("#message");
       var phone = $("#phone");
   
       var required = [name, email, phone]; //array of vars that are requried
   
       for (var i = 0; i < required.length; i++) { //iterates through length of required array
         if (required[i].val() === "") { //if val is empty
           $(message).text("Please Fill Out Required Fields").addClass(
             'warning'); //label message shows this text and adds this to become a new class warning
           required[i].prev().addClass('warning'); //go back 1 level and adds the class again
         } else {
           required[i].prev().removeClass('warning'); //otherwise, gets rid of warning
         }
       }
   
       if (!$("#form label").hasClass('warning')) { //if there's no labels with warning class
         $("#form")[0].remove(); //removies form from DOM
         $("#pre-form h2").text("Thanks for your feedback!") //outputs thanks message
       }
   
     });
   });