// AN Implicit Type declaration based on Right-Hand-Side INitial value
let n1 = 1000;

let n2: number; // Explicit DataType DEclaration
n2 = 10; // valid

// Strings
let firstName: string = "Mahesh";
let middleName: string = "Rameshrao";
let lastName: string = "Sabnis";

// Traditional String Concatination

let fullNameTraditional = firstName + ' ' + middleName + ' ' + lastName;
console.log(fullNameTraditional);
// ES 6 Template String aka String INterpoation
// Build a SIngle Immutable STring Object

let templateString = `${firstName} ${middleName} \n 
        ${lastName}`;

console.log(`USing Interpolation ${templateString}`);


window.onload = function() {
    let depts = ["IT", "HR", "SL", "TR"];

    let option = "";

    for (let i = 0; i < depts.length; i++) {
        option += `<option value="${depts[i]}">${depts[i]}</option>`;
    }
    document.getElementById('lstdepts').innerHTML = option;
}








