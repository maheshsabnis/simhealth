// Using ARrays with iterations
let names = ["Mukesh", "Mahesh", "Amit", "Tejas", "Vikram", "Manish", "Suprotim", "Abhijit", "Ashwin", "Prashant", "Vivek", "Satish", "Sandeep", "Vinay", "Tushar"];
// Iterate usng for..of loop
for (let n of names) {
    console.log(`Name = ${n}`);
}

// USing forEach() method

// explict Callback Function
function printValues(n: string, i: number) {
    console.log(`Record on ${i}ths position is = ${n}`);
}
// passing callbacj function
names.forEach(printValues);
// Instead of passing explict Callback FUnction, use ES 6 Arrow operator
console.log();
console.log('USing Arrow');
names.forEach((n: string, i: number) => {
    console.log(`Record on ${i}ths position is = ${n}`);
});
