// Using ARrays with iterations
var names = ["Mukesh", "Mahesh", "Amit", "Tejas", "Vikram", "Manish", "Suprotim", "Abhijit", "Ashwin", "Prashant", "Vivek", "Satish", "Sandeep", "Vinay", "Tushar"];
// Iterate usng for..of loop
for (var _i = 0, names_1 = names; _i < names_1.length; _i++) {
    var n = names_1[_i];
    console.log("Name = ".concat(n));
}
// USing forEach() method
// explict Callback Function
function printValues(n, i) {
    console.log("Record on ".concat(i, "ths position is = ").concat(n));
}
// passing callbacj function
names.forEach(printValues);
// Instead of passing explict Callback FUnction, use ES 6 Arrow operator
console.log();
console.log('USing Arrow');
names.forEach(function (n, i) {
    console.log("Record on ".concat(i, "ths position is = ").concat(n));
});
//# sourceMappingURL=arrays.js.map