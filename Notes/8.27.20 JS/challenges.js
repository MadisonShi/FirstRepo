/* challenge 1 */

let shoppingList = ["pop tarts", "ramen noodles", "chips", "salsa", "coffee"]
shoppingList.push("fruit loops")
shoppingList[shoppingList.indexOf("coffee")] = "fair trade coffee"
shoppingList.splice(shoppingList.indexOf("chips"), 2, "rice", "beans")

let shoppingCart = []
shoppingCart.push(shoppingList.pop())
shoppingCart.push(shoppingList.shift())

while(shoppingList.length !=0){
     shoppingCart.push(shoppingList.pop())
}

shoppingCart.sort().reverse()

/*shoppingCart.forEach(function(item, index){
     console.log(item + ",");
});*/
//console.log("Cart items:", shoppingCart.join(", "))

/* challenge 2 */
let course = {
	name: 'JavaScript Applications',
	awesome: true,
	teachers: ['Assaf', 'Shane'],
	students: [
		{
			name: 'Steve',
			computer: {
				OS: 'Linux',
				type: 'laptop'
			}
		},
		{
			name: 'Katy',
			computer: {
				OS: 'OSX',
				type: 'macbook'
			}
		},
		{
			name: 'Chuck',
			computer: {
				OS: 'OSX',
				type: 'macbook'
			}
		}

	],
	preReqs : {
		skills : ['html', 'css', 'git'],
		equipment: {
			laptop: true,
			OSOptions: ['linux', 'osx']
		}
	}
};

console.log(course.preReqs.equipment.OSOptions.join(" or "))

let OSXStudents = []

for(let i = 0; i < course.students.length; i++){
     if(course.students[i].computer.OS=="OSX"){
          OSXStudents.push(course.students[i].name);
     }
}

console.log(OSXStudents.join(", "))