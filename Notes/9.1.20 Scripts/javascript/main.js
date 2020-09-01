function greetOnLoad () {
     var name = prompt("Hi! What's your name?");
     var myelement = document.getElementById("greeting"); //writes out Hi! when prompt shows up; without it, the website is blank
     greeting.innerHTML= "Hello " + name + ", it's nice to meet you!";
 }
 
 greetOnLoad();

/* not terribly sure what this does but if based on greetOnLoad, then it just has this show up in html if running the function
slides are calling this, find a node

//Get an element ById
let myElement = document.getElementById('myEl');

//Get a collection of elements by tag name
let paragraphs = document.getElementsByTagName('p');

//Get a collection of elements by class name
let activeEls = document.getElementsByClassName('active');

//Get elements by a CSS Selector
let matches = document.querySelectorAll('#header p.active');*/

//https://googlechrome.github.io/devtools-samples/debug-js/get-started