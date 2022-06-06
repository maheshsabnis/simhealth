let val: number | string;

val = 1000;
console.log(`Number val = ${val}`);
val = "Mahesh";
console.log(`String val = ${val}`);


function processValues(parmeter: number[] | string[]): void {
    console.log(parmeter);
}

processValues([10, 20, 30]); // number array
processValues(["A", "B", "C"]); // string values


function processValuesAny(parmeter: Array<number> | Array<string>): any {
    let result: any;
    let numberSum: number = 0;
    let stringConcat: string = '';
    parmeter.forEach((n, i) => {
      
        if (typeof (n) === 'number') {
            console.log(`${n}`);
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