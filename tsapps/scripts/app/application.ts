class EmployeeInfo {
    constructor(public EmpNo: number, public EmpName: string, public DeptName:string, public Designation:string, public Salary:number) { }
}

class EmployeeLogic {
    private employees: Array<EmployeeInfo>;
    constructor() {
        this.employees = new Array<EmployeeInfo>();
        this.employees.push(new EmployeeInfo(101, 'Mahesh', 'IT', 'Director',12345));
    }

    getEmployees(): Array<EmployeeInfo> {
        return this.employees;
    }

    addEmployee(emp: EmployeeInfo): Array<EmployeeInfo> {
        this.employees.push(emp);
        return this.employees;
    }

    updateEmployee(emp: EmployeeInfo): Array<EmployeeInfo> {
        // YOUR HEADACHE
        return this.employees;
    }
    deleteEmployee(emp: EmployeeInfo): Array<EmployeeInfo> {
        // YOUR HEADACHE
        return this.employees;
    }

    searchEmployees(crtieria): Array<EmployeeInfo> {
        // criteria will be an object e.g.
        // criteria={DeptName:IT}, search based on DeptName
         // criteria={Designation:Manager}, search based on Designation
        // criteria={DeptName:IT,Designation:Manager} AND Condition means Serach By DeptName and DEsignation
        // YOUR HEADACHE
        return this.employees;
    }
}

class UIGenerator {
    listGeerator(dataSource): string {
        // This method will generate <select><option></option></select> based on dataSource 0
    }
    tableGenerator(dataSource): string {
        // dataSource will be an array of EmployeeInfo 
        // Generate <table> <thead><tr><th></th></tr> </thead><tbody><tr><td></td></tr></tabody> </table>
    }
}