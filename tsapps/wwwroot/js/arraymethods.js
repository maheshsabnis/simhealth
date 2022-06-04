// Using ARrays with iterations
var data = ["Mukesh", "Mahesh", "Amit", "Tejas", "Vikram", "Manish", "Suprotim", "Abhijit", "Ashwin", "Prashant", "Vivek", "Satish", "Sandeep", "Vinay", "Tushar"];
var res = data.map(function (n, i) {
    if (n.length >= 7) {
        return n.toUpperCase();
    }
});
console.log("Original ARray is = ".concat(JSON.stringify(data), " and its length i = ").concat(data.length));
console.log();
console.log("Resultant ARray is = ".concat(JSON.stringify(res), " and its length i = ").concat(res.length));
console.log();
console.log('Using filter');
var res1 = data.filter(function (n, i) {
    if (n.length >= 7) {
        return n.toUpperCase();
    }
});
console.log("Original ARray is = ".concat(JSON.stringify(data), " and its length i = ").concat(data.length));
console.log();
console.log("Resultant ARray is = ".concat(JSON.stringify(res1), " and its length i = ").concat(res1.length));
console.log();
//# sourceMappingURL=arraymethods.js.map