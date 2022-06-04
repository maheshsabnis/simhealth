// Using ARrays with iterations
let data = ["Mukesh", "Mahesh", "Amit", "Tejas", "Vikram", "Manish", "Suprotim", "Abhijit", "Ashwin", "Prashant", "Vivek", "Satish", "Sandeep", "Vinay", "Tushar"];

let res = data.map((n: string, i: number) => {
    if (n.length >= 7) {
        return n.toUpperCase();
    }
});

console.log(`Original ARray is = ${JSON.stringify(data)} and its length i = ${data.length}`);
console.log();
console.log(`Resultant ARray is = ${JSON.stringify(res)} and its length i = ${res.length}`);
console.log();

console.log('Using filter');

let res1 = data.filter((n: string, i: number) => {
    if (n.length >= 7) {
        return n.toUpperCase();
    }
});

console.log(`Original ARray is = ${JSON.stringify(data)} and its length i = ${data.length}`);
console.log();
console.log(`Resultant ARray is = ${JSON.stringify(res1)} and its length i = ${res1.length}`);
console.log();


