$(header); //gets the top-level header element
$("section").find("*"); //gets all section elements
var curr = $(".current"); //gets section element with class current
curr.next(); //gets section after current
curr.prev().find("h2")[0]; //gets the first h2 section prior to current
$(".highlight").parent().parent(); //gets the DIV that contains the section that has an h2 with class highlight; parent shunts it back up DOM chain
var allH2 = Array.from($("section").find("h2")); //storing all h2 sections into an array