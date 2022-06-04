var __assign = (this && this.__assign) || function () {
    __assign = Object.assign || function(t) {
        for (var s, i = 1, n = arguments.length; i < n; i++) {
            s = arguments[i];
            for (var p in s) if (Object.prototype.hasOwnProperty.call(s, p))
                t[p] = s[p];
        }
        return t;
    };
    return __assign.apply(this, arguments);
};
var __spreadArray = (this && this.__spreadArray) || function (to, from, pack) {
    if (pack || arguments.length === 2) for (var i = 0, l = from.length, ar; i < l; i++) {
        if (ar || !(i in from)) {
            if (!ar) ar = Array.prototype.slice.call(from, 0, i);
            ar[i] = from[i];
        }
    }
    return to.concat(ar || Array.prototype.slice.call(from));
};
var a = 10;
console.log("a = ".concat(a));
var b = a;
console.log("With Assignments as b =a,  a = ".concat(a, " and b = ").concat(b));
// lets modify b
b = 100;
console.log("After chagbing b to 100 ,  a = ".concat(a, " and b = ").concat(b));
var obj1 = { x: 10 };
console.log("obj1.x is = ".concat(obj1.x));
var obj2 = obj1; // Assignment, obj2 and obj1 will posint to same memory location, if one change other will also be changed
console.log("With Assignments as obj2 = obj1,  obj1.x = ".concat(obj1.x, " and obj2.x = ").concat(obj2.x));
// let modify obj2.x
obj2.x = 1000;
console.log("After modificati obj2.x = 1000,  obj1.x = ".concat(obj1.x, " and obj2.x = ").concat(obj2.x));
// instead of assigning objects directly, use Object.assign() method
// Parameter 1: {}, the  target empty object
// Parameter 2: The Soure oject to be cloned into the target object
//let obj3 = Object.assign({}, obj2);
//console.log(`With creating a clone obj3 from obj2 ,  obj2.x = ${obj2.x} and obj3.x = ${obj3.x}`);
//// update obj3.x
//obj3.x = 800;
//console.log(`With update to clone obj3 from obj2 ,  obj2.x = ${obj2.x} and obj3.x = ${obj3.x}`);
var arr1 = [10, 20, 30, 40];
console.log("arra1 = ".concat(arr1));
arr1 = __spreadArray(__spreadArray([], arr1, true), [50, 60, 70], false); // SPread
console.log("After Spread arra1 = ".concat(arr1));
var obj4 = { a: 10 };
console.log("obj4 = ".concat(JSON.stringify(obj4)));
// Object SPread
var obj5 = __assign(__assign({}, obj4), { x: 30 });
console.log("obj4 = ".concat(JSON.stringify(obj5)));
// Valu Comparision
console.log(1 == 1); // true
//# sourceMappingURL=objetfacts.js.map