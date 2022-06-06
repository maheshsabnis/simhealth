var EmployeeInfo = /** @class */ (function () {
    function EmployeeInfo(EmpNo, EmpName, DeptName, Designation, Salary) {
        this.EmpNo = EmpNo;
        this.EmpName = EmpName;
        this.DeptName = DeptName;
        this.Designation = Designation;
        this.Salary = Salary;
    }
    return EmployeeInfo;
}());
var EmployeeLogic = /** @class */ (function () {
    function EmployeeLogic() {
        this.employees = new Array();
        this.employees.push(new EmployeeInfo(101, 'Mahesh', 'IT', 'Director', 12345));
    }
    EmployeeLogic.prototype.getEmployees = function () {
        return this.employees;
    };
    EmployeeLogic.prototype.addEmployee = function (emp) {
        this.employees.push(emp);
        return this.employees;
    };
    EmployeeLogic.prototype.updateEmployee = function (emp) {
        // YOUR HEADACHE
        return this.employees;
    };
    EmployeeLogic.prototype.deleteEmployee = function (emp) {
        // YOUR HEADACHE
        return this.employees;
    };
    EmployeeLogic.prototype.searchEmployees = function (crtieria) {
        // criteria will be an object e.g.
        // criteria={DeptName:IT}, search based on DeptName
        // criteria={Designation:Manager}, search based on Designation
        // criteria={DeptName:IT,Designation:Manager} AND Condition means Serach By DeptName and DEsignation
        // YOUR HEADACHE
        return this.employees;
    };
    return EmployeeLogic;
}());
//# sourceMappingURL=application.js.map