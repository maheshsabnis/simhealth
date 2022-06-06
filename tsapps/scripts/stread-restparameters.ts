// the following function can be passed with
// variable number of parametersy
// ...values will be internally used as 'arguments array' by the compiler
// that why the 'length' property and 'forEach()' method is accessible
function summation(...values): number {
    let sum: number = 0;
    if (values.length > 0) {
        values.forEach((n: number, idx: number) => {
            sum += n; 
        });
    } else {
        sum = 0; 
    }
    return sum;
}

console.log(`2 Parameters is = ${summation(1, 2)}`);
console.log(`3 Parameters is = ${summation(1, 2, 3)}`);
console.log(`4 Parameters is = ${summation(1, 2, 3, 4)}`);