//Madison Shi

//sample arrays used throughout exercises
let sampleArr = [10,9,8,7];
let myColor = ["Red", "Green", "White", "Black"];

//Exercise 1
var clone = function(arr){
     return arr.slice(0);
};

console.log("Exercise 1 - int array:", clone(sampleArr));
console.log("Exercise 1 - str array:", clone(myColor));

//Exercise 2
console.log("Exercise 2:", myColor.toString())

//Exercise 3
var sum = 0;
var product = 1;
sampleArr.forEach(function(num, index){
     sum += num;
     product *= num;
});

console.log("Exercise 3 - sum:", sum, 
               "\nExercise 3 - product:", product)