let a: number = 10;
console.log(`a = ${a}`);
let b = a;
console.log(`With Assignments as b =a,  a = ${a} and b = ${b}`);
// lets modify b
b = 100;
console.log(`After chagbing b to 100 ,  a = ${a} and b = ${b}`);

let obj1 = { x: 10 };
console.log(`obj1.x is = ${obj1.x}`);
let obj2 = obj1; // Assignment, obj2 and obj1 will posint to same memory location, if one change other will also be changed
console.log(`With Assignments as obj2 = obj1,  obj1.x = ${obj1.x} and obj2.x = ${obj2.x}`);
// let modify obj2.x
obj2.x = 1000;
console.log(`After modificati obj2.x = 1000,  obj1.x = ${obj1.x} and obj2.x = ${obj2.x}`);
// instead of assigning objects directly, use Object.assign() method
// Parameter 1: {}, the  target empty object
// Parameter 2: The Soure oject to be cloned into the target object
//let obj3 = Object.assign({}, obj2);
//console.log(`With creating a clone obj3 from obj2 ,  obj2.x = ${obj2.x} and obj3.x = ${obj3.x}`);
//// update obj3.x
//obj3.x = 800;
//console.log(`With update to clone obj3 from obj2 ,  obj2.x = ${obj2.x} and obj3.x = ${obj3.x}`);

let arr1 = [10, 20, 30, 40];
console.log(`arra1 = ${arr1}`);
arr1 = [...arr1, 50, 60, 70]; // SPread
console.log(`After Spread arra1 = ${arr1}`);

let obj4 = { a: 10 };
console.log(`obj4 = ${JSON.stringify(obj4)}`);

// Object SPread
let obj5 = { ...obj4, x:30};
console.log(`obj4 = ${JSON.stringify(obj5)}`);

// Valu Comparision

console.log(1 == 1); // true
