let hands = ["rock", "paper", "scissors"];

function getComputerHand(){
     return parseInt((Math.random()*10)%3)
}

function compare(userChoice, machineChoice){
     if(userChoice == machineChoice){
          return `User: ${hands[userChoice]} \nMachine: ${hands[machineChoice]} \nDraw`
     }
     else if((userChoice == 0 && machineChoice == 2) || (userChoice == 2 && machineChoice == 1) || (userChoice == 1 && machineChoice == 0)){
          return `User: ${hands[userChoice]} \nMachine: ${hands[machineChoice]} \nUser wins`
     }
     else{
          return `User: ${hands[userChoice]} \nMachine: ${hands[machineChoice]} \nMachine wins`
     }
}

function loadGame(){
     var userChoice = prompt("Enter your hand:", "r p s");
     if(userChoice == 'r'){
          userChoice = 0;
     }
     else if(userChoice == 'p'){
          userChoice = 1;
     }
     else{
          userChoice = 2;
     }
     document.getElementById("results").innerHTML = "Results: " + compare(userChoice, getComputerHand())
}

loadGame()