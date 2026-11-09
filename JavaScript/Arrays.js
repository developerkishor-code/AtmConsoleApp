//Single Dimensional Array

var myArray = ["kishore",25,"India"];
console.log(myArray[0]);
for(var i = 0; i < myArray.length; i++){
    console.log(myArray[i]);
}

//Multi Dimensional Array

var myMultiArray = [["kishore",25,"India"],["Ravi",30,"USA"]];
console.log(myMultiArray[0][1]);

/*
push -- adds an element to the end of the array
pop -- removes an element from the end of the array
*/
myArray.push("Bangalore");
console.log(myArray);
