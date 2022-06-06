var val;
val = 1000;
console.log("Number val = ".concat(val));
val = "Mahesh";
console.log("String val = ".concat(val));
function processValues(parmeter) {
    console.log(parmeter);
}
processValues([10, 20, 30]); // number array
processValues(["A", "B", "C"]); // string values
function processValuesAny(parmeter) {
    var result;
    var numberSum = 0;
    var stringConcat = '';
    parmeter.forEach(function (n, i) {
        if (typeof (n) === 'number') {
            console.log("".concat(n));
            numberSum += n;
        }
        else {
            if (typeof (n) === 'string') {
                stringConcat += n.toUpperCase();
            }
        }
    });
    return [numberSum, stringConcat];
}
console.log(processValuesAny([10, 20, 30, 40]));
console.log(processValuesAny(["a", 'b', 'cd', 'efg']));
//# sourceMappingURL=unitonTypes.js.map