//Single Dimensional Array

var myArray = ["kishore",25,"India"];

//push will add an element to the end of the array
myArray.push("Bangalore");

//pop will remove an element from the end of the array
myArray.pop();

//removes the first element of the array
myArray.shift(); 

//adds an element to the beginning of the array
myArray.unshift("kishore"); 
console.log(myArray[0]);
for(var i = 0; i < myArray.length; i++){
    console.log(myArray[i]);
}

//Multi Dimensional Array

var myMultiArray = [["kishore",25,"India"],["Ravi",30,"USA"]];
console.log(myMultiArray[0][1]);


myMultiArray.unshift(["Ramesh",35,"UK"]);
console.log(myMultiArray[0][0]);

