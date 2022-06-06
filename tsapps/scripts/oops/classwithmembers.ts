class ClsMembers {
  // default is public
    private num1: number = 0;
    num2: number = 20;

     

    constructor(n1: number) {
        this.num1 = n1;
    }

    printValues(): void {
        console.log(`Value for Private num1 is = ${this.num1}`);  
    }
}