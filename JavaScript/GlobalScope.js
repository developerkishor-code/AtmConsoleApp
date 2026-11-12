var myGlobal = 10;
function myFunction1()
{
    oopsGloval = 5; 
    // This variable is not declared with var, let, or const, so it becomes a global variable
}

function myFunction2()
{
    var output = "";
    if(typeof myGlobal != "undefined"){
        output += "myGlobal: " + myGlobal;
    }
    if(typeof oopsGlobal != "undefined"){
        output += " oopsGlobal: " + oopsGlobal;
    }
    console.log(output);
}

myFunction1();
myFunction2();