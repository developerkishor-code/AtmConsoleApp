var number = 10; // Global variable

function myFunction() {
    var number = 20; // Local variable
    console.log("Inside function: " + number); // Outputs: Inside function: 20
}

myFunction();
console.log(number); 