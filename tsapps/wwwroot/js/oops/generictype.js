var arr = new Array();
arr.push(10);
arr.push(20);
arr.push(30);
var arrStr = new Array();
arrStr.push('MAhesh');
arrStr.push('Ajay');
var Employee = /** @class */ (function () {
    function Employee(EmpNo, EmpName) {
        this.EmpNo = EmpNo;
        this.EmpName = EmpName;
    }
    return Employee;
}());
var arrEmp = new Array();
arrEmp.push(new Employee(101, 'A'));
arrEmp.push(new Employee(102, 'B'));
var emp = new Employee(103, 'C');
var propertyNames = Object.keys(emp);
console.log(propertyNames);
//# sourceMappingURL=generictype.js.map