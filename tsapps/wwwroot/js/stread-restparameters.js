// the following function can be passed with
// variable number of parametersy
// ...values will be internally used as 'arguments array' by the compiler
// that why the 'length' property and 'forEach()' method is accessible
function summation() {
    var values = [];
    for (var _i = 0; _i < arguments.length; _i++) {
        values[_i] = arguments[_i];
    }
    var sum = 0;
    if (values.length > 0) {
        values.forEach(function (n, idx) {
            sum += n;
        });
    }
    else {
        sum = 0;
    }
    return sum;
}
console.log("2 Parameters is = ".concat(summation(1, 2)));
console.log("3 Parameters is = ".concat(summation(1, 2, 3)));
console.log("4 Parameters is = ".concat(summation(1, 2, 3, 4)));
//# sourceMappingURL=stread-restparameters.js.map