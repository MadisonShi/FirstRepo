//exercise 1
function reverseInt(num){
     reverseNum = num.toString().split('');
     return parseFloat(reverseNum.reverse().join(''))* Math.sign(num);
}

//exercise 2
function primeCheck(num){
     for(let i = 2; i < num; i++){
          if(num % i == 0){
               return false;
          }
     }
     return true;
}

//exercise 3
function countLetter(letter, string){
     count = 0;
     for(let i = 0; i < string.length; i++){
          if(letter == string[i]){
               count++;
          }
     }
     return count;
}