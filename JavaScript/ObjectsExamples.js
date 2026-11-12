var empDeatils = 
{
    name: "Tony Gangawar",
    address: "Lucknow, Uttar Pradesh",
    phoneNumber: "25635656565",
    email:"tony.gangawar@example.com"
};

function checkValue(chekProperty){
    if (empDeatils.hasOwnProperty(chekProperty))
        {
            return empDeatils[checkProperty];
        }
        else
            {
                return "Not Found";
            }
}




console.log(checkValue("gift"));


var myStorage = {
    "car": {
        "inside":
        {
            "glove box": "maps",
            "passenger seat": "crumbs"
        },
        "outside": {
            "trunk": "jack"
        }
    }
}

var gloveBoxContents = myStorage.car.outside.trunk;
console.log(gloveBoxContents);