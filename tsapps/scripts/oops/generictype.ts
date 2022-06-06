let arr: Array<number> = new Array<number>();
arr.push(10);
arr.push(20);
arr.push(30);

let arrStr: Array<string> = new Array<string>();
arrStr.push('MAhesh');
arrStr.push('Ajay');

class Employee {
    constructor(
        public EmpNo: number,
        public EmpName: string 
    ) { }
}

let arrEmp: Array<Employee> = new Array<Employee>();
arrEmp.push(new Employee(101, 'A'));
arrEmp.push(new Employee(102, 'B'));

let emp = new Employee(103, 'C');

let propertyNames = Object.keys(emp);
console.log(propertyNames);
let propertyValues = Object.values(emp);
console.log(propertyValues);