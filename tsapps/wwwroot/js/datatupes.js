// AN Implicit Type declaration based on Right-Hand-Side INitial value
var n1 = 1000;
var n2; // Explicit DataType DEclaration
n2 = 10; // valid
// Strings
var firstName = "Mahesh";
var middleName = "Rameshrao";
var lastName = "Sabnis";
// Traditional String Concatination
var fullNameTraditional = firstName + ' ' + middleName + ' ' + lastName;
console.log(fullNameTraditional);
// ES 6 Template String aka String INterpoation
// Build a SIngle Immutable STring Object
var templateString = "".concat(firstName, " ").concat(middleName, " \n \n        ").concat(lastName);
console.log("USing Interpolation ".concat(templateString));
window.onload = function () {
    var depts = ["IT", "HR", "SL", "TR"];
    var option = "";
    for (var i = 0; i < depts.length; i++) {
        option += "<option value=\"".concat(depts[i], "\">").concat(depts[i], "</option>");
    }
    document.getElementById('lstdepts').innerHTML = option;
};
//# sourceMappingURL=datatupes.js.map