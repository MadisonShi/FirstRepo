// challenge 1

let billAmount = 11.35;

function gratuity(){
     return billAmount * 0.2
}

function totalWithGrat(amount){
     return Number(gratuity() + amount).toFixed(2)
}

//console.log("your total including gratuity is:", totalWithGrat(billAmount))

//other method for console.logging
//console.log(`your total, including gratuity is:\$${totalWithGrat(billAmount).toFixed(2)})

//Challenge 2

let hands = ["rock", "paper", "scissors"];

function getComputerHand(){
     return parseInt((Math.random()*10)%3)
}

//console.log(getComputerHand())