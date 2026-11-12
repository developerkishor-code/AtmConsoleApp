var myDog = 
{
    "name": "Tommy",
    "legs": 4,
    "tails": 1,
    "friends": ["everything!"]
};

var testObj = {

    "hat": "ball",
    "shirt": "jersey",
    "shoes": "cleats"
};

var hatValue = testObj.hat;
var shirtValue = testObj.shirt;

console.log(hatValue);
console.log(shirtValue);
console.log(myDog["name"]);
console.log(myDog["legs"]);

myDog.name = "Happy Tommy";
console.log(myDog.name);

//adding a new property to the objects:
myDog.bark = "woof";
console.log(myDog.bark);